using Servicelager;
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
    public partial class regForm : Form
    {
        private Datalager datalager;
        private InloggningController controller;
        public regForm(Datalager datalager)
        {
            InitializeComponent();
            this.datalager = datalager;
            controller = new InloggningController(datalager);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Student? student = controller.RegistreraStudent
                (
                txtAnvandare.Text,
                txtLosen.Text,
                txtFornamn.Text,
                txtEfternamn.Text,
                txtEpost.Text,
                txtNummer.Text
                );
            if (student != null)
            {
                InloggForm inloggForm = new InloggForm();
                MessageBox.Show("Kontot är skapat!");
                this.Close();
                inloggForm.Show();
            }
            else
            {
                MessageBox.Show("Något fält är tomt eller är användarnamnet upptaget.");
            }
        }
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            InloggForm inloggForm = new InloggForm();
            this.Close();
            inloggForm.Show();
        }
    }
}
