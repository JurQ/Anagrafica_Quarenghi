using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrafica_Quarenghi
{
    public abstract class Persona //Classe astratta da cui ereditano le altre classi. Non può essere istanziata e le sottoclassi dovranno avere stessi attributi e stessi metodi.
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string Ruolo { get; set; }
        public string User_ID { get; set; }

        abstract public string CalcoloID(string Nome, string Cognome, DateTime DataNascita);
    }
}
