namespace Pemira_HME
{
    partial class FormLihatDatabase
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
            this.kembaliButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kembaliButton
            // 
            this.kembaliButton.FlatAppearance.BorderSize = 0;
            this.kembaliButton.Font = new System.Drawing.Font("Product Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembaliButton.Location = new System.Drawing.Point(334, 353);
            this.kembaliButton.Name = "kembaliButton";
            this.kembaliButton.Size = new System.Drawing.Size(356, 63);
            this.kembaliButton.TabIndex = 5;
            this.kembaliButton.Text = "KEMBALI";
            this.kembaliButton.UseVisualStyleBackColor = true;
            this.kembaliButton.Click += new System.EventHandler(this.kembaliButton_Click);
            // 
            // FormLihatDatabase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.kembaliButton);
            this.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormLihatDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLihatDatabase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kembaliButton;
    }
}