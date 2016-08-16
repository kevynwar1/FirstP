using BibliotecaClasses.model.basic;
using BibliotecaClasses.model.interfaces;
using BibliotecaClasses.controller.data;
using System.Collections.Generic;
using BibliotecaClasses.controller.xml;

namespace BibliotecaClasses.controller.business {
    public class NAdministrador : IAdministrador {
        DAdministrador dAdm = new DAdministrador();
        XMLLogin xLog = new XMLLogin();

        //public bool verifyAdministrador() {
        //    return true;
        //}

        public void insertAdministrador(BAdministrador bAdm) {
            //if (verifyAdministrador() == true) {
                dAdm.insertAdministrador(bAdm);
            //}
        }
        public void alterAdministrador(BAdministrador bAdm) {
            //if (verifyAdministrador() == true) {
                dAdm.alterAdministrador(bAdm);
            //}
        }
        public void deleteAdministrador(BAdministrador bAdm) {
            //if (verifyAdministrador() == true) {
                dAdm.deleteAdministrador(bAdm);
            //}
        }
        public List<BAdministrador> listAdministrador(BAdministrador bAdm) {
            return dAdm.listAdministrador(bAdm);
        }
    }
}
