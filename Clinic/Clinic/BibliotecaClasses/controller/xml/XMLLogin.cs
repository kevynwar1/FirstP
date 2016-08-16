using System;
using System.IO;
using System.Xml;
using BibliotecaClasses.model.basic;

namespace BibliotecaClasses.controller.xml {
    public class XMLLogin {
        XmlDocument xml = new XmlDocument();

        string way = @"C:\Users\h_kev\Desktop\C#\Clinic\Clinic\login.xml";

        private void xmlWay() {
            if (File.Exists(way) == false) {
                XmlNode root = xml.CreateElement("login");
                xml.AppendChild(root);
                xml.Save(way);
            }
        }

        public XMLLogin() {
            xmlWay();
        }

        public void insertLog(BAdministrador bAdm) {
            int pos = 0;
            xml.Load(way);

            XmlNode row             = xml.CreateElement("administrador");
            XmlNode cpf             = xml.CreateElement("cpf");
            XmlNode nome            = xml.CreateElement("nome");
            XmlNode data            = xml.CreateElement("data");
            XmlNode horario         = xml.CreateElement("horario");

            DateTime datetime = DateTime.Now;

            cpf.InnerText       = bAdm.Cpf;
            nome.InnerText      = bAdm.Nome.Trim();
            data.InnerText      = Convert.ToString(datetime.ToString("dd/MM/yyyy"));
            horario.InnerText   = Convert.ToString(datetime.ToString("hh:mm:ss"));

            row.AppendChild(cpf);
            row.AppendChild(nome);
            row.AppendChild(data);
            row.AppendChild(horario);
            xml.SelectSingleNode("/login").AppendChild(row);

            xml.Save(way);
            pos++;
        }
    }
}
