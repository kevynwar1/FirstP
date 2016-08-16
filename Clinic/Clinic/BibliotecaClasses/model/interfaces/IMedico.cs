using System.Collections.Generic;
using BibliotecaClasses.model.basic;

namespace BibliotecaClasses.model.interfaces {
    public interface IMedico {
        void insertMedico (BMedico bMed);
        void alterMedico  (BMedico bMed);
        void deleteMedico (BMedico bMed);
        List<BMedico> listMedico(BMedico bMed);
    }
}
