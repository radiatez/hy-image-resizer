namespace hy_image_resizer
{
    partial class frmMain
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
            this.pnlAyarPaneli = new System.Windows.Forms.Panel();
            this.pBoxBanner = new System.Windows.Forms.PictureBox();
            this.pnlBelirtec = new System.Windows.Forms.Panel();
            this.siticoneDragControl1 = new ns1.SiticoneDragControl(this.components);
            this.siticoneElipse1 = new ns1.SiticoneElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.oFileResimEkle1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBanner)).BeginInit();
            this.pnlBelirtec.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAyarPaneli
            // 
            this.pnlAyarPaneli.BackColor = System.Drawing.Color.White;
            this.pnlAyarPaneli.Location = new System.Drawing.Point(12, 12);
            this.pnlAyarPaneli.Name = "pnlAyarPaneli";
            this.pnlAyarPaneli.Size = new System.Drawing.Size(756, 95);
            this.pnlAyarPaneli.TabIndex = 0;
            // 
            // pBoxBanner
            // 
            this.pBoxBanner.Location = new System.Drawing.Point(12, 189);
            this.pBoxBanner.Name = "pBoxBanner";
            this.pBoxBanner.Size = new System.Drawing.Size(756, 95);
            this.pBoxBanner.TabIndex = 2;
            this.pBoxBanner.TabStop = false;
            // 
            // pnlBelirtec
            // 
            this.pnlBelirtec.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlBelirtec.Controls.Add(this.pnlAyarPaneli);
            this.pnlBelirtec.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBelirtec.Location = new System.Drawing.Point(0, 0);
            this.pnlBelirtec.Name = "pnlBelirtec";
            this.pnlBelirtec.Size = new System.Drawing.Size(780, 122);
            this.pnlBelirtec.TabIndex = 1;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.TargetControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oFileResimEkle1
            // 
            this.oFileResimEkle1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.pBoxBanner);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlBelirtec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 500);
            this.MinimumSize = new System.Drawing.Size(780, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBanner)).EndInit();
            this.pnlBelirtec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAyarPaneli;
        private System.Windows.Forms.Panel pnlBelirtec;
        private System.Windows.Forms.PictureBox pBoxBanner;
        private ns1.SiticoneDragControl siticoneDragControl1;
        private ns1.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog oFileResimEkle1;
    }
}

