using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasses.model.basic {
    public class BTipoConsulta {
        private int codTipoCons;
        private string nome;
        private string descricao;

        public int CodTipoCons  {
            get { return codTipoCons; }
            set { codTipoCons = value; }
        }
        public string Nome      {
            get { return nome; }
            set { nome = value; }
        }
        public string Descricao {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
