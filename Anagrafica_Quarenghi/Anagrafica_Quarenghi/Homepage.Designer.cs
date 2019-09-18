namespace Anagrafica_Quarenghi
{
    partial class Homepage
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
            this.button_CreaUtente = new System.Windows.Forms.Button();
            this.listBox_ListaUtenti = new System.Windows.Forms.ListBox();
            this.comboBox_sorting = new System.Windows.Forms.ComboBox();
            this.button_EsportaSuFile = new System.Windows.Forms.Button();
            this.label_sorting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CreaUtente
            // 
            this.button_CreaUtente.Location = new System.Drawing.Point(12, 13);
            this.button_CreaUtente.Name = "button_CreaUtente";
            this.button_CreaUtente.Size = new System.Drawing.Size(123, 53);
            this.button_CreaUtente.TabIndex = 5;
            this.button_CreaUtente.Text = "Crea nuovo utente";
            this.button_CreaUtente.UseVisualStyleBackColor = true;
            this.button_CreaUtente.Click += new System.EventHandler(this.button_CreaUtente_Click);
            // 
            // listBox_ListaUtenti
            // 
            this.listBox_ListaUtenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_ListaUtenti.FormattingEnabled = true;
            this.listBox_ListaUtenti.ItemHeight = 16;
            this.listBox_ListaUtenti.Location = new System.Drawing.Point(163, 13);
            this.listBox_ListaUtenti.Name = "listBox_ListaUtenti";
            this.listBox_ListaUtenti.Size = new System.Drawing.Size(404, 340);
            this.listBox_ListaUtenti.TabIndex = 6;
            // 
            // comboBox_sorting
            // 
            this.comboBox_sorting.FormattingEnabled = true;
            this.comboBox_sorting.Items.AddRange(new object[] {
            "Per cognome",
            "Per ruolo"});
            this.comboBox_sorting.Location = new System.Drawing.Point(573, 28);
            this.comboBox_sorting.Name = "comboBox_sorting";
            this.comboBox_sorting.Size = new System.Drawing.Size(135, 24);
            this.comboBox_sorting.TabIndex = 7;
            this.comboBox_sorting.SelectedIndexChanged += new System.EventHandler(this.comboBox_sorting_SelectedIndexChanged);
            // 
            // button_EsportaSuFile
            // 
            this.button_EsportaSuFile.Location = new System.Drawing.Point(12, 86);
            this.button_EsportaSuFile.Name = "button_EsportaSuFile";
            this.button_EsportaSuFile.Size = new System.Drawing.Size(123, 53);
            this.button_EsportaSuFile.TabIndex = 13;
            this.button_EsportaSuFile.Text = "Esporta su file";
            this.button_EsportaSuFile.UseVisualStyleBackColor = true;
            this.button_EsportaSuFile.Click += new System.EventHandler(this.button_salva_Click);
            // 
            // label_sorting
            // 
            this.label_sorting.AutoSize = true;
            this.label_sorting.Location = new System.Drawing.Point(573, 8);
            this.label_sorting.Name = "label_sorting";
            this.label_sorting.Size = new System.Drawing.Size(68, 17);
            this.label_sorting.TabIndex = 14;
            this.label_sorting.Text = "Filtra per:";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 438);
            this.Controls.Add(this.label_sorting);
            this.Controls.Add(this.button_EsportaSuFile);
            this.Controls.Add(this.comboBox_sorting);
            this.Controls.Add(this.listBox_ListaUtenti);
            this.Controls.Add(this.button_CreaUtente);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_CreaUtente;
        private System.Windows.Forms.ListBox listBox_ListaUtenti;
        private System.Windows.Forms.ComboBox comboBox_sorting;
        private System.Windows.Forms.Button button_EsportaSuFile;
        private System.Windows.Forms.Label label_sorting;
    }
}

