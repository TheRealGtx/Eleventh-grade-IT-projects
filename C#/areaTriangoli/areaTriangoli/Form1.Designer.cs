
namespace areaTriangoli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Output1 = new System.Windows.Forms.Label();
            this.outout2 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.textBoxPrimaBase = new System.Windows.Forms.TextBox();
            this.textBoxPrimaAltezza = new System.Windows.Forms.TextBox();
            this.textBoxSecondaBase = new System.Windows.Forms.TextBox();
            this.textBoxSecondaAltezza = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base del primo triangolo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altezza del primo triangolo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base del secondo triangolo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Altezza del secondo triangolo:";
            // 
            // Output1
            // 
            this.Output1.AutoSize = true;
            this.Output1.Location = new System.Drawing.Point(388, 70);
            this.Output1.Name = "Output1";
            this.Output1.Size = new System.Drawing.Size(0, 13);
            this.Output1.TabIndex = 4;
            this.Output1.Click += new System.EventHandler(this.label5_Click);
            // 
            // outout2
            // 
            this.outout2.AutoSize = true;
            this.outout2.Location = new System.Drawing.Point(388, 209);
            this.outout2.Name = "outout2";
            this.outout2.Size = new System.Drawing.Size(0, 13);
            this.outout2.TabIndex = 5;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(42, 292);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // textBoxPrimaBase
            // 
            this.textBoxPrimaBase.Location = new System.Drawing.Point(193, 40);
            this.textBoxPrimaBase.Name = "textBoxPrimaBase";
            this.textBoxPrimaBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrimaBase.TabIndex = 7;
            // 
            // textBoxPrimaAltezza
            // 
            this.textBoxPrimaAltezza.Location = new System.Drawing.Point(193, 100);
            this.textBoxPrimaAltezza.Name = "textBoxPrimaAltezza";
            this.textBoxPrimaAltezza.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrimaAltezza.TabIndex = 8;
            // 
            // textBoxSecondaBase
            // 
            this.textBoxSecondaBase.Location = new System.Drawing.Point(193, 169);
            this.textBoxSecondaBase.Name = "textBoxSecondaBase";
            this.textBoxSecondaBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondaBase.TabIndex = 9;
            // 
            // textBoxSecondaAltezza
            // 
            this.textBoxSecondaAltezza.Location = new System.Drawing.Point(193, 236);
            this.textBoxSecondaAltezza.Name = "textBoxSecondaAltezza";
            this.textBoxSecondaAltezza.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondaAltezza.TabIndex = 10;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(432, 292);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 369);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxSecondaAltezza);
            this.Controls.Add(this.textBoxSecondaBase);
            this.Controls.Add(this.textBoxPrimaAltezza);
            this.Controls.Add(this.textBoxPrimaBase);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.outout2);
            this.Controls.Add(this.Output1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcolo area triangoli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Output1;
        private System.Windows.Forms.Label outout2;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.TextBox textBoxPrimaBase;
        private System.Windows.Forms.TextBox textBoxPrimaAltezza;
        private System.Windows.Forms.TextBox textBoxSecondaBase;
        private System.Windows.Forms.TextBox textBoxSecondaAltezza;
        private System.Windows.Forms.Button buttonReset;
    }
}

