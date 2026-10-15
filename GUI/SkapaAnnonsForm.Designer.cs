namespace GUI
{
    partial class SkapaAnnonsForm
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
            cmbAnnonsTyp = new ComboBox();
            panelAnnonsGemensammaUppgifter = new Panel();
            txtPrisInput = new TextBox();
            cmbAnnonsSkick = new ComboBox();
            cmbKurs = new ComboBox();
            lblAnnonsSkick = new Label();
            label1 = new Label();
            lblAnnonsKurs = new Label();
            txtTitelInput = new TextBox();
            lblAnnonsTitel = new Label();
            lblVäljAnnonsTyp = new Label();
            panelKursbok = new Panel();
            lblUpplaga = new Label();
            lblISBN = new Label();
            txtFörfattareInput = new TextBox();
            lblFörfattare = new Label();
            lblKursbok = new Label();
            txtUpplagaInput = new TextBox();
            txtISBNInput = new TextBox();
            btnSkapaAnnons = new Button();
            btnAvbryt = new Button();
            panelKompendium = new Panel();
            txtUtgivningsår = new TextBox();
            lblUtgivningsår = new Label();
            txtAntalSidor = new TextBox();
            lblAntalSidor = new Label();
            lblKompendium = new Label();
            panelDigitalResurs = new Panel();
            txtLeveranssätt = new TextBox();
            txtFilformatInput = new TextBox();
            lblLeveranssätt = new Label();
            lblFilformat = new Label();
            lblDigitalResurs = new Label();
            lblSkapaAnnonsRubrik = new Label();
            panelAnnonsGemensammaUppgifter.SuspendLayout();
            panelKursbok.SuspendLayout();
            panelKompendium.SuspendLayout();
            panelDigitalResurs.SuspendLayout();
            SuspendLayout();
            // 
            // cmbAnnonsTyp
            // 
            cmbAnnonsTyp.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnnonsTyp.FormattingEnabled = true;
            cmbAnnonsTyp.Items.AddRange(new object[] { "Kursbok", "Kompendium", "Digital resurs" });
            cmbAnnonsTyp.Location = new Point(15, 40);
            cmbAnnonsTyp.Name = "cmbAnnonsTyp";
            cmbAnnonsTyp.Size = new Size(151, 28);
            cmbAnnonsTyp.TabIndex = 0;
            cmbAnnonsTyp.SelectedIndexChanged += cmbAnnonsTyp_SelectedIndexChanged;
            // 
            // panelAnnonsGemensammaUppgifter
            // 
            panelAnnonsGemensammaUppgifter.Controls.Add(txtPrisInput);
            panelAnnonsGemensammaUppgifter.Controls.Add(cmbAnnonsSkick);
            panelAnnonsGemensammaUppgifter.Controls.Add(cmbKurs);
            panelAnnonsGemensammaUppgifter.Controls.Add(lblAnnonsSkick);
            panelAnnonsGemensammaUppgifter.Controls.Add(label1);
            panelAnnonsGemensammaUppgifter.Controls.Add(lblAnnonsKurs);
            panelAnnonsGemensammaUppgifter.Controls.Add(txtTitelInput);
            panelAnnonsGemensammaUppgifter.Controls.Add(lblAnnonsTitel);
            panelAnnonsGemensammaUppgifter.Controls.Add(lblVäljAnnonsTyp);
            panelAnnonsGemensammaUppgifter.Controls.Add(cmbAnnonsTyp);
            panelAnnonsGemensammaUppgifter.Location = new Point(8, 52);
            panelAnnonsGemensammaUppgifter.Name = "panelAnnonsGemensammaUppgifter";
            panelAnnonsGemensammaUppgifter.Size = new Size(780, 224);
            panelAnnonsGemensammaUppgifter.TabIndex = 1;
            // 
            // txtPrisInput
            // 
            txtPrisInput.Location = new Point(384, 106);
            txtPrisInput.Name = "txtPrisInput";
            txtPrisInput.Size = new Size(151, 27);
            txtPrisInput.TabIndex = 15;
            // 
            // cmbAnnonsSkick
            // 
            cmbAnnonsSkick.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnnonsSkick.FormattingEnabled = true;
            cmbAnnonsSkick.Location = new Point(384, 167);
            cmbAnnonsSkick.Name = "cmbAnnonsSkick";
            cmbAnnonsSkick.Size = new Size(151, 28);
            cmbAnnonsSkick.TabIndex = 14;
            // 
            // cmbKurs
            // 
            cmbKurs.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKurs.FormattingEnabled = true;
            cmbKurs.Items.AddRange(new object[] { "Kursbok", "Kompendium", "Digital resurs" });
            cmbKurs.Location = new Point(15, 167);
            cmbKurs.Name = "cmbKurs";
            cmbKurs.Size = new Size(287, 28);
            cmbKurs.TabIndex = 13;
            // 
            // lblAnnonsSkick
            // 
            lblAnnonsSkick.AutoSize = true;
            lblAnnonsSkick.Location = new Point(384, 144);
            lblAnnonsSkick.Name = "lblAnnonsSkick";
            lblAnnonsSkick.Size = new Size(42, 20);
            lblAnnonsSkick.TabIndex = 12;
            lblAnnonsSkick.Text = "Skick";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 83);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 11;
            label1.Text = "Pris";
            // 
            // lblAnnonsKurs
            // 
            lblAnnonsKurs.AutoSize = true;
            lblAnnonsKurs.Location = new Point(15, 144);
            lblAnnonsKurs.Name = "lblAnnonsKurs";
            lblAnnonsKurs.Size = new Size(37, 20);
            lblAnnonsKurs.TabIndex = 10;
            lblAnnonsKurs.Text = "Kurs";
            // 
            // txtTitelInput
            // 
            txtTitelInput.Location = new Point(14, 106);
            txtTitelInput.Name = "txtTitelInput";
            txtTitelInput.Size = new Size(288, 27);
            txtTitelInput.TabIndex = 8;
            // 
            // lblAnnonsTitel
            // 
            lblAnnonsTitel.AutoSize = true;
            lblAnnonsTitel.Location = new Point(14, 83);
            lblAnnonsTitel.Name = "lblAnnonsTitel";
            lblAnnonsTitel.Size = new Size(38, 20);
            lblAnnonsTitel.TabIndex = 8;
            lblAnnonsTitel.Text = "Titel";
            // 
            // lblVäljAnnonsTyp
            // 
            lblVäljAnnonsTyp.AutoSize = true;
            lblVäljAnnonsTyp.Location = new Point(15, 17);
            lblVäljAnnonsTyp.Name = "lblVäljAnnonsTyp";
            lblVäljAnnonsTyp.Size = new Size(112, 20);
            lblVäljAnnonsTyp.TabIndex = 8;
            lblVäljAnnonsTyp.Text = "Välj annonstyp: ";
            // 
            // panelKursbok
            // 
            panelKursbok.Controls.Add(lblUpplaga);
            panelKursbok.Controls.Add(lblISBN);
            panelKursbok.Controls.Add(txtFörfattareInput);
            panelKursbok.Controls.Add(lblFörfattare);
            panelKursbok.Controls.Add(lblKursbok);
            panelKursbok.Controls.Add(txtUpplagaInput);
            panelKursbok.Controls.Add(txtISBNInput);
            panelKursbok.Location = new Point(8, 282);
            panelKursbok.Name = "panelKursbok";
            panelKursbok.Size = new Size(780, 119);
            panelKursbok.TabIndex = 2;
            // 
            // lblUpplaga
            // 
            lblUpplaga.AutoSize = true;
            lblUpplaga.Location = new Point(543, 55);
            lblUpplaga.Name = "lblUpplaga";
            lblUpplaga.Size = new Size(66, 20);
            lblUpplaga.TabIndex = 7;
            lblUpplaga.Text = "Upplaga";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(305, 55);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 6;
            lblISBN.Text = "ISBN";
            // 
            // txtFörfattareInput
            // 
            txtFörfattareInput.Location = new Point(9, 78);
            txtFörfattareInput.Name = "txtFörfattareInput";
            txtFörfattareInput.Size = new Size(239, 27);
            txtFörfattareInput.TabIndex = 5;
            // 
            // lblFörfattare
            // 
            lblFörfattare.AutoSize = true;
            lblFörfattare.Location = new Point(9, 49);
            lblFörfattare.Name = "lblFörfattare";
            lblFörfattare.Size = new Size(74, 20);
            lblFörfattare.TabIndex = 4;
            lblFörfattare.Text = "Författare";
            // 
            // lblKursbok
            // 
            lblKursbok.AutoSize = true;
            lblKursbok.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKursbok.Location = new Point(3, 11);
            lblKursbok.Name = "lblKursbok";
            lblKursbok.Size = new Size(80, 25);
            lblKursbok.TabIndex = 3;
            lblKursbok.Text = "Kursbok";
            // 
            // txtUpplagaInput
            // 
            txtUpplagaInput.Location = new Point(543, 78);
            txtUpplagaInput.Name = "txtUpplagaInput";
            txtUpplagaInput.Size = new Size(125, 27);
            txtUpplagaInput.TabIndex = 2;
            // 
            // txtISBNInput
            // 
            txtISBNInput.Location = new Point(305, 78);
            txtISBNInput.Name = "txtISBNInput";
            txtISBNInput.Size = new Size(191, 27);
            txtISBNInput.TabIndex = 1;
            // 
            // btnSkapaAnnons
            // 
            btnSkapaAnnons.Location = new Point(610, 412);
            btnSkapaAnnons.Name = "btnSkapaAnnons";
            btnSkapaAnnons.Size = new Size(178, 31);
            btnSkapaAnnons.TabIndex = 16;
            btnSkapaAnnons.Text = "Skapa annons";
            btnSkapaAnnons.UseVisualStyleBackColor = true;
            btnSkapaAnnons.Click += btnSkapaAnnons_Click;
            // 
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(410, 412);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(178, 31);
            btnAvbryt.TabIndex = 17;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // panelKompendium
            // 
            panelKompendium.Controls.Add(txtUtgivningsår);
            panelKompendium.Controls.Add(lblUtgivningsår);
            panelKompendium.Controls.Add(txtAntalSidor);
            panelKompendium.Controls.Add(lblAntalSidor);
            panelKompendium.Controls.Add(lblKompendium);
            panelKompendium.Location = new Point(10, 282);
            panelKompendium.Name = "panelKompendium";
            panelKompendium.Size = new Size(780, 116);
            panelKompendium.TabIndex = 18;
            // 
            // txtUtgivningsår
            // 
            txtUtgivningsår.Location = new Point(305, 59);
            txtUtgivningsår.Name = "txtUtgivningsår";
            txtUtgivningsår.Size = new Size(151, 27);
            txtUtgivningsår.TabIndex = 16;
            // 
            // lblUtgivningsår
            // 
            lblUtgivningsår.AutoSize = true;
            lblUtgivningsår.Location = new Point(305, 36);
            lblUtgivningsår.Name = "lblUtgivningsår";
            lblUtgivningsår.Size = new Size(92, 20);
            lblUtgivningsår.TabIndex = 16;
            lblUtgivningsår.Text = "Utgivningsår";
            // 
            // txtAntalSidor
            // 
            txtAntalSidor.Location = new Point(15, 59);
            txtAntalSidor.Name = "txtAntalSidor";
            txtAntalSidor.Size = new Size(151, 27);
            txtAntalSidor.TabIndex = 16;
            // 
            // lblAntalSidor
            // 
            lblAntalSidor.AutoSize = true;
            lblAntalSidor.Location = new Point(15, 36);
            lblAntalSidor.Name = "lblAntalSidor";
            lblAntalSidor.Size = new Size(81, 20);
            lblAntalSidor.TabIndex = 16;
            lblAntalSidor.Text = "Antal sidor";
            // 
            // lblKompendium
            // 
            lblKompendium.AutoSize = true;
            lblKompendium.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKompendium.Location = new Point(4, 0);
            lblKompendium.Name = "lblKompendium";
            lblKompendium.Size = new Size(125, 25);
            lblKompendium.TabIndex = 16;
            lblKompendium.Text = "Kompendium";
            // 
            // panelDigitalResurs
            // 
            panelDigitalResurs.Controls.Add(txtLeveranssätt);
            panelDigitalResurs.Controls.Add(txtFilformatInput);
            panelDigitalResurs.Controls.Add(lblLeveranssätt);
            panelDigitalResurs.Controls.Add(lblFilformat);
            panelDigitalResurs.Controls.Add(lblDigitalResurs);
            panelDigitalResurs.Location = new Point(11, 285);
            panelDigitalResurs.Name = "panelDigitalResurs";
            panelDigitalResurs.Size = new Size(779, 121);
            panelDigitalResurs.TabIndex = 19;
            // 
            // txtLeveranssätt
            // 
            txtLeveranssätt.Location = new Point(280, 59);
            txtLeveranssätt.Name = "txtLeveranssätt";
            txtLeveranssätt.Size = new Size(268, 27);
            txtLeveranssätt.TabIndex = 17;
            // 
            // txtFilformatInput
            // 
            txtFilformatInput.Location = new Point(14, 59);
            txtFilformatInput.Name = "txtFilformatInput";
            txtFilformatInput.Size = new Size(178, 27);
            txtFilformatInput.TabIndex = 16;
            // 
            // lblLeveranssätt
            // 
            lblLeveranssätt.AutoSize = true;
            lblLeveranssätt.Location = new Point(279, 35);
            lblLeveranssätt.Name = "lblLeveranssätt";
            lblLeveranssätt.Size = new Size(90, 20);
            lblLeveranssätt.TabIndex = 16;
            lblLeveranssätt.Text = "Leveranssätt";
            // 
            // lblFilformat
            // 
            lblFilformat.AutoSize = true;
            lblFilformat.Location = new Point(12, 36);
            lblFilformat.Name = "lblFilformat";
            lblFilformat.Size = new Size(69, 20);
            lblFilformat.TabIndex = 16;
            lblFilformat.Text = "Filformat";
            // 
            // lblDigitalResurs
            // 
            lblDigitalResurs.AutoSize = true;
            lblDigitalResurs.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDigitalResurs.Location = new Point(6, 0);
            lblDigitalResurs.Name = "lblDigitalResurs";
            lblDigitalResurs.Size = new Size(123, 25);
            lblDigitalResurs.TabIndex = 16;
            lblDigitalResurs.Text = "Digital resurs";
            // 
            // lblSkapaAnnonsRubrik
            // 
            lblSkapaAnnonsRubrik.AutoSize = true;
            lblSkapaAnnonsRubrik.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSkapaAnnonsRubrik.Location = new Point(291, 9);
            lblSkapaAnnonsRubrik.Name = "lblSkapaAnnonsRubrik";
            lblSkapaAnnonsRubrik.Size = new Size(158, 31);
            lblSkapaAnnonsRubrik.TabIndex = 16;
            lblSkapaAnnonsRubrik.Text = "Skapa annons";
            // 
            // SkapaAnnons
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSkapaAnnonsRubrik);
            Controls.Add(panelDigitalResurs);
            Controls.Add(panelKompendium);
            Controls.Add(btnAvbryt);
            Controls.Add(btnSkapaAnnons);
            Controls.Add(panelKursbok);
            Controls.Add(panelAnnonsGemensammaUppgifter);
            Name = "SkapaAnnons";
            Text = "SkapaAnnons";
            panelAnnonsGemensammaUppgifter.ResumeLayout(false);
            panelAnnonsGemensammaUppgifter.PerformLayout();
            panelKursbok.ResumeLayout(false);
            panelKursbok.PerformLayout();
            panelKompendium.ResumeLayout(false);
            panelKompendium.PerformLayout();
            panelDigitalResurs.ResumeLayout(false);
            panelDigitalResurs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAnnonsTyp;
        private Panel panelAnnonsGemensammaUppgifter;
        private Panel panelKursbok;
        private Label lblKursbok;
        private TextBox txtUpplagaInput;
        private TextBox txtISBNInput;
        private Label lblUpplaga;
        private Label lblISBN;
        private TextBox txtFörfattareInput;
        private Label lblFörfattare;
        private Label lblVäljAnnonsTyp;
        private Label lblAnnonsKurs;
        private TextBox txtTitelInput;
        private Label lblAnnonsTitel;
        private Label lblAnnonsSkick;
        private Label label1;
        private TextBox txtPrisInput;
        private ComboBox cmbAnnonsSkick;
        private ComboBox cmbKurs;
        private Button btnSkapaAnnons;
        private Button btnAvbryt;
        private Panel panelKompendium;
        private TextBox txtUtgivningsår;
        private Label lblUtgivningsår;
        private TextBox txtAntalSidor;
        private Label lblAntalSidor;
        private Label lblKompendium;
        private Panel panelDigitalResurs;
        private TextBox txtLeveranssätt;
        private TextBox txtFilformatInput;
        private Label lblLeveranssätt;
        private Label lblFilformat;
        private Label lblDigitalResurs;
        private Label lblSkapaAnnonsRubrik;
    }
}