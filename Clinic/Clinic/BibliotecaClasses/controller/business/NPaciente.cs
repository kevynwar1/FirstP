using System;
using BibliotecaClasses.model.basic;
using BibliotecaClasses.model.interfaces;
using BibliotecaClasses.controller.data;
using System.Collections.Generic;

namespace BibliotecaClasses.controller.business {
    public class NPaciente : IPaciente {
        BPaciente bPac = new BPaciente();
        DPaciente dPac = new DPaciente();

        public bool verifyPaciente() {
            return true;
        }

        public void insertPaciente(BPaciente bPac) {
            throw new NotImplementedException();
        }
        public void alterPaciente(BPaciente bPac) {
            throw new NotImplementedException();
        }
        public void deletePaciente(BPaciente bPac) {
            throw new NotImplementedException();
        }
        public List<BPaciente> listPaciente(BPaciente bPac) {
            return dPac.listPaciente(bPac);
        }
    }
}
