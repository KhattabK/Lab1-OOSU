using Models;
using Servicelager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MinaAnnonser : Form
    {
        private Student InloggadStudent;
        private Datalager datalager;
        private List<Annons> annonser;
        private ReserveraAnnonsController controller;

        public MinaAnnonser(Datalager datalager, Student inloggadStudent)
        {
            InitializeComponent();
            this.datalager = datalager;
            this.InloggadStudent = inloggadStudent;
            controller = new ReserveraAnnonsController(datalager);

            annonser = controller.HämtaAllaAnnonser();
            FyllTabell(annonser);
            dataGridViewMinaAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void FyllTabell(List<Annons> annonser)
        {
            foreach (Annons annons in annonser)
            {
                if (annons.Säljare != InloggadStudent)
                {
                    continue;
                }

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
                dataGridViewMinaAnnonser.Rows.Add(
                    annons.Id,
                    annons.Titel,
                    annons.Kurs.Namn,
                    annons.Pris,
                    annons.Skick,
                    typ,
                    annons.Status
                    );
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
