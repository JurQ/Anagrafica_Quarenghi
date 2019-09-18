namespace Anagrafica_Quarenghi
{
    partial class CreazioneUtente
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
            this.label_DataNascita = new System.Windows.Forms.Label();
            this.label_ruolo = new System.Windows.Forms.Label();
            this.label_cognome = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.comboBox_ruolo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DataNascita = new System.Windows.Forms.DateTimePicker();
            this.textBox_cognome = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_annulla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_DataNascita
            // 
            this.label_DataNascita.AutoSize = true;
            this.label_DataNascita.Location = new System.Drawing.Point(10, 146);
            this.label_DataNascita.Name = "label_DataNascita";
            this.label_DataNascita.Size = new System.Drawing.Size(102, 17);
            this.label_DataNascita.TabIndex = 22;
            this.label_DataNascita.Text = "Data di nascita";
            // 
            // label_ruolo
            // 
            this.label_ruolo.AutoSize = true;
            this.label_ruolo.Location = new System.Drawing.Point(9, 99);
            this.label_ruolo.Name = "label_ruolo";
            this.label_ruolo.Size = new System.Drawing.Size(45, 17);
            this.label_ruolo.TabIndex = 21;
            this.label_ruolo.Text = "Ruolo";
            // 
            // label_cognome
            // 
            this.label_cognome.AutoSize = true;
            this.label_cognome.Location = new System.Drawing.Point(9, 54);
            this.label_cognome.Name = "label_cognome";
            this.label_cognome.Size = new System.Drawing.Size(68, 17);
            this.label_cognome.TabIndex = 20;
            this.label_cognome.Text = "Cognome";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(188, 10);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(55, 17);
            this.label_ID.TabIndex = 19;
            this.label_ID.Text = "User ID";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(9, 9);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(45, 17);
            this.label_nome.TabIndex = 18;
            this.label_nome.Text = "Nome";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(191, 29);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(110, 22);
            this.textBox_ID.TabIndex = 17;
            // 
            // comboBox_ruolo
            // 
            this.comboBox_ruolo.FormattingEnabled = true;
            this.comboBox_ruolo.Items.AddRange(new object[] {
            "Dipendente",
            "Cliente"});
            this.comboBox_ruolo.Location = new System.Drawing.Point(12, 119);
            this.comboBox_ruolo.Name = "comboBox_ruolo";
            this.comboBox_ruolo.Size = new System.Drawing.Size(137, 24);
            this.comboBox_ruolo.TabIndex = 16;
            // 
            // dateTimePicker_DataNascita
            // 
            this.dateTimePicker_DataNascita.Location = new System.Drawing.Point(12, 166);
            this.dateTimePicker_DataNascita.Name = "dateTimePicker_DataNascita";
            this.dateTimePicker_DataNascita.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker_DataNascita.TabIndex = 15;
            // 
            // textBox_cognome
            // 
            this.textBox_cognome.Location = new System.Drawing.Point(12, 74);
            this.textBox_cognome.Name = "textBox_cognome";
            this.textBox_cognome.Size = new System.Drawing.Size(158, 22);
            this.textBox_cognome.TabIndex = 14;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(12, 29);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(158, 22);
            this.textBox_nome.TabIndex = 13;
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(12, 215);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(92, 41);
            this.button_confirm.TabIndex = 23;
            this.button_confirm.Text = "Conferma";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_annulla
            // 
            this.button_annulla.Location = new System.Drawing.Point(118, 215);
            this.button_annulla.Name = "button_annulla";
            this.button_annulla.Size = new System.Drawing.Size(91, 41);
            this.button_annulla.TabIndex = 24;
            this.button_annulla.Text = "Annulla";
            this.button_annulla.UseVisualStyleBackColor = true;
            this.button_annulla.Click += new System.EventHandler(this.button_annulla_Click);
            // 
            // CreazioneUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 293);
            this.Controls.Add(this.button_annulla);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label_DataNascita);
            this.Controls.Add(this.label_ruolo);
            this.Controls.Add(this.label_cognome);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.comboBox_ruolo);
            this.Controls.Add(this.dateTimePicker_DataNascita);
            this.Controls.Add(this.textBox_cognome);
            this.Controls.Add(this.textBox_nome);
            this.Name = "CreazioneUtente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creazione utente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DataNascita;
        private System.Windows.Forms.Label label_ruolo;
        private System.Windows.Forms.Label label_cognome;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.ComboBox comboBox_ruolo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataNascita;
        private System.Windows.Forms.TextBox textBox_cognome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_annulla;
    }
}