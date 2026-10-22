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
            InloggningController controller = new InloggningController(datalager);

            Användare? användare = controller.LoggaIn(
                txtNamn.Text,
                txtLosen.Text);

            if (användare is Student student)
            {
                StudentsidaForm studentsidaForm = new StudentsidaForm(datalager, student);
                studentsidaForm.Show();
                this.Hide();
            }

            else if (användare is Administratör administratör)
            {
                AdminForm adminForm = new AdminForm(datalager, administratör);
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            regForm regform = new regForm(datalager);
            this.Hide();
            regform.Show();
            
        }
    }
}
