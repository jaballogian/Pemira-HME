namespace Pemira_HME
{
    partial class FormAdmin
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
            this.lihatHasilPemiluButton = new System.Windows.Forms.Button();
            this.lihatDatabaseButton = new System.Windows.Forms.Button();
            this.tambahDPTBUtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lihatHasilPemiluButton
            // 
            this.lihatHasilPemiluButton.FlatAppearance.BorderSize = 0;
            this.lihatHasilPemiluButton.Font = new System.Drawing.Font("Product Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lihatHasilPemiluButton.Location = new System.Drawing.Point(231, 542);
            this.lihatHasilPemiluButton.Name = "lihatHasilPemiluButton";
            this.lihatHasilPemiluButton.Size = new System.Drawing.Size(354, 94);
            this.lihatHasilPemiluButton.TabIndex = 11;
            this.lihatHasilPemiluButton.Text = "LIHAT HASIL PEMILU";
            this.lihatHasilPemiluButton.UseVisualStyleBackColor = true;
            this.lihatHasilPemiluButton.Click += new System.EventHandler(this.lihatHasilPemiluButton_Click);
            // 
            // lihatDatabaseButton
            // 
            this.lihatDatabaseButton.FlatAppearance.BorderSize = 0;
            this.lihatDatabaseButton.Font = new System.Drawing.Font("Product Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lihatDatabaseButton.Location = new System.Drawing.Point(439, 323);
            this.lihatDatabaseButton.Name = "lihatDatabaseButton";
            this.lihatDatabaseButton.Size = new System.Drawing.Size(354, 94);
            this.lihatDatabaseButton.TabIndex = 10;
            this.lihatDatabaseButton.Text = "LIHAT DATABASE";
            this.lihatDatabaseButton.UseVisualStyleBackColor = true;
            this.lihatDatabaseButton.Click += new System.EventHandler(this.lihatDatabaseButton_Click);
            // 
            // tambahDPTBUtton
            // 
            this.tambahDPTBUtton.FlatAppearance.BorderSize = 0;
            this.tambahDPTBUtton.Font = new System.Drawing.Font("Product Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahDPTBUtton.Location = new System.Drawing.Point(263, 132);
            this.tambahDPTBUtton.Name = "tambahDPTBUtton";
            this.tambahDPTBUtton.Size = new System.Drawing.Size(354, 94);
            this.tambahDPTBUtton.TabIndex = 9;
            this.tambahDPTBUtton.Text = "TAMBAH DPT";
            this.tambahDPTBUtton.UseVisualStyleBackColor = true;
            this.tambahDPTBUtton.Click += new System.EventHandler(this.tambahDPTBUtton_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lihatHasilPemiluButton);
            this.Controls.Add(this.lihatDatabaseButton);
            this.Controls.Add(this.tambahDPTBUtton);
            this.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lihatHasilPemiluButton;
        private System.Windows.Forms.Button lihatDatabaseButton;
        private System.Windows.Forms.Button tambahDPTBUtton;
    }
}