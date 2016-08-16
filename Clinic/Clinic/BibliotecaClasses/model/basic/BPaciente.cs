namespace BibliotecaClasses.model.basic {
    public class BPaciente {
        private string cpf;
        private BConvenio convenio;
        private string nome;
        private string endereco;
        private string bairro;
        private string telefone;
        private string email;
        private string data;
        private string hora;

        public BPaciente() {
            this.Convenio = new BConvenio();
        }

        public string Cpf           {
            get { return cpf; }
            set { cpf = value; }
        }
        public BConvenio Convenio   {
            get { return convenio; }
            set { convenio = value; }
        }
        public string Nome          {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco      {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Bairro        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Telefone      {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email         {
            get { return email; }
            set { email = value; }
        }
        public string Data          {
            get { return data; }
            set { data = value; }
        }
        public string Hora          {
            get { return hora; }
            set { hora = value; }
        }
    }
}
