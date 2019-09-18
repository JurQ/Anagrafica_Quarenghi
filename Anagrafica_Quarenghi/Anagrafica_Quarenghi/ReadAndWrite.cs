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

            foreach (var item in localList)
            {
                writer.WriteStartElement("User");

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
                writer.WriteString(item.UserID);
                writer.WriteEndElement(); //end UserID

                writer.WriteEndElement(); //end User
            }

            writer.WriteEndElement(); // end Users

            writer.WriteEndDocument();
            writer.Close();
        }

        public void ImportaDaFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Juri\source\repos\Anagrafica_Quarenghi\ListaUtenti.xml");

            XmlNode node = doc.SelectSingleNode("UsersList");

            XmlNodeList prop = node.SelectNodes("User");

            foreach (XmlNode item in prop)
            {
                Utente tmpUser = new Utente();

                tmpUser.Nome = item.SelectSingleNode("Nome").InnerText;
                tmpUser.Cognome = item.SelectSingleNode("Cognome").InnerText;
                tmpUser.DataNascita = DateTime.Parse(item.SelectSingleNode("DataDiNascita").InnerText);
                tmpUser.Ruolo = item.SelectSingleNode("Ruolo").InnerText;
                tmpUser.UserID = item.SelectSingleNode("UserID").InnerText;

                localList.Add(tmpUser);
            }

        }

        public void InizializzaLista(List<Utente> l) //Passaggio lista
        {
            localList = l;
        }
    }
}