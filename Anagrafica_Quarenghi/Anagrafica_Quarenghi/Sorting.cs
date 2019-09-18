using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrafica_Quarenghi
{
    public class Sorting : Utente, IComparer<Utente>
    {
        int tipoSort = 1; // 1 = cognome, 2 = ruolo

        public void SetTipoSort(int t) //Settiamo un indicatore per il sort della lista usato in Compare().
        {
            tipoSort = t;
        }

        public int Compare(Utente u1, Utente u2) //Metodo della classe ICompare, confronta due campi della lista su oggetti di tipo Utente. Non modificare nome o metodo o smette di funzionare.
        {
            if (tipoSort == 1)
                return u1.Cognome.CompareTo(u2.Cognome);
            else
                return u1.Ruolo.CompareTo(u2.Ruolo);
        }
    }
}
