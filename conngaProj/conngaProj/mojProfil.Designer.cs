namespace conngaProj
{
    partial class mojProfil
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mojProfil));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chsBg = new System.Windows.Forms.Button();
            this.chsBg2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1015, 681);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // chsBg
            // 
            this.chsBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.chsBg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chsBg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.chsBg.Image = ((System.Drawing.Image)(resources.GetObject("chsBg.Image")));
            this.chsBg.Location = new System.Drawing.Point(724, 221);
            this.chsBg.Name = "chsBg";
            this.chsBg.Size = new System.Drawing.Size(271, 57);
            this.chsBg.TabIndex = 2;
            this.chsBg.UseVisualStyleBackColor = false;
            this.chsBg.Click += new System.EventHandler(this.chsBg_Click);
            // 
            // chsBg2
            // 
            this.chsBg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.chsBg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chsBg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.chsBg2.Image = ((System.Drawing.Image)(resources.GetObject("chsBg2.Image")));
            this.chsBg2.Location = new System.Drawing.Point(724, 225);
            this.chsBg2.Name = "chsBg2";
            this.chsBg2.Size = new System.Drawing.Size(271, 48);
            this.chsBg2.TabIndex = 3;
            this.chsBg2.UseVisualStyleBackColor = false;
            this.chsBg2.Click += new System.EventHandler(this.chsBg2_Click_1);
            // 
            // mojProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.chsBg2);
            this.Controls.Add(this.chsBg);
            this.Controls.Add(this.pictureBox2);
            this.Name = "mojProfil";
            this.Size = new System.Drawing.Size(1015, 681);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox2;
        private Button chsBg;
        private Button chsBg2;
    }
}
