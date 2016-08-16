namespace BibliotecaClasses.model.basic {
    public class BAdministrador {
        private string cpf;
        private string senha;
        private string nome;

        public string Cpf   {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Senha {
            get { return senha; }
            set { senha = value; }
        }
        public string Nome  {
            get { return nome; }
            set { nome = value; }
        }
    }
}
