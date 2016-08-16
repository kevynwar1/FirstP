using System.Collections.Generic;
using BibliotecaClasses.model.basic;

namespace BibliotecaClasses.model.interfaces {
    public interface ITipoConsulta {
        List<BTipoConsulta> listTipoConsulta(BTipoConsulta bTip);
    }
}
