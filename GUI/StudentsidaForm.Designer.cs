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
            btnMinaAnnonser = new Button();
            btnSkapaAnnons = new Button();
            btnLedigaAnnonser = new Button();
            btnVisaStartSida = new Button();
            lblMeny = new Label();
            panelMinaAnnonser = new Panel();
            dataGridViewMinaAnnonser = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitel = new DataGridViewTextBoxColumn();
            colKurs = new DataGridViewTextBoxColumn();
            colPris = new DataGridViewTextBoxColumn();
            colSkick = new DataGridViewTextBoxColumn();
            colTyp = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            lblMinaAnnonserRubrik = new Label();
            panelStartsida = new Panel();
            lblVälkommen = new Label();
            lblBookSwapRubrik = new Label();
            panelMeny.SuspendLayout();
            panelMinaAnnonser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMinaAnnonser).BeginInit();
            panelStartsida.SuspendLayout();
            SuspendLayout();
            // 
            // panelMeny
            // 
            panelMeny.BackColor = SystemColors.ControlLight;
            panelMeny.Controls.Add(btnMinaAnnonser);
            panelMeny.Controls.Add(btnSkapaAnnons);
            panelMeny.Controls.Add(btnLedigaAnnonser);
            panelMeny.Controls.Add(btnVisaStartSida);
            panelMeny.Controls.Add(lblMeny);
            panelMeny.Location = new Point(13, 18);
            panelMeny.Name = "panelMeny";
            panelMeny.Size = new Size(176, 420);
            panelMeny.TabIndex = 0;
            // 
            // btnMinaAnnonser
            // 
            btnMinaAnnonser.Location = new Point(22, 247);
            btnMinaAnnonser.Name = "btnMinaAnnonser";
            btnMinaAnnonser.Size = new Size(126, 42);
            btnMinaAnnonser.TabIndex = 4;
            btnMinaAnnonser.Text = "Mina annonser";
            btnMinaAnnonser.UseVisualStyleBackColor = true;
            btnMinaAnnonser.Click += btnMinaAnnonser_Click;
            // 
            // btnSkapaAnnons
            // 
            btnSkapaAnnons.Location = new Point(22, 185);
            btnSkapaAnnons.Name = "btnSkapaAnnons";
            btnSkapaAnnons.Size = new Size(126, 42);
            btnSkapaAnnons.TabIndex = 3;
            btnSkapaAnnons.Text = "Skapa annons";
            btnSkapaAnnons.UseVisualStyleBackColor = true;
            btnSkapaAnnons.Click += btnSkapaAnnons_Click;
            // 
            // btnLedigaAnnonser
            // 
            btnLedigaAnnonser.Location = new Point(22, 124);
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
            btnVisaStartSida.Location = new Point(22, 66);
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
            lblMeny.Location = new Point(45, 11);
            lblMeny.Name = "lblMeny";
            lblMeny.Size = new Size(72, 31);
            lblMeny.TabIndex = 0;
            lblMeny.Text = "Meny";
            // 
            // panelMinaAnnonser
            // 
            panelMinaAnnonser.Controls.Add(dataGridViewMinaAnnonser);
            panelMinaAnnonser.Controls.Add(lblMinaAnnonserRubrik);
            panelMinaAnnonser.Location = new Point(193, 18);
            panelMinaAnnonser.Name = "panelMinaAnnonser";
            panelMinaAnnonser.Size = new Size(592, 414);
            panelMinaAnnonser.TabIndex = 2;
            // 
            // dataGridViewMinaAnnonser
            // 
            dataGridViewMinaAnnonser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMinaAnnonser.Columns.AddRange(new DataGridViewColumn[] { colId, colTitel, colKurs, colPris, colSkick, colTyp, colStatus });
            dataGridViewMinaAnnonser.Location = new Point(3, 52);
            dataGridViewMinaAnnonser.Name = "dataGridViewMinaAnnonser";
            dataGridViewMinaAnnonser.RowHeadersWidth = 51;
            dataGridViewMinaAnnonser.Size = new Size(586, 350);
            dataGridViewMinaAnnonser.TabIndex = 6;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colTitel
            // 
            colTitel.HeaderText = "Titel";
            colTitel.MinimumWidth = 6;
            colTitel.Name = "colTitel";
            colTitel.Width = 125;
            // 
            // colKurs
            // 
            colKurs.HeaderText = "Kurs";
            colKurs.MinimumWidth = 6;
            colKurs.Name = "colKurs";
            colKurs.Width = 125;
            // 
            // colPris
            // 
            colPris.HeaderText = "Pris";
            colPris.MinimumWidth = 6;
            colPris.Name = "colPris";
            colPris.Width = 125;
            // 
            // colSkick
            // 
            colSkick.HeaderText = "Skick";
            colSkick.MinimumWidth = 6;
            colSkick.Name = "colSkick";
            colSkick.Width = 125;
            // 
            // colTyp
            // 
            colTyp.HeaderText = "Typ";
            colTyp.MinimumWidth = 6;
            colTyp.Name = "colTyp";
            colTyp.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // lblMinaAnnonserRubrik
            // 
            lblMinaAnnonserRubrik.AutoSize = true;
            lblMinaAnnonserRubrik.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinaAnnonserRubrik.Location = new Point(186, 11);
            lblMinaAnnonserRubrik.Name = "lblMinaAnnonserRubrik";
            lblMinaAnnonserRubrik.Size = new Size(168, 31);
            lblMinaAnnonserRubrik.TabIndex = 5;
            lblMinaAnnonserRubrik.Text = "Mina annonser";
            // 
            // panelStartsida
            // 
            panelStartsida.Controls.Add(lblVälkommen);
            panelStartsida.Controls.Add(lblBookSwapRubrik);
            panelStartsida.Location = new Point(195, 21);
            panelStartsida.Name = "panelStartsida";
            panelStartsida.Size = new Size(590, 404);
            panelStartsida.TabIndex = 8;
            // 
            // lblVälkommen
            // 
            lblVälkommen.AutoSize = true;
            lblVälkommen.Location = new Point(235, 85);
            lblVälkommen.Name = "lblVälkommen";
            lblVälkommen.Size = new Size(87, 20);
            lblVälkommen.TabIndex = 6;
            lblVälkommen.Text = "Välkommen";
            // 
            // lblBookSwapRubrik
            // 
            lblBookSwapRubrik.AutoSize = true;
            lblBookSwapRubrik.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookSwapRubrik.Location = new Point(216, 39);
            lblBookSwapRubrik.Name = "lblBookSwapRubrik";
            lblBookSwapRubrik.Size = new Size(124, 31);
            lblBookSwapRubrik.TabIndex = 5;
            lblBookSwapRubrik.Text = "BookSwap";
            // 
            // StudentFönster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelStartsida);
            Controls.Add(panelMinaAnnonser);
            Controls.Add(panelMeny);
            Name = "StudentFönster";
            Text = "StudentFönster";
            panelMeny.ResumeLayout(false);
            panelMeny.PerformLayout();
            panelMinaAnnonser.ResumeLayout(false);
            panelMinaAnnonser.PerformLayout();
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
        private Panel panelMinaAnnonser;
        private DataGridView dataGridViewMinaAnnonser;
        private Label lblMinaAnnonserRubrik;
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