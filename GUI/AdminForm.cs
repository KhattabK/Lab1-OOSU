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
    public partial class AdminForm : Form
    {
        private Administratör inloggadAdmin;
        private KursController kursController;
        private ModereraAnnonsController modereraController;

        public AdminForm(Datalager datalager, Administratör inloggadAdmin)
        {
            InitializeComponent();
            this.inloggadAdmin = inloggadAdmin;

            // Samma datalager skickas vidare till controllerna, så alla fönster delar samma data
            kursController = new KursController(datalager);
            modereraController = new ModereraAnnonsController(datalager);

            lblVälkommen.Text = inloggadAdmin.Presentera();

            FyllKurser();
            panelKurser.Visible = true;
            panelAnnonser.Visible = false;
        }

        // ---------- Kurser ----------

        // Fyller tabellen med kurser. Kursobjektet sparas i radens Tag så vi slipper söka på kod
        private void FyllKurser()
        {
            dataGridViewKurser.Rows.Clear();

            foreach (Kurs kurs in kursController.HämtaKurser())
            {
                int rad = dataGridViewKurser.Rows.Add(kurs.Kod, kurs.Namn);
                dataGridViewKurser.Rows[rad].Tag = kurs;
            }
        }

        // Returnerar kursen på den markerade raden, eller null om ingen rad är markerad
        private Kurs? HämtaValdKurs()
        {
            if (dataGridViewKurser.SelectedRows.Count == 0)
            {
                return null;
            }
            return (Kurs)dataGridViewKurser.SelectedRows[0].Tag;
        }

        // När admin markerar en kurs fylls textrutorna, så den går att ändra direkt
        private void dataGridViewKurser_SelectionChanged(object sender, EventArgs e)
        {
            Kurs? kurs = HämtaValdKurs();
            if (kurs != null)
            {
                txtKod.Text = kurs.Kod;
                txtNamn.Text = kurs.Namn;
            }
        }

        private void btnLäggTillKurs_Click(object sender, EventArgs e)
        {
            bool lyckades = kursController.LäggTillKurs(txtKod.Text, txtNamn.Text);

            if (lyckades)
            {
                MessageBox.Show("Kursen har lagts till.");
                FyllKurser();
            }
            else
            {
                MessageBox.Show("Kursen kunde inte läggas till. Fyll i båda fälten och kontrollera att kurskoden inte redan finns.");
            }
        }

        private void btnÄndraKurs_Click(object sender, EventArgs e)
        {
            Kurs? kurs = HämtaValdKurs();
            if (kurs == null)
            {
                MessageBox.Show("Markera en kurs först.");
                return;
            }

            bool lyckades = kursController.ÄndraKurs(kurs, txtKod.Text, txtNamn.Text);

            if (lyckades)
            {
                MessageBox.Show("Kursen har ändrats.");
                FyllKurser();
            }
            else
            {
                MessageBox.Show("Kursen kunde inte ändras. Fyll i båda fälten och kontrollera att kurskoden inte redan finns.");
            }
        }

        private void btnTaBortKurs_Click(object sender, EventArgs e)
        {
            Kurs? kurs = HämtaValdKurs();
            if (kurs == null)
            {
                MessageBox.Show("Markera en kurs först.");
                return;
            }

            bool lyckades = kursController.TaBortKurs(kurs);

            if (lyckades)
            {
                MessageBox.Show("Kursen har tagits bort.");
                txtKod.Text = "";
                txtNamn.Text = "";
                FyllKurser();
            }
            else
            {
                MessageBox.Show("Kursen kan inte tas bort eftersom det finns annonser kopplade till den.");
            }
        }

        // ---------- Annonser ----------

        // Fyller tabellen med alla annonser. GetType().Name ger klassnamnet, t.ex. Kursbok
        private void FyllAnnonser()
        {
            dataGridViewAnnonser.Rows.Clear();

            foreach (Annons annons in modereraController.HämtaAllaAnnonser())
            {
                int rad = dataGridViewAnnonser.Rows.Add(
                    annons.Id,
                    annons.Titel,
                    annons.GetType().Name,
                    annons.Kurs.Namn,
                    annons.Säljare.Förnamn + " " + annons.Säljare.Efternamn,
                    annons.Pris,
                    annons.Status);

                dataGridViewAnnonser.Rows[rad].Tag = annons;
            }
        }

        private void btnTaBortAnnons_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnnonser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Markera en annons först.");
                return;
            }

            Annons annons = (Annons)dataGridViewAnnonser.SelectedRows[0].Tag;

            DialogResult svar = MessageBox.Show("Vill du ta bort annonsen " + annons.Titel + "?", "Ta bort annons", MessageBoxButtons.YesNo);
            if (svar == DialogResult.Yes)
            {
                modereraController.TaBortAnnons(annons);
                MessageBox.Show("Annonsen har tagits bort.");
                FyllAnnonser();
            }
        }

        // ---------- Meny ----------

        private void btnKurser_Click(object sender, EventArgs e)
        {
            FyllKurser();
            panelAnnonser.Visible = false;
            panelKurser.Visible = true;
        }

        // Annonserna läses in på nytt varje gång, så ändrade kursnamn och nya annonser syns
        private void btnAnnonser_Click(object sender, EventArgs e)
        {
            FyllAnnonser();
            panelKurser.Visible = false;
            panelAnnonser.Visible = true;
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}