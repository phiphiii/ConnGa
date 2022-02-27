namespace conngaProj
{
    partial class biblioteka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(biblioteka));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortowanieAZ = new System.Windows.Forms.Button();
            this.sortowanieZA = new System.Windows.Forms.Button();
            this.sortowanieSzukaj = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.sortowanieAZ);
            this.panel1.Controls.Add(this.sortowanieZA);
            this.panel1.Controls.Add(this.sortowanieSzukaj);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 135);
            this.panel1.TabIndex = 3;
            // 
            // sortowanieAZ
            // 
            this.sortowanieAZ.BackColor = System.Drawing.Color.White;
            this.sortowanieAZ.FlatAppearance.BorderSize = 0;
            this.sortowanieAZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortowanieAZ.Image = ((System.Drawing.Image)(resources.GetObject("sortowanieAZ.Image")));
            this.sortowanieAZ.Location = new System.Drawing.Point(44, 95);
            this.sortowanieAZ.Name = "sortowanieAZ";
            this.sortowanieAZ.Size = new System.Drawing.Size(166, 20);
            this.sortowanieAZ.TabIndex = 4;
            this.sortowanieAZ.UseVisualStyleBackColor = false;
            this.sortowanieAZ.Click += new System.EventHandler(this.sortowanieAZ_Click);
            // 
            // sortowanieZA
            // 
            this.sortowanieZA.BackColor = System.Drawing.Color.White;
            this.sortowanieZA.FlatAppearance.BorderSize = 0;
            this.sortowanieZA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortowanieZA.Image = ((System.Drawing.Image)(resources.GetObject("sortowanieZA.Image")));
            this.sortowanieZA.Location = new System.Drawing.Point(44, 62);
            this.sortowanieZA.Name = "sortowanieZA";
            this.sortowanieZA.Size = new System.Drawing.Size(160, 20);
            this.sortowanieZA.TabIndex = 5;
            this.sortowanieZA.UseVisualStyleBackColor = false;
            this.sortowanieZA.Click += new System.EventHandler(this.sortowanieZA_Click);
            // 
            // sortowanieSzukaj
            // 
            this.sortowanieSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.sortowanieSzukaj.FlatAppearance.BorderSize = 0;
            this.sortowanieSzukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortowanieSzukaj.Image = ((System.Drawing.Image)(resources.GetObject("sortowanieSzukaj.Image")));
            this.sortowanieSzukaj.Location = new System.Drawing.Point(766, 72);
            this.sortowanieSzukaj.Name = "sortowanieSzukaj";
            this.sortowanieSzukaj.Size = new System.Drawing.Size(200, 33);
            this.sortowanieSzukaj.TabIndex = 4;
            this.sortowanieSzukaj.UseVisualStyleBackColor = false;
            this.sortowanieSzukaj.Click += new System.EventHandler(this.sortowanieSzukaj_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(29, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(945, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 157);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(957, 316);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // biblioteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Name = "biblioteka";
            this.Size = new System.Drawing.Size(1015, 681);
            this.Load += new System.EventHandler(this.biblioteka_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button sortowanieSzukaj;
        private Button sortowanieAZ;
        private Button sortowanieZA;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}
