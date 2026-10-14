namespace GUI
{
    partial class MinaAnnonser
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
            panel1 = new Panel();
            lblRubrik = new Label();
            dataGridViewMinaAnnonser = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            colTitel = new DataGridViewTextBoxColumn();
            colKurs = new DataGridViewTextBoxColumn();
            colPris = new DataGridViewTextBoxColumn();
            colSkick = new DataGridViewTextBoxColumn();
            colTyp = new DataGridViewTextBoxColumn();
            btnAvbryt = new Button();
            colStatus = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMinaAnnonser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblRubrik);
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 42);
            panel1.TabIndex = 0;
            // 
            // lblRubrik
            // 
            lblRubrik.AutoSize = true;
            lblRubrik.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRubrik.Location = new Point(303, 0);
            lblRubrik.Name = "lblRubrik";
            lblRubrik.Size = new Size(168, 31);
            lblRubrik.TabIndex = 0;
            lblRubrik.Text = "Mina annonser";
            // 
            // dataGridViewMinaAnnonser
            // 
            dataGridViewMinaAnnonser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMinaAnnonser.Columns.AddRange(new DataGridViewColumn[] { ColID, colTitel, colKurs, colPris, colSkick, colTyp, colStatus });
            dataGridViewMinaAnnonser.Location = new Point(12, 53);
            dataGridViewMinaAnnonser.Name = "dataGridViewMinaAnnonser";
            dataGridViewMinaAnnonser.RowHeadersWidth = 51;
            dataGridViewMinaAnnonser.Size = new Size(776, 341);
            dataGridViewMinaAnnonser.TabIndex = 1;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.Visible = false;
            ColID.Width = 125;
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
            // btnAvbryt
            // 
            btnAvbryt.Location = new Point(12, 400);
            btnAvbryt.Name = "btnAvbryt";
            btnAvbryt.Size = new Size(132, 41);
            btnAvbryt.TabIndex = 2;
            btnAvbryt.Text = "Avbryt";
            btnAvbryt.UseVisualStyleBackColor = true;
            btnAvbryt.Click += btnAvbryt_Click;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // MinaAnnonser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvbryt);
            Controls.Add(dataGridViewMinaAnnonser);
            Controls.Add(panel1);
            Name = "MinaAnnonser";
            Text = "MinaAnnonser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMinaAnnonser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblRubrik;
        private DataGridView dataGridViewMinaAnnonser;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn colTitel;
        private DataGridViewTextBoxColumn colKurs;
        private DataGridViewTextBoxColumn colPris;
        private DataGridViewTextBoxColumn colSkick;
        private Button btnAvbryt;
        private DataGridViewTextBoxColumn colTyp;
        private DataGridViewTextBoxColumn colStatus;
    }
}