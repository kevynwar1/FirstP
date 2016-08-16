using System;
using System.Xml;
using System.IO;
using BibliotecaClasses.model.basic;

namespace BibliotecaClasses.controller.xml {
    public class XMLConsulta {
        XmlDocument xml = new XmlDocument();

        string way = @"C:\Users\h_kev\Desktop\C#\Clinic\Clinic\consulta.xml";

        private void xmlWay() {
            if (File.Exists(way) == false) {
                XmlNode root = xml.CreateElement("consulta");
                xml.AppendChild(root);
                xml.Save(way);
            }
        }

        public XMLConsulta() {
            xmlWay();
        }

        public void insertXML(BConsulta bCons) {
            int pos = 0;
            xml.Load(way);

            XmlNode row             = xml.CreateElement("consulta_paciente");
            XmlNode paciente        = xml.CreateElement("paciente");
            XmlNode tipoConsulta    = xml.CreateElement("tipo_consulta");
            XmlNode data            = xml.CreateElement("data");
            XmlNode horario         = xml.CreateElement("horario");
            XmlNode medico          = xml.CreateElement("medico");

            paciente.InnerText      = bCons.Paciente.Nome;
            tipoConsulta.InnerText  = bCons.TipoConsulta.Nome;
            data.InnerText          = bCons.Data;
            horario.InnerText       = bCons.Horario;
            medico.InnerText        = bCons.Medico.Nome;

            row.AppendChild(paciente);
            row.AppendChild(tipoConsulta);
            row.AppendChild(data);
            row.AppendChild(horario);
            row.AppendChild(medico);
            xml.SelectSingleNode("/consulta").AppendChild(row);

            xml.Save(way);
            pos++;
        }
    }
}
