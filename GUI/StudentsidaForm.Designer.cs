namespace GUI
{
    partial class StudentsidaForm
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
            btnMinaAnnonser = new Button();
            btnSkapaAnnons = new Button();
            btnLedigaAnnonser = new Button();
            btnVisaStartSida = new Button();
            lblMeny = new Label();
            panelMinaAnnonser = new Panel();
            btnBekräftaKöp = new Button();
            dataGridViewReserveradeAnnonser = new DataGridView();
            colAnnonsID = new DataGridViewTextBoxColumn();
            colAnnonsTitel = new DataGridViewTextBoxColumn();
            colAnnonsPris = new DataGridViewTextBoxColumn();
            colKöpare = new DataGridViewTextBoxColumn();
            colAffärStatus = new DataGridViewTextBoxColumn();
            colReservationsdatum = new DataGridViewTextBoxColumn();
            lblAnnonser = new Label();
            lblSåldaAnnonser = new Label();
            dataGridViewMinaAnnonser = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitel = new DataGridViewTextBoxColumn();
            colKurs = new DataGridViewTextBoxColumn();
            colPris = new DataGridViewTextBoxColumn();
            colSkick = new DataGridViewTextBoxColumn();
            colTyp = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panelStartsida = new Panel();
            lblVälkommen = new Label();
            lblBookSwapRubrik = new Label();
            panelMeny.SuspendLayout();
            panelMinaAnnonser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserveradeAnnonser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMinaAnnonser).BeginInit();
            panelStartsida.SuspendLayout();
            SuspendLayout();
            // 
            // panelMeny
            // 
            panelMeny.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMeny.BackColor = SystemColors.ControlLight;
            panelMeny.Controls.Add(btnLoggaUt);
            panelMeny.Controls.Add(btnMinaAnnonser);
            panelMeny.Controls.Add(btnSkapaAnnons);
            panelMeny.Controls.Add(btnLedigaAnnonser);
            panelMeny.Controls.Add(btnVisaStartSida);
            panelMeny.Controls.Add(lblMeny);
            panelMeny.Location = new Point(13, 18);
            panelMeny.Name = "panelMeny";
            panelMeny.Size = new Size(180, 590);
            panelMeny.TabIndex = 0;
            // 
            // btnLoggaUt
            // 
            btnLoggaUt.Location = new Point(29, 524);
            btnLoggaUt.Name = "btnLoggaUt";
            btnLoggaUt.Size = new Size(126, 42);
            btnLoggaUt.TabIndex = 5;
            btnLoggaUt.Text = "Logga ut";
            btnLoggaUt.UseVisualStyleBackColor = true;
            btnLoggaUt.Click += btnLoggaUt_Click;
            // 
            // btnMinaAnnonser
            // 
            btnMinaAnnonser.Location = new Point(29, 309);
            btnMinaAnnonser.Name = "btnMinaAnnonser";
            btnMinaAnnonser.Size = new Size(126, 42);
            btnMinaAnnonser.TabIndex = 4;
            btnMinaAnnonser.Text = "Mina annonser";
            btnMinaAnnonser.UseVisualStyleBackColor = true;
            btnMinaAnnonser.Click += btnMinaAnnonser_Click;
            // 
            // btnSkapaAnnons
            // 
            btnSkapaAnnons.Location = new Point(29, 225);
            btnSkapaAnnons.Name = "btnSkapaAnnons";
            btnSkapaAnnons.Size = new Size(126, 42);
            btnSkapaAnnons.TabIndex = 3;
            btnSkapaAnnons.Text = "Skapa annons";
            btnSkapaAnnons.UseVisualStyleBackColor = true;
            btnSkapaAnnons.Click += btnSkapaAnnons_Click;
            // 
            // btnLedigaAnnonser
            // 
            btnLedigaAnnonser.Location = new Point(29, 144);
            btnLedigaAnnonser.Name = "btnLedigaAnnonser";
            btnLedigaAnnonser.Size = new Size(126, 42);
            btnLedigaAnnonser.TabIndex = 2;
            btnLedigaAnnonser.Text = "Lediga annonser";
            btnLedigaAnnonser.UseVisualStyleBackColor = true;
            btnLedigaAnnonser.Click += btnLedigaAnnonser_Click;
            // 
            // btnVisaStartSida
            // 
            btnVisaStartSida.BackColor = SystemColors.ButtonHighlight;
            btnVisaStartSida.Location = new Point(29, 66);
            btnVisaStartSida.Name = "btnVisaStartSida";
            btnVisaStartSida.Size = new Size(126, 42);
            btnVisaStartSida.TabIndex = 1;
            btnVisaStartSida.Text = "Startsida";
            btnVisaStartSida.UseVisualStyleBackColor = false;
            btnVisaStartSida.Click += btnVisaStartSida_Click;
            // 
            // lblMeny
            // 
            lblMeny.AutoSize = true;
            lblMeny.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeny.Location = new Point(57, 11);
            lblMeny.Name = "lblMeny";
            lblMeny.Size = new Size(72, 31);
            lblMeny.TabIndex = 0;
            lblMeny.Text = "Meny";
            // 
            // panelMinaAnnonser
            // 
            panelMinaAnnonser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMinaAnnonser.Controls.Add(btnBekräftaKöp);
            panelMinaAnnonser.Controls.Add(dataGridViewReserveradeAnnonser);
            panelMinaAnnonser.Controls.Add(lblAnnonser);
            panelMinaAnnonser.Controls.Add(lblSåldaAnnonser);
            panelMinaAnnonser.Controls.Add(dataGridViewMinaAnnonser);
            panelMinaAnnonser.Location = new Point(199, 23);
            panelMinaAnnonser.Name = "panelMinaAnnonser";
            panelMinaAnnonser.Size = new Size(813, 580);
            panelMinaAnnonser.TabIndex = 11;
            // 
            // btnBekräftaKöp
            // 
            btnBekräftaKöp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBekräftaKöp.Location = new Point(661, 536);
            btnBekräftaKöp.Name = "btnBekräftaKöp";
            btnBekräftaKöp.Size = new Size(141, 41);
            btnBekräftaKöp.TabIndex = 10;
            btnBekräftaKöp.Text = "Bekräfta köp";
            btnBekräftaKöp.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReserveradeAnnonser
            // 
            dataGridViewReserveradeAnnonser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewReserveradeAnnonser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReserveradeAnnonser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReserveradeAnnonser.Columns.AddRange(new DataGridViewColumn[] { colAnnonsID, colAnnonsTitel, colAnnonsPris, colKöpare, colAffärStatus, colReservationsdatum });
            dataGridViewReserveradeAnnonser.Location = new Point(3, 353);
            dataGridViewReserveradeAnnonser.MultiSelect = false;
            dataGridViewReserveradeAnnonser.Name = "dataGridViewReserveradeAnnonser";
            dataGridViewReserveradeAnnonser.ReadOnly = true;
            dataGridViewReserveradeAnnonser.RowHeadersWidth = 51;
            dataGridViewReserveradeAnnonser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReserveradeAnnonser.Size = new Size(796, 180);
            dataGridViewReserveradeAnnonser.TabIndex = 9;
            // 
            // colAnnonsID
            // 
            colAnnonsID.HeaderText = "ID";
            colAnnonsID.MinimumWidth = 6;
            colAnnonsID.Name = "colAnnonsID";
            colAnnonsID.ReadOnly = true;
            colAnnonsID.Visible = false;
            colAnnonsID.Width = 53;
            // 
            // colAnnonsTitel
            // 
            colAnnonsTitel.HeaderText = "Titel";
            colAnnonsTitel.MinimumWidth = 6;
            colAnnonsTitel.Name = "colAnnonsTitel";
            colAnnonsTitel.ReadOnly = true;
            colAnnonsTitel.Width = 67;
            // 
            // colAnnonsPris
            // 
            colAnnonsPris.HeaderText = "Pris";
            colAnnonsPris.MinimumWidth = 6;
            colAnnonsPris.Name = "colAnnonsPris";
            colAnnonsPris.ReadOnly = true;
            colAnnonsPris.Width = 61;
            // 
            // colKöpare
            // 
            colKöpare.HeaderText = "Köpare";
            colKöpare.MinimumWidth = 6;
            colKöpare.Name = "colKöpare";
            colKöpare.ReadOnly = true;
            colKöpare.Width = 86;
            // 
            // colAffärStatus
            // 
            colAffärStatus.HeaderText = "AffärStatus";
            colAffärStatus.MinimumWidth = 6;
            colAffärStatus.Name = "colAffärStatus";
            colAffärStatus.ReadOnly = true;
            colAffärStatus.Width = 111;
            // 
            // colReservationsdatum
            // 
            colReservationsdatum.HeaderText = "Reservationsdatum";
            colReservationsdatum.MinimumWidth = 6;
            colReservationsdatum.Name = "colReservationsdatum";
            colReservationsdatum.ReadOnly = true;
            colReservationsdatum.Width = 164;
            // 
            // lblAnnonser
            // 
            lblAnnonser.AutoSize = true;
            lblAnnonser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnnonser.Location = new Point(14, 38);
            lblAnnonser.Name = "lblAnnonser";
            lblAnnonser.Size = new Size(154, 28);
            lblAnnonser.TabIndex = 8;
            lblAnnonser.Text = "Mina annonser ";
            // 
            // lblSåldaAnnonser
            // 
            lblSåldaAnnonser.AutoSize = true;
            lblSåldaAnnonser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSåldaAnnonser.Location = new Point(14, 318);
            lblSåldaAnnonser.Name = "lblSåldaAnnonser";
            lblSåldaAnnonser.Size = new Size(542, 28);
            lblSåldaAnnonser.TabIndex = 7;
            lblSåldaAnnonser.Text = "Sålda annonser - Bekräfta köpet när affären är genomförd";
            // 
            // dataGridViewMinaAnnonser
            // 
            dataGridViewMinaAnnonser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMinaAnnonser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMinaAnnonser.Columns.AddRange(new DataGridViewColumn[] { colId, colTitel, colKurs, colPris, colSkick, colTyp, colStatus });
            dataGridViewMinaAnnonser.Location = new Point(1, 72);
            dataGridViewMinaAnnonser.Name = "dataGridViewMinaAnnonser";
            dataGridViewMinaAnnonser.ReadOnly = true;
            dataGridViewMinaAnnonser.RowHeadersWidth = 51;
            dataGridViewMinaAnnonser.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewMinaAnnonser.Size = new Size(801, 219);
            dataGridViewMinaAnnonser.TabIndex = 6;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colTitel
            // 
            colTitel.HeaderText = "Titel";
            colTitel.MinimumWidth = 6;
            colTitel.Name = "colTitel";
            colTitel.ReadOnly = true;
            colTitel.Width = 125;
            // 
            // colKurs
            // 
            colKurs.HeaderText = "Kurs";
            colKurs.MinimumWidth = 6;
            colKurs.Name = "colKurs";
            colKurs.ReadOnly = true;
            colKurs.Width = 125;
            // 
            // colPris
            // 
            colPris.HeaderText = "Pris";
            colPris.MinimumWidth = 6;
            colPris.Name = "colPris";
            colPris.ReadOnly = true;
            colPris.Width = 125;
            // 
            // colSkick
            // 
            colSkick.HeaderText = "Skick";
            colSkick.MinimumWidth = 6;
            colSkick.Name = "colSkick";
            colSkick.ReadOnly = true;
            colSkick.Width = 125;
            // 
            // colTyp
            // 
            colTyp.HeaderText = "Typ";
            colTyp.MinimumWidth = 6;
            colTyp.Name = "colTyp";
            colTyp.ReadOnly = true;
            colTyp.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 125;
            // 
            // panelStartsida
            // 
            panelStartsida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelStartsida.Controls.Add(lblVälkommen);
            panelStartsida.Controls.Add(lblBookSwapRubrik);
            panelStartsida.Location = new Point(199, 23);
            panelStartsida.Name = "panelStartsida";
            panelStartsida.Size = new Size(813, 582);
            panelStartsida.TabIndex = 12;
            // 
            // lblVälkommen
            // 
            lblVälkommen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVälkommen.AutoSize = true;
            lblVälkommen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVälkommen.Location = new Point(292, 88);
            lblVälkommen.Name = "lblVälkommen";
            lblVälkommen.Size = new Size(115, 28);
            lblVälkommen.TabIndex = 6;
            lblVälkommen.Text = "Välkommen";
            // 
            // lblBookSwapRubrik
            // 
            lblBookSwapRubrik.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBookSwapRubrik.AutoSize = true;
            lblBookSwapRubrik.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookSwapRubrik.Location = new Point(340, 38);
            lblBookSwapRubrik.Name = "lblBookSwapRubrik";
            lblBookSwapRubrik.Size = new Size(124, 31);
            lblBookSwapRubrik.TabIndex = 5;
            lblBookSwapRubrik.Text = "BookSwap";
            // 
            // StudentsidaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 620);
            Controls.Add(panelStartsida);
            Controls.Add(panelMinaAnnonser);
            Controls.Add(panelMeny);
            Name = "StudentsidaForm";
            Text = "StudentFönster";
            panelMeny.ResumeLayout(false);
            panelMeny.PerformLayout();
            panelMinaAnnonser.ResumeLayout(false);
            panelMinaAnnonser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserveradeAnnonser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMinaAnnonser).EndInit();
            panelStartsida.ResumeLayout(false);
            panelStartsida.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMeny;
        private Button btnMinaAnnonser;
        private Button btnSkapaAnnons;
        private Button btnLedigaAnnonser;
        private Button btnVisaStartSida;
        private Label lblMeny;
        private Button btnLoggaUt;
        private Panel panelMinaAnnonser;
        private Button btnBekräftaKöp;
        private DataGridView dataGridViewReserveradeAnnonser;
        private DataGridViewTextBoxColumn colAnnonsID;
        private DataGridViewTextBoxColumn colAnnonsTitel;
        private DataGridViewTextBoxColumn colAnnonsPris;
        private DataGridViewTextBoxColumn colKöpare;
        private DataGridViewTextBoxColumn colAffärStatus;
        private DataGridViewTextBoxColumn colReservationsdatum;
        private Label lblAnnonser;
        private Label lblSåldaAnnonser;
        private DataGridView dataGridViewMinaAnnonser;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTitel;
        private DataGridViewTextBoxColumn colKurs;
        private DataGridViewTextBoxColumn colPris;
        private DataGridViewTextBoxColumn colSkick;
        private DataGridViewTextBoxColumn colTyp;
        private DataGridViewTextBoxColumn colStatus;
        private Panel panelStartsida;
        private Label lblVälkommen;
        private Label lblBookSwapRubrik;
    }
}