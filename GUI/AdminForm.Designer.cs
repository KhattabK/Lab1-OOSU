namespace GUI
{
    partial class AdminForm
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
            panelMeny = new Panel();
            btnLoggaUt = new Button();
            btnAnnonser = new Button();
            btnKurser = new Button();
            lblVälkommen = new Label();
            panelKurser = new Panel();
            btnÄndraKurs = new Button();
            btnTaBortKurs = new Button();
            btnLäggTillKurs = new Button();
            txtNamn = new TextBox();
            lblNamn = new Label();
            txtKod = new TextBox();
            lblKod = new Label();
            dataGridViewKurser = new DataGridView();
            colKursKod = new DataGridViewTextBoxColumn();
            colKursNamn = new DataGridViewTextBoxColumn();
            panelAnnonser = new Panel();
            btnTaBortAnnons = new Button();
            dataGridViewAnnonser = new DataGridView();
            colAnnonsId = new DataGridViewTextBoxColumn();
            colAnnonsTitel = new DataGridViewTextBoxColumn();
            colAnnonsTyp = new DataGridViewTextBoxColumn();
            colAnnonsKurs = new DataGridViewTextBoxColumn();
            colAnnonsSäljare = new DataGridViewTextBoxColumn();
            colAnnonsPris = new DataGridViewTextBoxColumn();
            colAnnonsStatus = new DataGridViewTextBoxColumn();
            panelMeny.SuspendLayout();
            panelKurser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKurser).BeginInit();
            panelAnnonser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnnonser).BeginInit();
            SuspendLayout();
            // 
            // panelMeny
            // 
            panelMeny.Controls.Add(btnLoggaUt);
            panelMeny.Controls.Add(btnAnnonser);
            panelMeny.Controls.Add(btnKurser);
            panelMeny.Controls.Add(lblVälkommen);
            panelMeny.Location = new Point(12, 12);
            panelMeny.Name = "panelMeny";
            panelMeny.Size = new Size(170, 420);
            panelMeny.TabIndex = 0;
            // 
            // btnLoggaUt
            // 
            btnLoggaUt.Location = new Point(20, 360);
            btnLoggaUt.Name = "btnLoggaUt";
            btnLoggaUt.Size = new Size(130, 40);
            btnLoggaUt.TabIndex = 4;
            btnLoggaUt.Text = "Logga ut";
            btnLoggaUt.UseVisualStyleBackColor = true;
            btnLoggaUt.Click += btnLoggaUt_Click;
            // 
            // btnAnnonser
            // 
            btnAnnonser.Location = new Point(20, 125);
            btnAnnonser.Name = "btnAnnonser";
            btnAnnonser.Size = new Size(130, 40);
            btnAnnonser.TabIndex = 3;
            btnAnnonser.Text = "Annonser";
            btnAnnonser.UseVisualStyleBackColor = true;
            btnAnnonser.Click += btnAnnonser_Click;
            // 
            // btnKurser
            // 
            btnKurser.Location = new Point(20, 70);
            btnKurser.Name = "btnKurser";
            btnKurser.Size = new Size(130, 40);
            btnKurser.TabIndex = 2;
            btnKurser.Text = "Kurser";
            btnKurser.UseVisualStyleBackColor = true;
            btnKurser.Click += btnKurser_Click;
            // 
            // lblVälkommen
            // 
            lblVälkommen.AutoSize = true;
            lblVälkommen.Location = new Point(10, 15);
            lblVälkommen.Name = "lblVälkommen";
            lblVälkommen.Size = new Size(70, 15);
            lblVälkommen.TabIndex = 1;
            lblVälkommen.Text = "Välkommen";
            // 
            // panelKurser
            // 
            panelKurser.Controls.Add(btnÄndraKurs);
            panelKurser.Controls.Add(btnTaBortKurs);
            panelKurser.Controls.Add(btnLäggTillKurs);
            panelKurser.Controls.Add(txtNamn);
            panelKurser.Controls.Add(lblNamn);
            panelKurser.Controls.Add(txtKod);
            panelKurser.Controls.Add(lblKod);
            panelKurser.Controls.Add(dataGridViewKurser);
            panelKurser.Location = new Point(195, 12);
            panelKurser.Name = "panelKurser";
            panelKurser.Size = new Size(680, 420);
            panelKurser.TabIndex = 1;
            // 
            // btnÄndraKurs
            // 
            btnÄndraKurs.Location = new Point(145, 365);
            btnÄndraKurs.Name = "btnÄndraKurs";
            btnÄndraKurs.Size = new Size(120, 35);
            btnÄndraKurs.TabIndex = 7;
            btnÄndraKurs.Text = "Spara ändring";
            btnÄndraKurs.UseVisualStyleBackColor = true;
            btnÄndraKurs.Click += btnÄndraKurs_Click;
            // 
            // btnTaBortKurs
            // 
            btnTaBortKurs.Location = new Point(275, 365);
            btnTaBortKurs.Name = "btnTaBortKurs";
            btnTaBortKurs.Size = new Size(120, 35);
            btnTaBortKurs.TabIndex = 6;
            btnTaBortKurs.Text = "Ta bort";
            btnTaBortKurs.UseVisualStyleBackColor = true;
            btnTaBortKurs.Click += btnTaBortKurs_Click;
            // 
            // btnLäggTillKurs
            // 
            btnLäggTillKurs.Location = new Point(15, 365);
            btnLäggTillKurs.Name = "btnLäggTillKurs";
            btnLäggTillKurs.Size = new Size(120, 35);
            btnLäggTillKurs.TabIndex = 5;
            btnLäggTillKurs.Text = "Lägg till";
            btnLäggTillKurs.UseVisualStyleBackColor = true;
            btnLäggTillKurs.Click += btnLäggTillKurs_Click;
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(100, 317);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(200, 23);
            txtNamn.TabIndex = 4;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(15, 320);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(61, 15);
            lblNamn.TabIndex = 3;
            lblNamn.Text = "Kursnamn";
            // 
            // txtKod
            // 
            txtKod.Location = new Point(100, 282);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(200, 23);
            txtKod.TabIndex = 2;
            // 
            // lblKod
            // 
            lblKod.AutoSize = true;
            lblKod.Location = new Point(15, 285);
            lblKod.Name = "lblKod";
            lblKod.Size = new Size(50, 15);
            lblKod.TabIndex = 1;
            lblKod.Text = "Kurskod";
            // 
            // dataGridViewKurser
            // 
            dataGridViewKurser.AllowUserToAddRows = false;
            dataGridViewKurser.AllowUserToDeleteRows = false;
            dataGridViewKurser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKurser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKurser.Columns.AddRange(new DataGridViewColumn[] { colKursKod, colKursNamn });
            dataGridViewKurser.Location = new Point(15, 15);
            dataGridViewKurser.MultiSelect = false;
            dataGridViewKurser.Name = "dataGridViewKurser";
            dataGridViewKurser.ReadOnly = true;
            dataGridViewKurser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKurser.Size = new Size(650, 250);
            dataGridViewKurser.TabIndex = 0;
            dataGridViewKurser.SelectionChanged += dataGridViewKurser_SelectionChanged;
            // 
            // colKursKod
            // 
            colKursKod.HeaderText = "Kod";
            colKursKod.Name = "colKursKod";
            colKursKod.ReadOnly = true;
            // 
            // colKursNamn
            // 
            colKursNamn.HeaderText = "Namn";
            colKursNamn.Name = "colKursNamn";
            colKursNamn.ReadOnly = true;
            // 
            // panelAnnonser
            // 
            panelAnnonser.BorderStyle = BorderStyle.FixedSingle;
            panelAnnonser.Controls.Add(btnTaBortAnnons);
            panelAnnonser.Controls.Add(dataGridViewAnnonser);
            panelAnnonser.Location = new Point(195, 12);
            panelAnnonser.Name = "panelAnnonser";
            panelAnnonser.Size = new Size(680, 420);
            panelAnnonser.TabIndex = 2;
            // 
            // btnTaBortAnnons
            // 
            btnTaBortAnnons.Location = new Point(15, 365);
            btnTaBortAnnons.Name = "btnTaBortAnnons";
            btnTaBortAnnons.Size = new Size(150, 35);
            btnTaBortAnnons.TabIndex = 1;
            btnTaBortAnnons.Text = "Ta bort annons";
            btnTaBortAnnons.UseVisualStyleBackColor = true;
            btnTaBortAnnons.Click += btnTaBortAnnons_Click;
            // 
            // dataGridViewAnnonser
            // 
            dataGridViewAnnonser.AllowUserToAddRows = false;
            dataGridViewAnnonser.AllowUserToDeleteRows = false;
            dataGridViewAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnnonser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnnonser.Columns.AddRange(new DataGridViewColumn[] { colAnnonsId, colAnnonsTitel, colAnnonsTyp, colAnnonsKurs, colAnnonsSäljare, colAnnonsPris, colAnnonsStatus });
            dataGridViewAnnonser.Location = new Point(15, 15);
            dataGridViewAnnonser.MultiSelect = false;
            dataGridViewAnnonser.Name = "dataGridViewAnnonser";
            dataGridViewAnnonser.ReadOnly = true;
            dataGridViewAnnonser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnnonser.Size = new Size(650, 330);
            dataGridViewAnnonser.TabIndex = 0;
            // 
            // colAnnonsId
            // 
            colAnnonsId.HeaderText = "ID";
            colAnnonsId.Name = "colAnnonsId";
            colAnnonsId.ReadOnly = true;
            // 
            // colAnnonsTitel
            // 
            colAnnonsTitel.HeaderText = "Titel";
            colAnnonsTitel.Name = "colAnnonsTitel";
            colAnnonsTitel.ReadOnly = true;
            // 
            // colAnnonsTyp
            // 
            colAnnonsTyp.HeaderText = "Typ";
            colAnnonsTyp.Name = "colAnnonsTyp";
            colAnnonsTyp.ReadOnly = true;
            // 
            // colAnnonsKurs
            // 
            colAnnonsKurs.HeaderText = "Kurs";
            colAnnonsKurs.Name = "colAnnonsKurs";
            colAnnonsKurs.ReadOnly = true;
            // 
            // colAnnonsSäljare
            // 
            colAnnonsSäljare.HeaderText = "Säljare";
            colAnnonsSäljare.Name = "colAnnonsSäljare";
            colAnnonsSäljare.ReadOnly = true;
            // 
            // colAnnonsPris
            // 
            colAnnonsPris.HeaderText = "Pris";
            colAnnonsPris.Name = "colAnnonsPris";
            colAnnonsPris.ReadOnly = true;
            // 
            // colAnnonsStatus
            // 
            colAnnonsStatus.HeaderText = "Status";
            colAnnonsStatus.Name = "colAnnonsStatus";
            colAnnonsStatus.ReadOnly = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 441);
            Controls.Add(panelAnnonser);
            Controls.Add(panelKurser);
            Controls.Add(panelMeny);
            Name = "AdminForm";
            Text = "Adminsida";
            panelMeny.ResumeLayout(false);
            panelMeny.PerformLayout();
            panelKurser.ResumeLayout(false);
            panelKurser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKurser).EndInit();
            panelAnnonser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnnonser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMeny;
        private Label lblVälkommen;
        private Button btnKurser;
        private Button btnLoggaUt;
        private Button btnAnnonser;
        private Panel panelKurser;
        private DataGridView dataGridViewKurser;
        private Label lblNamn;
        private TextBox txtKod;
        private Label lblKod;
        private Button btnÄndraKurs;
        private Button btnTaBortKurs;
        private Button btnLäggTillKurs;
        private TextBox txtNamn;
        private DataGridViewTextBoxColumn colKursKod;
        private DataGridViewTextBoxColumn colKursNamn;
        private Panel panelAnnonser;
        private DataGridView dataGridViewAnnonser;
        private DataGridViewTextBoxColumn colAnnonsId;
        private DataGridViewTextBoxColumn colAnnonsTitel;
        private DataGridViewTextBoxColumn colAnnonsTyp;
        private DataGridViewTextBoxColumn colAnnonsKurs;
        private DataGridViewTextBoxColumn colAnnonsSäljare;
        private DataGridViewTextBoxColumn colAnnonsPris;
        private DataGridViewTextBoxColumn colAnnonsStatus;
        private Button btnTaBortAnnons;
    }
}