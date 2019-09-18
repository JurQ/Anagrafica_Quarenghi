using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Anagrafica_Quarenghi
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

            ReadAndWrite p = new ReadAndWrite();

            p.InizializzaLista(ListaUtenti);

            p.ImportaDaFile();

            RefreshList();
        }
    
        List<Utente> ListaUtenti = new List<Utente>(); //Creazione della lista utenti. Dichiarata fuori dagli eventi o metodi, così che sia visibile a tutto il Main()

        private void button_CreaUtente_Click(object sender, EventArgs e) 
        {
            CreazioneUtente form2 = new CreazioneUtente();

            //form2.init(ListaUtenti);

            if (form2.ShowDialog() == DialogResult.OK)
            {
                Utente nuovoUtente; //l'oggetto in questione non viene creato con "new", ma viene creata solo una variabile di tipo Utente che riceverà l'oggetto user restituito dal metodo GetNuovoUtente() del form CreazioneUtente (Form2)
                nuovoUtente = form2.GetNuovoUtente();

                if (nuovoUtente != null)
                {
                    ListaUtenti.Add(nuovoUtente); //aggiungo il nuovoUtente alla lista
                    RefreshList();
                }
            } //Creato un oggetto CreazioneUtente(Form2) per far aprire una finestra di dialogo (page2.ShowDialog()) riferita alla creazione dell'utente. Se il risultato della chiusura della dialog box è positivo (OK), tramite il metodo GetNuovoUtente, passerò ed aggiungerò lo "user" creato nella CreazioneUtente (Form2).
             
        }

        private void comboBox_sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorting s = new Sorting(); //Creo un utente per utilizzare successivamente il metodo della Classe

            if (comboBox_sorting.SelectedItem.ToString() == "Per cognome") 
            {
                s.SetTipoSort(1);
            }
            else if(comboBox_sorting.SelectedItem.ToString() == "Per ruolo")
            {
                s.SetTipoSort(2);
            }

            ListaUtenti.Sort(s); //Creiamo un utente solo perchè abbaimo inserito i metodi di sorting nella classe Utente al posto di farne una apposita (DA IMPLEMENTARE SUCCESSIVAMENTE)!
            RefreshList();
        }

        private void button_salva_Click(object sender, EventArgs e)
        {
            ReadAndWrite esporta = new ReadAndWrite();

            esporta.InizializzaLista(ListaUtenti); //Sincronizza la lista

            try
            {
                esporta.EsportaSuFile();
            }
            catch (Exception)
            {
                MessageBox.Show("Il file potrebbe essere già esistente");
            }
        }

        private void RefreshList() //Metodo per refreshare la lista
        {
            listBox_ListaUtenti.Items.Clear();

            foreach (var item in ListaUtenti) //metodo veloce per riempire la ListBox
            {
                string s = item.UserID + " - " + item.Nome + " " + item.Cognome + " - " + item.Ruolo;
                listBox_ListaUtenti.Items.Add(s);
            }
        }
    }
}
