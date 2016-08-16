using BibliotecaClasses.model.basic;
using System.Collections.Generic;

namespace BibliotecaClasses.model.interfaces {
    public interface IAdministrador {
        void insertAdministrador (BAdministrador bAdm);
        void alterAdministrador  (BAdministrador bAdm);
        void deleteAdministrador (BAdministrador bAdm);
        List<BAdministrador> listAdministrador  (BAdministrador bAdm);
    }
}
