using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Anagrafica_Quarenghi
{
    class ReadAndWrite
    {
        List<Utente> localList;

        public void EsportaSuFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            settings.NewLineOnAttributes = true;
            XmlWriter writer = XmlWriter.Create(@"C:\Users\Juri\source\repos\Anagrafica_Quarenghi\ListaUtenti.xml", settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("UsersList");

            int count = 1;

            foreach (var item in localList)
            {
                writer.WriteStartElement("User" + count.ToString());

                writer.WriteStartElement("Nome");
                writer.WriteString(item.Nome);
                writer.WriteEndElement(); //end Nome

                writer.WriteStartElement("Cognome");
                writer.WriteString(item.Cognome);
                writer.WriteEndElement(); //end Cognome

                writer.WriteStartElement("DataDiNascita");
                writer.WriteString(item.DataNascita.ToShortDateString());
                writer.WriteEndElement(); //end DataDiNascita

                writer.WriteStartElement("Ruolo");
                writer.WriteString(item.Ruolo);
                writer.WriteEndElement(); //end Ruolo

                writer.WriteStartElement("UserID");
                writer.WriteString(item.User_ID);
                writer.WriteEndElement(); //end UserID

                writer.WriteEndElement(); //end User

                count++;
            }

            writer.WriteEndElement(); // end Users

            writer.WriteEndDocument();
            writer.Close();
        }

        public void ImportaDaFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Juri\source\repos\Anagrafica_Quarenghi\ListaUtenti.xml");

            int count = 1;

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                Utente tmpUser = new Utente();

                XmlNode elemento = doc.DocumentElement.SelectSingleNode("/UsersList/User" + count.ToString() + "/Nome");
                tmpUser.Nome = elemento.InnerText;

                elemento = doc.DocumentElement.SelectSingleNode("/UsersList/User" + count.ToString() + "/Cognome");
                tmpUser.Cognome = elemento.InnerText;

                elemento = doc.DocumentElement.SelectSingleNode("/UsersList/User" + count.ToString() + "/DataDiNascita");
                tmpUser.DataNascita = DateTime.Parse(elemento.InnerText);

                elemento = doc.DocumentElement.SelectSingleNode("/UsersList/User" + count.ToString() + "/Ruolo");
                tmpUser.Ruolo = elemento.InnerText;

                elemento = doc.DocumentElement.SelectSingleNode("/UsersList/User" + count.ToString() + "/UserID");
                tmpUser.User_ID = elemento.InnerText;

                localList.Add(tmpUser);

                count++;
            }
        }

        public void InizializzaLista(List<Utente> l) //Passaggio lista
        {
            localList = l;
        }
    }
}