using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Servicelager;
using Models;

namespace GUI
{
    public partial class LedigaAnnonserForm : Form
    {
        private Student InloggadStudent;
        private Datalager datalager;
        private ReserveraAnnonsController controller;
        private Annons valdAnnons;

        private List<Annons> annonser;

        public LedigaAnnonserForm(Datalager datalager, Student inloggadStudent)
        {
            InitializeComponent();

            controller = new ReserveraAnnonsController(datalager);
            this.datalager = datalager;
            this.InloggadStudent = inloggadStudent; //student 2 "erik" 

            //tillgängliga annonser hämtas och datagrid fylls med dem
            annonser = controller.ListaTillgängligaAnnonser();

            FyllTabell(annonser);
            dataGridViewLedigaAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //panelen för detaljvy är från början gömd
            panelDetaljVy.Visible = false;
        }

        //metod som fyller datagrid med tillgängliga annonser
        private void FyllTabell(List<Annons> annonser)
        {
            foreach (Annons annons in annonser)
            {
                string typ = "";

                if (annons is Kursbok)
                {
                    typ = "Kursbok";
                }
                else if (annons is Kompendium)
                {
                    typ = "Kompendium";

                }
                else if (annons is DigitalResurs)
                {
                    typ = "DigitalResurs";
                }
                dataGridViewLedigaAnnonser.Rows.Add(
                    annons.Id,
                    annons.Titel,
                    annons.Kurs.Namn,
                    annons.Pris,
                    annons.Skick,
                    typ
                    );
            }
        }

        //reserverar annons om en annons är markerad i datagrid
        private void btnReserveraAnnons_Click(object sender, EventArgs e)
        {
            if (dataGridViewLedigaAnnonser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Markera en annons först");
                return;
            }
            //hämtar annonsID från den markerade annonsen i datagrid
            int annonsId = Convert.ToInt32(dataGridViewLedigaAnnonser.SelectedRows[0].Cells[0].Value);

            bool lyckades = controller.ReserveraAnnons(annonsId, InloggadStudent);

            if (lyckades)
            {
                MessageBox.Show("Annonsen har reserverats");
                //Tömmer raderna i datagrid för att fylla med uppdaterade listan annonser
                dataGridViewLedigaAnnonser.Rows.Clear();
                annonser = controller.ListaTillgängligaAnnonser();
                FyllTabell(annonser);
                panelDetaljVy.Visible= false;
            }

            else
            {
                MessageBox.Show("Det gick inte att reservera annonsen");
            }
        }

       
        // visar den detaljerade vyn för annonsen om en annons är markerad
        private void btnVisaDetaljer_Click(object sender, EventArgs e)
        {
            if (dataGridViewLedigaAnnonser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Markera en annons först.");
                return;
            }
            panelDetaljVy.Visible = true;
            

            int annonsId = Convert.ToInt32(dataGridViewLedigaAnnonser.SelectedRows[0].Cells[0].Value);
            valdAnnons = null;

            foreach (Annons annons in annonser)
            {
                if (annons.Id == annonsId)
                {
                    valdAnnons = annons;
                    break;
                }
            }

            if (valdAnnons != null)
            {
                lblDetaljVyInformation.Text = valdAnnons.VisaDetaljer();

            }
        }

        //stänger detaljvyn
        private void btnStängDetaljVy_Click(object sender, EventArgs e)
        {
            panelDetaljVy.Visible = false;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
