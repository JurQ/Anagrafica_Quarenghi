using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anagrafica_Quarenghi
{
    public partial class CreazioneUtente : Form
    {
        public CreazioneUtente()
        {
            InitializeComponent();
        }

        Utente user = new Utente(); //Creazione dell'utente da riempire con i dati della form
        List<Utente> localList; //creo lista locale da aggiornare con il metodo InzializzaLista

        private void button_confirm_Click(object sender, EventArgs e)
        {
            try //Gestione dell'errore nel caso in cui ci fossero campi vuoti (o null)
            {
                user.Nome = textBox_nome.Text;
                user.Cognome = textBox_cognome.Text;
                user.Ruolo = comboBox_ruolo.SelectedItem.ToString();
                user.DataNascita = dateTimePicker_DataNascita.Value;

                user.User_ID = user.CalcoloID(user.Nome, user.Cognome, user.DataNascita);

                textBox_ID.Text = user.User_ID;
            }
            catch
            {
                MessageBox.Show("I campi devono essere tutti compilati");
            }

            if (user.User_ID != null)
            {
                textBox_nome.Text = null;
                textBox_cognome.Text = null;

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button_annulla_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public Utente GetNuovoUtente()
        {
            return user;
        }

        public void InizializzaLista(List<Utente> l) //Passaggio lista
        {
            localList = l;
        }
    }
}
