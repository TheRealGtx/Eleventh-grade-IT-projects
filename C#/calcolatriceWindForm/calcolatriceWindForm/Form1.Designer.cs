
namespace calcolatriceWindForm
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.bottoneUno = new System.Windows.Forms.Button();
            this.bottoneZero = new System.Windows.Forms.Button();
            this.comparsaNumeri = new System.Windows.Forms.TextBox();
            this.cancellaUnElemento = new System.Windows.Forms.Button();
            this.cancellaTutto = new System.Windows.Forms.Button();
            this.or = new System.Windows.Forms.Button();
            this.and = new System.Windows.Forms.Button();
            this.xor = new System.Windows.Forms.Button();
            this.not = new System.Windows.Forms.Button();
            this.addZeroinizio = new System.Windows.Forms.Button();
            this.addZeroFine = new System.Windows.Forms.Button();
            this.Risultato = new System.Windows.Forms.Button();
            this.operatore = new System.Windows.Forms.Label();
            this.crediti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottoneUno
            // 
            this.bottoneUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottoneUno.Location = new System.Drawing.Point(44, 196);
            this.bottoneUno.Name = "bottoneUno";
            this.bottoneUno.Size = new System.Drawing.Size(63, 45);
            this.bottoneUno.TabIndex = 1;
            this.bottoneUno.Text = "1";
            this.bottoneUno.UseVisualStyleBackColor = true;
            this.bottoneUno.Click += new System.EventHandler(this.button1_Click);
            // 
            // bottoneZero
            // 
            this.bottoneZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottoneZero.Location = new System.Drawing.Point(142, 196);
            this.bottoneZero.Name = "bottoneZero";
            this.bottoneZero.Size = new System.Drawing.Size(63, 45);
            this.bottoneZero.TabIndex = 2;
            this.bottoneZero.Text = "0";
            this.bottoneZero.UseVisualStyleBackColor = true;
            this.bottoneZero.Click += new System.EventHandler(this.bottoneZero_Click);
            // 
            // comparsaNumeri
            // 
            this.comparsaNumeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comparsaNumeri.Location = new System.Drawing.Point(12, 12);
            this.comparsaNumeri.Name = "comparsaNumeri";
            this.comparsaNumeri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comparsaNumeri.Size = new System.Drawing.Size(236, 62);
            this.comparsaNumeri.TabIndex = 3;
            this.comparsaNumeri.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cancellaUnElemento
            // 
            this.cancellaUnElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancellaUnElemento.Location = new System.Drawing.Point(44, 106);
            this.cancellaUnElemento.Name = "cancellaUnElemento";
            this.cancellaUnElemento.Size = new System.Drawing.Size(60, 48);
            this.cancellaUnElemento.TabIndex = 4;
            this.cancellaUnElemento.Text = "ce";
            this.cancellaUnElemento.UseVisualStyleBackColor = true;
            this.cancellaUnElemento.Click += new System.EventHandler(this.cancellaUnElemento_Click);
            // 
            // cancellaTutto
            // 
            this.cancellaTutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancellaTutto.Location = new System.Drawing.Point(142, 106);
            this.cancellaTutto.Name = "cancellaTutto";
            this.cancellaTutto.Size = new System.Drawing.Size(60, 48);
            this.cancellaTutto.TabIndex = 5;
            this.cancellaTutto.Text = "cc";
            this.cancellaTutto.UseVisualStyleBackColor = true;
            this.cancellaTutto.Click += new System.EventHandler(this.cancellaTutto_Click);
            // 
            // or
            // 
            this.or.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or.Location = new System.Drawing.Point(250, 195);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(63, 46);
            this.or.TabIndex = 6;
            this.or.Text = "or";
            this.or.UseVisualStyleBackColor = true;
            this.or.Click += new System.EventHandler(this.or_Click);
            // 
            // and
            // 
            this.and.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.and.Location = new System.Drawing.Point(250, 271);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(63, 48);
            this.and.TabIndex = 7;
            this.and.Text = "and";
            this.and.UseVisualStyleBackColor = true;
            this.and.Click += new System.EventHandler(this.and_Click);
            // 
            // xor
            // 
            this.xor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xor.Location = new System.Drawing.Point(250, 353);
            this.xor.Name = "xor";
            this.xor.Size = new System.Drawing.Size(63, 48);
            this.xor.TabIndex = 8;
            this.xor.Text = "xor";
            this.xor.UseVisualStyleBackColor = true;
            this.xor.Click += new System.EventHandler(this.xor_Click);
            // 
            // not
            // 
            this.not.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not.Location = new System.Drawing.Point(142, 355);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(63, 46);
            this.not.TabIndex = 9;
            this.not.Text = "not";
            this.not.UseVisualStyleBackColor = true;
            this.not.Click += new System.EventHandler(this.not_Click);
            // 
            // addZeroinizio
            // 
            this.addZeroinizio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addZeroinizio.Location = new System.Drawing.Point(44, 275);
            this.addZeroinizio.Name = "addZeroinizio";
            this.addZeroinizio.Size = new System.Drawing.Size(63, 44);
            this.addZeroinizio.TabIndex = 10;
            this.addZeroinizio.Text = "<<";
            this.addZeroinizio.UseVisualStyleBackColor = true;
            this.addZeroinizio.Click += new System.EventHandler(this.addZeroinizio_Click);
            // 
            // addZeroFine
            // 
            this.addZeroFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addZeroFine.Location = new System.Drawing.Point(142, 271);
            this.addZeroFine.Name = "addZeroFine";
            this.addZeroFine.Size = new System.Drawing.Size(63, 46);
            this.addZeroFine.TabIndex = 11;
            this.addZeroFine.Text = ">>";
            this.addZeroFine.UseVisualStyleBackColor = true;
            this.addZeroFine.Click += new System.EventHandler(this.addZeroFine_Click);
            // 
            // Risultato
            // 
            this.Risultato.Enabled = false;
            this.Risultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Risultato.Location = new System.Drawing.Point(44, 356);
            this.Risultato.Name = "Risultato";
            this.Risultato.Size = new System.Drawing.Size(63, 45);
            this.Risultato.TabIndex = 12;
            this.Risultato.Text = "=";
            this.Risultato.UseVisualStyleBackColor = true;
            this.Risultato.Click += new System.EventHandler(this.Risultato_Click);
            // 
            // operatore
            // 
            this.operatore.AutoSize = true;
            this.operatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatore.Location = new System.Drawing.Point(261, 35);
            this.operatore.Name = "operatore";
            this.operatore.Size = new System.Drawing.Size(0, 31);
            this.operatore.TabIndex = 13;
            // 
            // crediti
            // 
            this.crediti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crediti.Location = new System.Drawing.Point(250, 106);
            this.crediti.Name = "crediti";
            this.crediti.Size = new System.Drawing.Size(63, 48);
            this.crediti.TabIndex = 14;
            this.crediti.Text = "Crediti";
            this.crediti.UseVisualStyleBackColor = true;
            this.crediti.Click += new System.EventHandler(this.crediti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 437);
            this.Controls.Add(this.crediti);
            this.Controls.Add(this.operatore);
            this.Controls.Add(this.Risultato);
            this.Controls.Add(this.addZeroFine);
            this.Controls.Add(this.addZeroinizio);
            this.Controls.Add(this.not);
            this.Controls.Add(this.xor);
            this.Controls.Add(this.and);
            this.Controls.Add(this.or);
            this.Controls.Add(this.cancellaTutto);
            this.Controls.Add(this.cancellaUnElemento);
            this.Controls.Add(this.comparsaNumeri);
            this.Controls.Add(this.bottoneZero);
            this.Controls.Add(this.bottoneUno);
            this.Name = "Form1";
            this.Text = "Calcolatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bottoneUno;
        private System.Windows.Forms.Button bottoneZero;
        private System.Windows.Forms.TextBox comparsaNumeri;
        private System.Windows.Forms.Button cancellaUnElemento;
        private System.Windows.Forms.Button cancellaTutto;
        private System.Windows.Forms.Button or;
        private System.Windows.Forms.Button and;
        private System.Windows.Forms.Button xor;
        private System.Windows.Forms.Button not;
        private System.Windows.Forms.Button addZeroinizio;
        private System.Windows.Forms.Button addZeroFine;
        private System.Windows.Forms.Button Risultato;
        private System.Windows.Forms.Label operatore;
        private System.Windows.Forms.Button crediti;
    }
}

