
namespace P31_Porpiglia3AINF
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
            this.BTcalcola = new System.Windows.Forms.Button();
            this.NUDpes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTesci = new System.Windows.Forms.Button();
            this.NUDusd = new System.Windows.Forms.NumericUpDown();
            this.NUDeur = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDpes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDusd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDeur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcola il prezzo della spedizione con United States Postal Service";
            // 
            // BTcalcola
            // 
            this.BTcalcola.Location = new System.Drawing.Point(251, 51);
            this.BTcalcola.Name = "BTcalcola";
            this.BTcalcola.Size = new System.Drawing.Size(100, 69);
            this.BTcalcola.TabIndex = 4;
            this.BTcalcola.Text = "Calcola";
            this.BTcalcola.UseVisualStyleBackColor = true;
            this.BTcalcola.Click += new System.EventHandler(this.BTcalcola_Click);
            // 
            // NUDpes
            // 
            this.NUDpes.Location = new System.Drawing.Point(125, 51);
            this.NUDpes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDpes.Name = "NUDpes";
            this.NUDpes.Size = new System.Drawing.Size(120, 20);
            this.NUDpes.TabIndex = 1;
            this.NUDpes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso in LIBBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo in $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Costo in €";
            // 
            // BTesci
            // 
            this.BTesci.Location = new System.Drawing.Point(357, 9);
            this.BTesci.Name = "BTesci";
            this.BTesci.Size = new System.Drawing.Size(75, 23);
            this.BTesci.TabIndex = 5;
            this.BTesci.Text = "Esci";
            this.BTesci.UseVisualStyleBackColor = true;
            this.BTesci.Click += new System.EventHandler(this.BTesci_Click);
            // 
            // NUDusd
            // 
            this.NUDusd.Location = new System.Drawing.Point(125, 75);
            this.NUDusd.Name = "NUDusd";
            this.NUDusd.Size = new System.Drawing.Size(120, 20);
            this.NUDusd.TabIndex = 2;
            this.NUDusd.Click += new System.EventHandler(this.NUDusd_Click);
            // 
            // NUDeur
            // 
            this.NUDeur.Location = new System.Drawing.Point(125, 100);
            this.NUDeur.Name = "NUDeur";
            this.NUDeur.Size = new System.Drawing.Size(120, 20);
            this.NUDeur.TabIndex = 3;
            this.NUDeur.Click += new System.EventHandler(this.NUDeur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 154);
            this.Controls.Add(this.NUDeur);
            this.Controls.Add(this.NUDusd);
            this.Controls.Add(this.BTesci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDpes);
            this.Controls.Add(this.BTcalcola);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcola peso pacco - Porpiglia 3AINF";
            ((System.ComponentModel.ISupportInitialize)(this.NUDpes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDusd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTcalcola;
        private System.Windows.Forms.NumericUpDown NUDpes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTesci;
        private System.Windows.Forms.NumericUpDown NUDusd;
        private System.Windows.Forms.NumericUpDown NUDeur;
    }
}

