namespace BibliotecaClasses.model.basic {
    public class BClinica {
        private string cnpj;
        private string nome;
        private string descEspec;
        private string endereco;
        private string bairro;
        private string cidade;
        private string uf;
        private string email;
        private string telefone;

        public string Cnpj          {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Nome          {
            get { return nome; }
            set { nome = value; }
        }
        public string DescEspec     {
            get { return descEspec; }
            set { descEspec = value; }
        }
        public string Endereco      {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Bairro        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Uf            {
            get { return uf; }
            set { uf = value; }
        }
        public string Email         {
            get { return email; }
            set { email = value; }
        }
        public string Telefone      {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
