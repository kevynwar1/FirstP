using System.Collections.Generic;
using BibliotecaClasses.model.basic;

namespace BibliotecaClasses.model.interfaces {
    public interface IConsulta {
        bool insertConsulta (BConsulta bCos);
        bool alterConsulta  (BConsulta bCos);
        void deleteConsulta (BConsulta bCos);
        List<BConsulta> listConsulta(BConsulta bCos);
    }
}
