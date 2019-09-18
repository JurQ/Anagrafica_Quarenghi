using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrafica_Quarenghi
{
    public class Utente : Persona //Classe figlia con attributi e metodi, della classe Padre (astratta). Derivata anche da IComparer, al fine di utilizzarne il metodo int Compare(Utente,Utente) per ordinare la lista.
    {
        public override string CalcoloID(string Nome, string Cognome, DateTime DataNascita) //Metodo per calcolare lo userID in base a nome, cognome e dataNascita.
        {
            string ID = Nome.Substring(0, 2).ToUpper() + Cognome.Substring(0, 2).ToUpper() + DataNascita.Year.ToString().Substring(2,2);

            return ID;
        }
    }
}
