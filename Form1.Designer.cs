namespace TulisanBerjalan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblAnimasi = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblAnimasi
            // 
            this.lblAnimasi.AutoSize = true;
            this.lblAnimasi.Location = new System.Drawing.Point(136, 63);
            this.lblAnimasi.Name = "lblAnimasi";
            this.lblAnimasi.Size = new System.Drawing.Size(82, 13);
            this.lblAnimasi.TabIndex = 0;
            this.lblAnimasi.Text = "Tulisan Berjalan";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(315, 115);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 149);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.lblAnimasi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tulisan Berjalan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimasi;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Timer timer1;
    }
}

