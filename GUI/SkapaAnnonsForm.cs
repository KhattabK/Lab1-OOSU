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
    public partial class SkapaAnnonsForm : Form
    {
        private Student InloggadStudent;
        private Datalager datalager;

        private SkapaAnnonsController skapaAnnonsController;

        public SkapaAnnonsForm(Datalager datalager, Student inloggadStudent)
        {
            InitializeComponent();
            this.datalager = datalager;
            this.InloggadStudent = inloggadStudent;
            skapaAnnonsController = new SkapaAnnonsController(datalager);

            //Fyller combobox med  kurserna i datalagret och visar kursnamnen
            cmbKurs.DataSource = datalager.Kurser;
            cmbKurs.DisplayMember = "Namn";

            //Fyller comobox med alla skick från enumen Skick
            cmbAnnonsSkick.DataSource = Enum.GetValues(typeof(Skick));
        }

        //skapar en ny annons
        private void btnSkapaAnnons_Click(object sender, EventArgs e)
        {
            // Hämtar och validerar annonsens gemensamma uppgifter
            string titel = txtTitelInput.Text; 
            if (string.IsNullOrWhiteSpace(titel))
            {
                MessageBox.Show("Ange en titel.");
                return;
            }
            decimal pris;

            if (!decimal.TryParse(txtPrisInput.Text, out pris) || pris <= 0)
            {
                MessageBox.Show("Ange ett giltigt pris som är större än 0.");
                return;
            }
            Skick skick = (Skick)cmbAnnonsSkick.SelectedItem; 
            Kurs kurs = (Kurs)cmbKurs.SelectedItem;

            //kontrollerar att annonstyp är vald
            if (cmbAnnonsTyp.SelectedIndex == -1)
            {
                MessageBox.Show("Välj en annonstyp.");
                return;
            }
            // kontrollerar att skick är vald
            if (cmbAnnonsSkick.SelectedIndex == -1)
            {
                MessageBox.Show("Välj skicket på annonsen.");
                return;
            }
            //kontrollerar att kurs är vald
            if (cmbKurs.SelectedIndex == -1)
            {
                MessageBox.Show("Välj en kurs.");
                return;
            }

            //skapa Kursbok
            if (cmbAnnonsTyp.Text == "Kursbok")
            {
                string isbn = txtISBNInput.Text; 
                string författare = txtFörfattareInput.Text;

                if (string.IsNullOrWhiteSpace(isbn) ||string.IsNullOrWhiteSpace(författare))
                {
                    MessageBox.Show("Ange ISBN och författare.");
                    return;
                }
                int upplaga;

                if (!int.TryParse(txtUpplagaInput.Text, out upplaga))
                {
                    MessageBox.Show("Ange en giltig upplaga.");
                    return;
                }

                skapaAnnonsController.SkapaKursbok(titel, pris, skick, InloggadStudent, kurs, isbn, författare, upplaga);
            }
            //skapa kompendium
            else if (cmbAnnonsTyp.Text == "Kompendium")
            {
                int antalSidor;
                int utgivningsÅr;

                if (!int.TryParse(txtAntalSidor.Text, out antalSidor) || antalSidor <= 0)
                {
                    MessageBox.Show("Ange ett giltigt antal sidor.");
                    return;
                }
                if (!int.TryParse(txtUtgivningsår.Text, out utgivningsÅr) || utgivningsÅr <= 0)
                {
                    MessageBox.Show("Ange ett giltigt utgivningsår.");
                    return;
                }
                skapaAnnonsController.SkapaKompendium(titel, pris, skick, InloggadStudent, kurs, antalSidor, utgivningsÅr);
            }
            else if (cmbAnnonsTyp.Text == "Digital resurs")
            {
                string filformat = txtFilformatInput.Text;
                string leveranssätt = txtLeveranssätt.Text;

                if (string.IsNullOrWhiteSpace(filformat) ||string.IsNullOrWhiteSpace(leveranssätt))
                {
                    MessageBox.Show("Ange filformat och leveranssätt.");
                    return;
                }

                skapaAnnonsController.SkapaDigitalResurs(titel, pris, skick, InloggadStudent, kurs, filformat, leveranssätt);
            }

            MessageBox.Show("Annonsen har skapats!");
            this.Close();
        }

        //stänger fönstret utan att skapa en annons. 
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Paneler avgör vilken annonstyp som visas i botten av fönstret
        // Styrs här av combobox AnnonsTyp.
        private void cmbAnnonsTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelKursbok.Visible= false;
            panelKompendium.Visible= false;
            panelDigitalResurs.Visible= false;

            if (cmbAnnonsTyp.Text == "Kursbok")
            {
                panelKursbok.Visible = true;
            }
            else if (cmbAnnonsTyp.Text == "Kompendium")
            {
                panelKompendium.Visible = true;
            }
            else if (cmbAnnonsTyp.Text == "Digital resurs")
            {
                panelDigitalResurs.Visible = true;
            }
        }
    }
}
