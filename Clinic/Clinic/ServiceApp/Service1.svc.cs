using System.Collections.Generic;
using BibliotecaClasses.model.basic;
using BibliotecaClasses.controller.business;

namespace ServiceApp {
    public class Service1 : IService1 {
        public bool insertConsulta (BConsulta bCos) {
            NConsulta nCos = new NConsulta();
            return nCos.insertConsulta(bCos);
        }
        public bool alterConsulta  (BConsulta bCos) {
            NConsulta nCos = new NConsulta();
            return nCos.alterConsulta(bCos);
        }
        public void deleteConsulta (BConsulta bCos) {
            NConsulta nCos = new NConsulta();
            nCos.deleteConsulta(bCos);
        }

        public List<BConsulta>      listConsulta(BConsulta bCos) {
            NConsulta nCos = new NConsulta();
            return nCos.listConsulta(bCos);
        }
        public List<BPaciente>      listPaciente(BPaciente bPac) {
            NPaciente nPac = new NPaciente();
            return nPac.listPaciente(bPac);
        }
        public List<BMedico>        listMedico(BMedico bMed) {
            NMedico nMed = new NMedico();
            return nMed.listMedico(bMed);
        }
        public List<BTipoConsulta>  listTipoConsulta(BTipoConsulta bTip) {
            NTipoConsulta nTip = new NTipoConsulta();
            return nTip.listTipoConsulta(bTip);
        }
        public List<BAdministrador> listAdministrador(BAdministrador bAdm) {
            NAdministrador nAdm = new NAdministrador();
            return nAdm.listAdministrador(bAdm);
        }
    }
}
