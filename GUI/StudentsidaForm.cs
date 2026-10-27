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
    public partial class StudentsidaForm : Form
    {
        private Datalager datalager;
        private Student InloggadStudent;

        private List<Annons> annonser;
        private List<Affär> affärer;
        private ReserveraAnnonsController controller;
        public StudentsidaForm(Datalager datalager, Student inloggadStudent) 
        {
            InitializeComponent();
            this.InloggadStudent = inloggadStudent;
            this.datalager = datalager;
            controller = new ReserveraAnnonsController(datalager);
            
           

            panelStartsida.Visible = true;
            panelMinaAnnonser.Visible = false;

            lblVälkommen.Text = InloggadStudent.Presentera();

            annonser = controller.HämtaAllaAnnonser();
            FyllTabellAnnonser(annonser);
            dataGridViewMinaAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            affärer = controller.HämtaAllaAffärer();
            FyllTabellReserveradeAffärer(affärer);
            dataGridViewReserveradeAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        //fyller datagrid i "Mina annonser" med data från datalagret där studenten står som säljare
        //kontrollerar också vilken typ av annons det är
        private void FyllTabellAnnonser(List<Annons> annonser)
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

        private void FyllTabellReserveradeAffärer(List<Affär> affärer)
        {
            foreach (Affär affär in affärer)
            {
                if (affär.Säljare != InloggadStudent)
                {
                    continue;
                }
                if (affär.Status != AffärStatus.Reserverad)
                {
                    continue;
                }

                dataGridViewReserveradeAnnonser.Rows.Add(
                        affär.Id,
                        affär.Annons.Titel,
                        affär.Annons.Pris,
                        affär.Köpare.Användarnamn,
                        affär.Status,
                        affär.Reservationsdatum

                        );

            }
        }

        //visar startsidan när Startsida knappen används
        private void btnVisaStartSida_Click(object sender, EventArgs e)
        {
            panelMinaAnnonser.Visible = false;
            panelStartsida.Visible = true;

        }

        //öppnar LedigaAnnonserForm - för reservation
        private void btnLedigaAnnonser_Click(object sender, EventArgs e)
        {
            LedigaAnnonserForm ledigaAnnonserForm = new LedigaAnnonserForm(datalager, InloggadStudent);
            ledigaAnnonserForm.ShowDialog();
        }

        //öppnar SkapaAnnonsForm för att låta användaren skapa en ny annons
        private void btnSkapaAnnons_Click(object sender, EventArgs e)
        {
            SkapaAnnonsForm skapaAnnons = new SkapaAnnonsForm(datalager, InloggadStudent);
            skapaAnnons.ShowDialog();
        }

        // visar panelen med användarens egna annonser. 
        //Tömmer datagrid och fyller på med korrekt data vid klick
        private void btnMinaAnnonser_Click(object sender, EventArgs e)
        {
            dataGridViewMinaAnnonser.Rows.Clear();
            dataGridViewReserveradeAnnonser.Rows.Clear();

            annonser = controller.HämtaAllaAnnonser();
            FyllTabellAnnonser(annonser);

            affärer = controller.HämtaAllaAffärer();
            FyllTabellReserveradeAffärer(affärer);

            panelStartsida.Visible = false;
            panelMinaAnnonser.Visible = true;
        }


        //bekräftar köp, alltså markerar en affär som genomförd. 
        private void btnBekräftaKöp_Click(object sender, EventArgs e)
        {
            if (dataGridViewReserveradeAnnonser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Markera en affär först");
                return;
            }

            int affärId = Convert.ToInt32(dataGridViewReserveradeAnnonser.SelectedRows[0].Cells[0].Value);

            foreach (Affär affär in affärer)
            {
                if (affär.Id == affärId &&
                    affär.Säljare == InloggadStudent &&
                    affär.Status == AffärStatus.Reserverad)
                {
                    bool lyckades = controller.BekräftaKöp(affär);
                    if (lyckades)
                    {
                        MessageBox.Show("Köpet har bekräftats!");
                    }
                    else
                    {
                        MessageBox.Show("Köpet kunde inte bekräftas.");
                    }

                    break;
                }
            }

            //fyller båda datagriden med ny relevant data 
            dataGridViewMinaAnnonser.Rows.Clear();
            dataGridViewReserveradeAnnonser.Rows.Clear();

            annonser = controller.HämtaAllaAnnonser();
            FyllTabellAnnonser(annonser);

            affärer = datalager.HämtaAffärer();
            FyllTabellReserveradeAffärer(affärer);


        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
