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

        private List<Annons> annonser;
        
        public LedigaAnnonserForm(Datalager datalager, Student inloggadStudent)
        {
            InitializeComponent();
            
            controller = new ReserveraAnnonsController(datalager);
            this.datalager = datalager;
            this.InloggadStudent = inloggadStudent; //student 2 "erik" 

            annonser = controller.ListaTillgängligaAnnonser();
                
            FyllTabell(annonser);
            dataGridViewLedigaAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void FyllTabell(List<Annons>annonser)
        {
            foreach(Annons annons in annonser)
            {
                string typ = "";

                if(annons is Kursbok)
                {
                    typ = "Kursbok";
                }
                else if(annons is Kompendium)
                {
                    typ = "Kompendium";
   
                }
                else if(annons is DigitalResurs)
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
        private void btnReserveraAnnons_Click(object sender, EventArgs e)
        {
            if(dataGridViewLedigaAnnonser.SelectedRows.Count==0)
            {
                MessageBox.Show("Markera en annons först");
                return;
            }
            //hämtar annonsID från den markerade annonsen i datagrid
            int annonsId = Convert.ToInt32(dataGridViewLedigaAnnonser.SelectedRows[0].Cells[0].Value);

            bool lyckades = controller.ReserveraAnnons(annonsId, InloggadStudent);

            if(lyckades)
            {
                MessageBox.Show("Annonsen har reserverats");
                //Tömmer raderna i datagrid för att fylla med uppdaterade listan annonser
                dataGridViewLedigaAnnonser.Rows.Clear();
                annonser = controller.ListaTillgängligaAnnonser();
                FyllTabell(annonser);
            }

            else
            {
                MessageBox.Show("Det gick inte att reservera annonsen");
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
