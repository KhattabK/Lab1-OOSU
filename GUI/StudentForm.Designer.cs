namespace GUI
{
    partial class StudentForm
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
            btnVisaLedigaAnnonser = new Button();
            panelRubrik = new Panel();
            lblStudentsida = new Label();
            lblBookSwap = new Label();
            btnVisaMinaAnnonser = new Button();
            btnSkapaAnnons = new Button();
            panelInnehåll = new Panel();
            label2 = new Label();
            lblTitelSkapaAnnons = new Label();
            lblBeskrivningSkapaAnnons = new Label();
            lblTitelMinaAnnonser = new Label();
            lblBeskrivningMinaAnnonser = new Label();
            lblTitelLedigaAnnonser = new Label();
            lblBeskrivningLedigaAnnonser = new Label();
            panelRubrik.SuspendLayout();
            panelInnehåll.SuspendLayout();
            SuspendLayout();
            // 
            // btnVisaLedigaAnnonser
            // 
            btnVisaLedigaAnnonser.Location = new Point(170, 110);
            btnVisaLedigaAnnonser.Name = "btnVisaLedigaAnnonser";
            btnVisaLedigaAnnonser.Size = new Size(171, 49);
            btnVisaLedigaAnnonser.TabIndex = 0;
            btnVisaLedigaAnnonser.Text = "Visa lediga annonser";
            btnVisaLedigaAnnonser.UseVisualStyleBackColor = true;
            btnVisaLedigaAnnonser.Click += btnVisaLedigaAnnonser_Click;
            // 
            // panelRubrik
            // 
            panelRubrik.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRubrik.BackColor = SystemColors.ControlLight;
            panelRubrik.Controls.Add(lblStudentsida);
            panelRubrik.Controls.Add(lblBookSwap);
            panelRubrik.Location = new Point(13, 12);
            panelRubrik.Name = "panelRubrik";
            panelRubrik.Size = new Size(775, 85);
            panelRubrik.TabIndex = 1;
            // 
            // lblStudentsida
            // 
            lblStudentsida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStudentsida.AutoSize = true;
            lblStudentsida.Location = new Point(333, 38);
            lblStudentsida.Name = "lblStudentsida";
            lblStudentsida.Size = new Size(87, 20);
            lblStudentsida.TabIndex = 1;
            lblStudentsida.Text = "Studentsida";
            // 
            // lblBookSwap
            // 
            lblBookSwap.Anchor = AnchorStyles.Top;
            lblBookSwap.AutoSize = true;
            lblBookSwap.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookSwap.Location = new Point(312, 0);
            lblBookSwap.Name = "lblBookSwap";
            lblBookSwap.Size = new Size(144, 38);
            lblBookSwap.TabIndex = 0;
            lblBookSwap.Text = "BookSwap";
            // 
            // btnVisaMinaAnnonser
            // 
            btnVisaMinaAnnonser.Location = new Point(539, 110);
            btnVisaMinaAnnonser.Name = "btnVisaMinaAnnonser";
            btnVisaMinaAnnonser.Size = new Size(171, 49);
            btnVisaMinaAnnonser.TabIndex = 2;
            btnVisaMinaAnnonser.Text = "Visa mina annonser";
            btnVisaMinaAnnonser.UseVisualStyleBackColor = true;
            btnVisaMinaAnnonser.Click += btnVisaMinaAnnonser_Click;
            // 
            // btnSkapaAnnons
            // 
            btnSkapaAnnons.Location = new Point(170, 273);
            btnSkapaAnnons.Name = "btnSkapaAnnons";
            btnSkapaAnnons.Size = new Size(171, 47);
            btnSkapaAnnons.TabIndex = 3;
            btnSkapaAnnons.Text = "Skapa  annons";
            btnSkapaAnnons.UseVisualStyleBackColor = true;
            btnSkapaAnnons.Click += btnSkapaAnnons_Click;
            // 
            // panelInnehåll
            // 
            panelInnehåll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInnehåll.Controls.Add(label2);
            panelInnehåll.Controls.Add(lblTitelSkapaAnnons);
            panelInnehåll.Controls.Add(lblBeskrivningSkapaAnnons);
            panelInnehåll.Controls.Add(lblTitelMinaAnnonser);
            panelInnehåll.Controls.Add(lblBeskrivningMinaAnnonser);
            panelInnehåll.Controls.Add(lblTitelLedigaAnnonser);
            panelInnehåll.Controls.Add(lblBeskrivningLedigaAnnonser);
            panelInnehåll.Controls.Add(btnSkapaAnnons);
            panelInnehåll.Controls.Add(btnVisaLedigaAnnonser);
            panelInnehåll.Controls.Add(btnVisaMinaAnnonser);
            panelInnehåll.Location = new Point(13, 101);
            panelInnehåll.Name = "panelInnehåll";
            panelInnehåll.Size = new Size(775, 337);
            panelInnehåll.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 226);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 10;
            label2.Text = "Mina köp/reservationer???";
            // 
            // lblTitelSkapaAnnons
            // 
            lblTitelSkapaAnnons.AutoSize = true;
            lblTitelSkapaAnnons.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitelSkapaAnnons.Location = new Point(21, 225);
            lblTitelSkapaAnnons.Name = "lblTitelSkapaAnnons";
            lblTitelSkapaAnnons.Size = new Size(126, 25);
            lblTitelSkapaAnnons.TabIndex = 9;
            lblTitelSkapaAnnons.Text = "Skapa annons";
            // 
            // lblBeskrivningSkapaAnnons
            // 
            lblBeskrivningSkapaAnnons.AutoSize = true;
            lblBeskrivningSkapaAnnons.Location = new Point(21, 250);
            lblBeskrivningSkapaAnnons.Name = "lblBeskrivningSkapaAnnons";
            lblBeskrivningSkapaAnnons.Size = new Size(166, 20);
            lblBeskrivningSkapaAnnons.TabIndex = 8;
            lblBeskrivningSkapaAnnons.Text = "Lägg upp en ny annons ";
            // 
            // lblTitelMinaAnnonser
            // 
            lblTitelMinaAnnonser.AutoSize = true;
            lblTitelMinaAnnonser.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitelMinaAnnonser.Location = new Point(396, 62);
            lblTitelMinaAnnonser.Name = "lblTitelMinaAnnonser";
            lblTitelMinaAnnonser.Size = new Size(137, 25);
            lblTitelMinaAnnonser.TabIndex = 7;
            lblTitelMinaAnnonser.Text = "Mina annonser";
            // 
            // lblBeskrivningMinaAnnonser
            // 
            lblBeskrivningMinaAnnonser.AutoSize = true;
            lblBeskrivningMinaAnnonser.Location = new Point(396, 87);
            lblBeskrivningMinaAnnonser.Name = "lblBeskrivningMinaAnnonser";
            lblBeskrivningMinaAnnonser.Size = new Size(235, 20);
            lblBeskrivningMinaAnnonser.TabIndex = 6;
            lblBeskrivningMinaAnnonser.Text = "Se annonser som du själv lagt upp";
            // 
            // lblTitelLedigaAnnonser
            // 
            lblTitelLedigaAnnonser.AutoSize = true;
            lblTitelLedigaAnnonser.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitelLedigaAnnonser.Location = new Point(21, 62);
            lblTitelLedigaAnnonser.Name = "lblTitelLedigaAnnonser";
            lblTitelLedigaAnnonser.Size = new Size(150, 25);
            lblTitelLedigaAnnonser.TabIndex = 5;
            lblTitelLedigaAnnonser.Text = "Lediga annonser";
            // 
            // lblBeskrivningLedigaAnnonser
            // 
            lblBeskrivningLedigaAnnonser.AutoSize = true;
            lblBeskrivningLedigaAnnonser.Location = new Point(21, 87);
            lblBeskrivningLedigaAnnonser.Name = "lblBeskrivningLedigaAnnonser";
            lblBeskrivningLedigaAnnonser.Size = new Size(320, 20);
            lblBeskrivningLedigaAnnonser.TabIndex = 4;
            lblBeskrivningLedigaAnnonser.Text = "Se och reservera kursböcker och andra resurser.";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRubrik);
            Controls.Add(panelInnehåll);
            Name = "StudentForm";
            Text = "StudentForm";
            panelRubrik.ResumeLayout(false);
            panelRubrik.PerformLayout();
            panelInnehåll.ResumeLayout(false);
            panelInnehåll.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVisaLedigaAnnonser;
        private Panel panelRubrik;
        private Label lblStudentsida;
        private Label lblBookSwap;
        private Button btnVisaMinaAnnonser;
        private Button btnSkapaAnnons;
        private Panel panelInnehåll;
        private Label lblBeskrivningLedigaAnnonser;
        private Label lblTitelSkapaAnnons;
        private Label lblBeskrivningSkapaAnnons;
        private Label lblTitelMinaAnnonser;
        private Label lblBeskrivningMinaAnnonser;
        private Label lblTitelLedigaAnnonser;
        private Label label2;
    }
}