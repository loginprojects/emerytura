namespace WindowsFormsAppEmerytura
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelImie = new System.Windows.Forms.Label();
            this.labelWiek = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelImie.Location = new System.Drawing.Point(40, 38);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(29, 13);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imię:";
            // 
            // labelWiek
            // 
            this.labelWiek.AutoSize = true;
            this.labelWiek.Location = new System.Drawing.Point(40, 71);
            this.labelWiek.Name = "labelWiek";
            this.labelWiek.Size = new System.Drawing.Size(35, 13);
            this.labelWiek.TabIndex = 1;
            this.labelWiek.Text = "Wiek:";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(107, 38);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 2;
            this.textBoxImie.Text = "Anonim";
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(107, 71);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiek.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(131, 133);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(43, 178);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(100, 13);
            this.labelWynik.TabIndex = 5;
            this.labelWynik.Text = "Nie podano danych";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 226);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.labelWiek);
            this.Controls.Add(this.labelImie);
            this.Name = "Form1";
            this.Text = "Emerytura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelWiek;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelWynik;
    }
}

