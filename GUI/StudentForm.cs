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
    public partial class StudentForm : Form
    {
        private Datalager datalager;
        private Student InloggadStudent;
        public StudentForm() //justera här sen så StudentForm() tar emot datalager och inloggadstudent
        {
            InitializeComponent();

            datalager = new Datalager();
            InloggadStudent = datalager.Studenter[1];
        }



        private void btnVisaLedigaAnnonser_Click(object sender, EventArgs e)
        {
            LedigaAnnonserForm ledigaAnnonserForm = new LedigaAnnonserForm(datalager, InloggadStudent);
            ledigaAnnonserForm.ShowDialog();
        }

        private void btnSkapaAnnons_Click(object sender, EventArgs e)
        {
            SkapaAnnons skapaAnnons = new SkapaAnnons(datalager, InloggadStudent);
            skapaAnnons.ShowDialog();
        }

        private void btnVisaMinaAnnonser_Click(object sender, EventArgs e)
        {
            MinaAnnonser minaAnnonser = new MinaAnnonser(datalager, InloggadStudent);
            minaAnnonser.ShowDialog();
        }
    }
}
