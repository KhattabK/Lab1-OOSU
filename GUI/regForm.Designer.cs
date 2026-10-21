namespace GUI
{
    partial class regForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAnvandare = new Label();
            txtAnvandare = new TextBox();
            lblLosen = new Label();
            lblFornamn = new Label();
            lblEpost = new Label();
            lblNummer = new Label();
            label6 = new Label();
            txtLosen = new TextBox();
            txtFornamn = new TextBox();
            txtEpost = new TextBox();
            txtNummer = new TextBox();
            btnReg = new Button();
            btnAvbryt = new Button();
            lblEfternamn = new Label();
            txtEfternamn = new TextBox();
            SuspendLayout();
            // 
            // lblAnvandare
            // 
            lblAnvandare.AutoSize = true;
            lblAnvandare.Location = new Point(90, 64);
            lblAnvandare.Name = "lblAnvandare";
            lblAnvandare.Size = new Size(101, 25);
            lblAnvandare.TabIndex = 0;
            lblAnvandare.Text = "Användare:";
            lblAnvandare.Click += label1_Click;
            // 
            // txtAnvandare
            // 
            txtAnvandare.Location = new Point(197, 58);
            txtAnvandare.Name = "txtAnvandare";
            txtAnvandare.Size = new Size(150, 31);
            txtAnvandare.TabIndex = 1;
            // 
            // lblLosen
            // 
            lblLosen.AutoSize = true;
            lblLosen.Location = new Point(101, 106);
            lblLosen.Name = "lblLosen";
            lblLosen.Size = new Size(90, 25);
            lblLosen.TabIndex = 2;
            lblLosen.Text = "Lösenord:";
            // 
            // lblFornamn
            // 
            lblFornamn.AutoSize = true;
            lblFornamn.Location = new Point(104, 155);
            lblFornamn.Name = "lblFornamn";
            lblFornamn.Size = new Size(87, 25);
            lblFornamn.TabIndex = 3;
            lblFornamn.Text = "Förnamn:";
            lblFornamn.Click += label3_Click;
            // 
            // lblEpost
            // 
            lblEpost.AutoSize = true;
            lblEpost.Location = new Point(123, 264);
            lblEpost.Name = "lblEpost";
            lblEpost.Size = new Size(68, 25);
            lblEpost.TabIndex = 4;
            lblEpost.Text = "E-post:";
            // 
            // lblNummer
            // 
            lblNummer.AutoSize = true;
            lblNummer.Location = new Point(52, 315);
            lblNummer.Name = "lblNummer";
            lblNummer.Size = new Size(139, 25);
            lblNummer.TabIndex = 5;
            lblNummer.Text = "Telefonnummer:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 366);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 6;
            // 
            // txtLosen
            // 
            txtLosen.Location = new Point(197, 106);
            txtLosen.Name = "txtLosen";
            txtLosen.Size = new Size(150, 31);
            txtLosen.TabIndex = 7;
            // 
            // txtFornamn
            // 
            txtFornamn.Location = new Point(197, 155);
            txtFornamn.Name = "txtFornamn";
            txtFornamn.Size = new Size(150, 31);
            txtFornamn.TabIndex = 8;
            // 
            // txtEpost
            // 
            txtEpost.Location = new Point(197, 261);
            txtEpost.Name = "txtEpost";
            txtEpost.Size = new Size(150, 31);
            txtEpost.TabIndex = 9;
            // 
            // txtNummer
            // 
            txtNummer.Location = new Point(197, 315);
            txtNummer.Name = "txtNummer";
            txtNummer.Size = new Size(150, 31);
            txtNummer.TabIndex = 10;
            // 
            // btnReg
            // 
            btnReg.Location = new Point(280, 384);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(112, 34);
            btnReg.TabIndex = 11;
            btnReg.Text = "Registrera";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += label1_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(162, 384);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(112, 34);
            btnAvbryt.TabIndex = 12;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // lblEfternamn
            // 
            lblEfternamn.AutoSize = true;
            lblEfternamn.Location = new Point(94, 208);
            lblEfternamn.Name = "lblEfternamn";
            lblEfternamn.Size = new Size(97, 25);
            lblEfternamn.TabIndex = 13;
            lblEfternamn.Text = "Efternamn:";
            lblEfternamn.Click += label1_Click_1;
            // 
            // txtEfternamn
            // 
            txtEfternamn.Location = new Point(197, 205);
            txtEfternamn.Name = "txtEfternamn";
            txtEfternamn.Size = new Size(150, 31);
            txtEfternamn.TabIndex = 14;
            // 
            // regForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 439);
            Controls.Add(txtEfternamn);
            Controls.Add(lblEfternamn);
            Controls.Add(btnAvbryt);
            Controls.Add(btnReg);
            Controls.Add(txtNummer);
            Controls.Add(txtEpost);
            Controls.Add(txtFornamn);
            Controls.Add(txtLosen);
            Controls.Add(label6);
            Controls.Add(lblNummer);
            Controls.Add(lblEpost);
            Controls.Add(lblFornamn);
            Controls.Add(lblLosen);
            Controls.Add(txtAnvandare);
            Controls.Add(lblAnvandare);
            Name = "regForm";
            Text = "Registrering";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnvandare;
        private TextBox txtAnvandare;
        private Label lblLosen;
        private Label lblFornamn;
        private Label lblEpost;
        private Label lblNummer;
        private Label label6;
        private TextBox txtLosen;
        private TextBox txtFornamn;
        private TextBox txtEpost;
        private TextBox txtNummer;
        private Button btnReg;
        private Button btnAvbryt;
        private Label lblEfternamn;
        private TextBox txtEfternamn;
    }
}