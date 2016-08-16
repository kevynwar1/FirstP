using System.Collections.Generic;
using BibliotecaClasses.model.basic;

namespace BibliotecaClasses.model.interfaces {
    public interface IPaciente {
        void insertPaciente (BPaciente bPac);
        void alterPaciente  (BPaciente bPac);
        void deletePaciente (BPaciente bPac);
        List<BPaciente> listPaciente(BPaciente bPac);
    }
}
