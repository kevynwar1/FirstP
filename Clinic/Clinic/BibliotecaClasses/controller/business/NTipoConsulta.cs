using BibliotecaClasses.controller.data;
using BibliotecaClasses.model.basic;
using BibliotecaClasses.model.interfaces;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BibliotecaClasses.controller.business {
    public class NTipoConsulta : ITipoConsulta {
        BTipoConsulta bTipo = new BTipoConsulta();
        DTipoConsulta dTip = new DTipoConsulta();

        public bool verifyTipo() {
            Regex regex = new Regex("[A-Z][a-zA-Z]*$");
            Match match = regex.Match(bTipo.Nome);

            if (bTipo.Nome.Equals("") || bTipo.Nome == null) {
                return false;
            } else if(!match.Success) {
                return false;
            } else if (bTipo.Descricao.Length > 140) {
                return false;
            }
            return true;
        }

        public List<BTipoConsulta> listTipoConsulta(BTipoConsulta bTip) {
            return dTip.listTipoConsulta(bTip);
        }
    }
}
