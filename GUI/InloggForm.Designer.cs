namespace GUI
{
    partial class InloggForm
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
            txtNamn = new TextBox();
            txtLosen = new TextBox();
            lblNamn = new Label();
            lblLosen = new Label();
            btnInlogg = new Button();
            btnSkapa = new Button();
            SuspendLayout();
            // 
            // txtNamn
            // 
            txtNamn.Location = new Point(188, 42);
            txtNamn.Name = "txtNamn";
            txtNamn.Size = new Size(224, 31);
            txtNamn.TabIndex = 0;
            // 
            // txtLosen
            // 
            txtLosen.Location = new Point(188, 79);
            txtLosen.Name = "txtLosen";
            txtLosen.Size = new Size(224, 31);
            txtLosen.TabIndex = 1;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(45, 45);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(137, 25);
            lblNamn.TabIndex = 2;
            lblNamn.Text = "Användarnamn:";
            // 
            // lblLosen
            // 
            lblLosen.AutoSize = true;
            lblLosen.Location = new Point(92, 82);
            lblLosen.Name = "lblLosen";
            lblLosen.Size = new Size(90, 25);
            lblLosen.TabIndex = 3;
            lblLosen.Text = "Lösenord:";
            // 
            // btnInlogg
            // 
            btnInlogg.Location = new Point(300, 144);
            btnInlogg.Name = "btnInlogg";
            btnInlogg.Size = new Size(112, 34);
            btnInlogg.TabIndex = 4;
            btnInlogg.Text = "Logga in";
            btnInlogg.UseVisualStyleBackColor = true;
            btnInlogg.Click += button1_Click;
            // 
            // btnSkapa
            // 
            btnSkapa.Location = new Point(166, 144);
            btnSkapa.Name = "btnSkapa";
            btnSkapa.Size = new Size(128, 34);
            btnSkapa.TabIndex = 5;
            btnSkapa.Text = "Skapa konto";
            btnSkapa.UseVisualStyleBackColor = true;
            btnSkapa.Click += button2_Click;
            // 
            // InloggForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 234);
            Controls.Add(btnSkapa);
            Controls.Add(btnInlogg);
            Controls.Add(lblLosen);
            Controls.Add(lblNamn);
            Controls.Add(txtLosen);
            Controls.Add(txtNamn);
            Name = "InloggForm";
            Text = "InloggForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamn;
        private TextBox txtLosen;
        private Label lblNamn;
        private Label lblLosen;
        private Button btnInlogg;
        private Button btnSkapa;
    }
}