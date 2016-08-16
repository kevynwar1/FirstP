using System;
using System.Collections.Generic;
using BibliotecaClasses.model.basic;
using BibliotecaClasses.model.interfaces;
using BibliotecaClasses.controller.data;
using BibliotecaClasses.controller.xml;

namespace BibliotecaClasses.controller.business {
    public class NConsulta : IConsulta {
        DConsulta dCos = new DConsulta();
        XMLConsulta xCos = new XMLConsulta();

        public bool verifyConsulta(BConsulta bCos) {
            if(bCos.Paciente == null) {
                return false;
            } else if(bCos.Data == null || bCos.Data.Equals("")) {
                return false;
            } else if(bCos.Horario == null || bCos.Horario.Equals("")) {
                return false;
            } else if(bCos.Medico == null) {
                return false;
            } else if(bCos.TipoConsulta == null) {
                return false;
            }
            return true;
        }

        public bool insertConsulta (BConsulta bCos) {
            if (verifyConsulta(bCos)) {
                if (dCos.insertConsulta(bCos)) {
                    xCos.insertXML(bCos);
                    return true;
                }
            }
            return false;
        }
        public bool alterConsulta  (BConsulta bCos) {
            if (verifyConsulta(bCos)) {
                if (dCos.alterConsulta(bCos)) {
                    return true;
                }
            }
            return false;
        }
        public void deleteConsulta (BConsulta bCos) {
            if (verifyConsulta(bCos)) {
                dCos.deleteConsulta(bCos);
            }
        }
        public List<BConsulta> listConsulta(BConsulta bCos) {
            return dCos.listConsulta(bCos);
        }
    }
}
