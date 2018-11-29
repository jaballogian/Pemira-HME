namespace Pemira_HME
{
    partial class DialogKonfirmasiPemilih
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
            this.berakhirnyaPemiraHMECheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.masukButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // berakhirnyaPemiraHMECheckBox
            // 
            this.berakhirnyaPemiraHMECheckBox.AutoSize = true;
            this.berakhirnyaPemiraHMECheckBox.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.berakhirnyaPemiraHMECheckBox.Location = new System.Drawing.Point(28, 374);
            this.berakhirnyaPemiraHMECheckBox.Name = "berakhirnyaPemiraHMECheckBox";
            this.berakhirnyaPemiraHMECheckBox.Size = new System.Drawing.Size(195, 24);
            this.berakhirnyaPemiraHMECheckBox.TabIndex = 18;
            this.berakhirnyaPemiraHMECheckBox.Text = "Ini adalah identitas saya";
            this.berakhirnyaPemiraHMECheckBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = global::Pemira_HME.Properties.Resources.red_circle;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(398, 18);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 30);
            this.exitButton.TabIndex = 17;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 20F);
            this.label2.Location = new System.Drawing.Point(123, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 34);
            this.label2.TabIndex = 16;
            this.label2.Text = "NIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 20F);
            this.label1.Location = new System.Drawing.Point(107, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nama";
            // 
            // masukButton
            // 
            this.masukButton.FlatAppearance.BorderSize = 0;
            this.masukButton.Font = new System.Drawing.Font("Product Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masukButton.Location = new System.Drawing.Point(113, 419);
            this.masukButton.Name = "masukButton";
            this.masukButton.Size = new System.Drawing.Size(238, 63);
            this.masukButton.TabIndex = 14;
            this.masukButton.Text = "Masuk";
            this.masukButton.UseVisualStyleBackColor = true;
            this.masukButton.Click += new System.EventHandler(this.masukButton_Click);
            // 
            // DialogKonfirmasiPemilih
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.berakhirnyaPemiraHMECheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masukButton);
            this.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "DialogKonfirmasiPemilih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogKonfirmasiPemilih";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox berakhirnyaPemiraHMECheckBox;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button masukButton;
    }
}