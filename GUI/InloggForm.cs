using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Models;
using Servicelager;

namespace GUI
{
    public partial class InloggForm : Form
    {
        private Datalager datalager;
        public InloggForm()
        {
            InitializeComponent();
            datalager = new Datalager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datalager datalager = new Datalager();
            InloggningController controller = new InloggningController(datalager);

            Användare? användare = controller.LoggaIn(
                txtNamn.Text,
                txtLosen.Text);

            if (användare is Student)
            {
                MessageBox.Show("Inloggning lyckades!");
                
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            regForm regform = new regForm(datalager);
            regform.Show();
            this.Hide();
        }
    }
}
