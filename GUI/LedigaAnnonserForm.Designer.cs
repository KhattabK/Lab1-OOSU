namespace GUI
{
    partial class LedigaAnnonserForm
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
            lblTitel = new Label();
            dataGridViewLedigaAnnonser = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            colTitel = new DataGridViewTextBoxColumn();
            colKurs = new DataGridViewTextBoxColumn();
            colPris = new DataGridViewTextBoxColumn();
            colSkick = new DataGridViewTextBoxColumn();
            colTyp = new DataGridViewTextBoxColumn();
            btnAvbryt = new Button();
            btnReserveraAnnons = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLedigaAnnonser).BeginInit();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(26, 32);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(145, 20);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Tillgänliga Annonser";
            // 
            // dataGridViewLedigaAnnonser
            // 
            dataGridViewLedigaAnnonser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewLedigaAnnonser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLedigaAnnonser.Columns.AddRange(new DataGridViewColumn[] { ColId, colTitel, colKurs, colPris, colSkick, colTyp });
            dataGridViewLedigaAnnonser.Location = new Point(12, 55);
            dataGridViewLedigaAnnonser.MultiSelect = false;
            dataGridViewLedigaAnnonser.Name = "dataGridViewLedigaAnnonser";
            dataGridViewLedigaAnnonser.ReadOnly = true;
            dataGridViewLedigaAnnonser.RowHeadersWidth = 51;
            dataGridViewLedigaAnnonser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLedigaAnnonser.Size = new Size(776, 332);
            dataGridViewLedigaAnnonser.TabIndex = 1;
            // 
            // ColId
            // 
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Visible = false;
            ColId.Width = 125;
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
            // btnAvbryt
            // 
            btnAvbryt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAvbryt.Location = new Point(428, 399);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(94, 41);
            btnAvbryt.TabIndex = 2;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // btnReserveraAnnons
            // 
            btnReserveraAnnons.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReserveraAnnons.Location = new Point(552, 399);
            btnReserveraAnnons.Name = "btnReserveraAnnons";
            btnReserveraAnnons.Size = new Size(216, 41);
            btnReserveraAnnons.TabIndex = 3;
            btnReserveraAnnons.Text = "Reservera vald annons";
            btnReserveraAnnons.UseVisualStyleBackColor = true;
            btnReserveraAnnons.Click += btnReserveraAnnons_Click;
            // 
            // LedigaAnnonserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReserveraAnnons);
            Controls.Add(btnAvbryt);
            Controls.Add(dataGridViewLedigaAnnonser);
            Controls.Add(lblTitel);
            Name = "LedigaAnnonserForm";
            Text = "LedigaAnnonserForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLedigaAnnonser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private DataGridView dataGridViewLedigaAnnonser;
        private Button btnAvbryt;
        private Button btnReserveraAnnons;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn colTitel;
        private DataGridViewTextBoxColumn colKurs;
        private DataGridViewTextBoxColumn colPris;
        private DataGridViewTextBoxColumn colSkick;
        private DataGridViewTextBoxColumn colTyp;
    }
}