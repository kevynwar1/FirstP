using BibliotecaClasses.controller.data;
using BibliotecaClasses.model.basic;
using BibliotecaClasses.model.interfaces;
using System;
using System.Collections.Generic;

namespace BibliotecaClasses.controller.business {
    public class NMedico : IMedico {
        BMedico bMed = new BMedico();
        DMedico dMed = new DMedico();

        //public bool verifyMedico() {
        //    return true;
        //}

        public void insertMedico(BMedico bMed) {
            throw new NotImplementedException();
        }
        public void alterMedico(BMedico bMed) {
            throw new NotImplementedException();
        }
        public void deleteMedico(BMedico bMed) {
            throw new NotImplementedException();
        }
        public List<BMedico> listMedico(BMedico bMed) {
            return dMed.listMedico(bMed);
        }
    }
}
