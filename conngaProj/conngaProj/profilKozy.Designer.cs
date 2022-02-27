namespace conngaProj
{
    partial class profilKozy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profilKozy));
            this.label1 = new System.Windows.Forms.Label();
            this.kozkapedal = new System.Windows.Forms.PictureBox();
            this.dodajZnaj = new System.Windows.Forms.Button();
            this.cnclZnaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kozkapedal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(345, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tutaj będzie Profil Kozy";
            // 
            // kozkapedal
            // 
            this.kozkapedal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.kozkapedal.Image = ((System.Drawing.Image)(resources.GetObject("kozkapedal.Image")));
            this.kozkapedal.Location = new System.Drawing.Point(0, 0);
            this.kozkapedal.Name = "kozkapedal";
            this.kozkapedal.Size = new System.Drawing.Size(1015, 681);
            this.kozkapedal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kozkapedal.TabIndex = 2;
            this.kozkapedal.TabStop = false;
            this.kozkapedal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dodajZnaj
            // 
            this.dodajZnaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.dodajZnaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajZnaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajZnaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.dodajZnaj.Image = ((System.Drawing.Image)(resources.GetObject("dodajZnaj.Image")));
            this.dodajZnaj.Location = new System.Drawing.Point(809, 234);
            this.dodajZnaj.Name = "dodajZnaj";
            this.dodajZnaj.Size = new System.Drawing.Size(184, 38);
            this.dodajZnaj.TabIndex = 3;
            this.dodajZnaj.UseVisualStyleBackColor = false;
            this.dodajZnaj.Click += new System.EventHandler(this.dodajZnaj_Click);
            // 
            // cnclZnaj
            // 
            this.cnclZnaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cnclZnaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cnclZnaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnclZnaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cnclZnaj.Image = ((System.Drawing.Image)(resources.GetObject("cnclZnaj.Image")));
            this.cnclZnaj.Location = new System.Drawing.Point(809, 234);
            this.cnclZnaj.Name = "cnclZnaj";
            this.cnclZnaj.Size = new System.Drawing.Size(184, 38);
            this.cnclZnaj.TabIndex = 4;
            this.cnclZnaj.UseVisualStyleBackColor = false;
            this.cnclZnaj.Click += new System.EventHandler(this.cnclZnaj_Click);
            // 
            // profilKozy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.dodajZnaj);
            this.Controls.Add(this.cnclZnaj);
            this.Controls.Add(this.kozkapedal);
            this.Controls.Add(this.label1);
            this.Name = "profilKozy";
            this.Size = new System.Drawing.Size(1015, 681);
            ((System.ComponentModel.ISupportInitialize)(this.kozkapedal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox kozkapedal;
        private Button dodajZnaj;
        private Button cnclZnaj;
    }
}
