namespace BibliotecaClasses.model.basic {
    public class BMedico {
        private string crm;
        private string dataInscricao;
        private string nome;
        private string cpf;
        private string endereco;
        private string bairro;
        private string cidade;
        private string uf;
        private BClinica clinica;
        private string nomeUser;
        private string senhaUser;

        public BMedico() {
            this.clinica = new BClinica();
        }

        public string Crm           {
            get { return crm; }
            set { crm = value; }
        }
        public string DataInscricao {
            get { return dataInscricao; }
            set { dataInscricao = value; }
        }
        public string Nome          {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf           {
            get { return cpf; }
            set { cpf = value; }
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
        public BClinica Clinica     {
            get { return clinica; }
            set { clinica = value; }
        }
        public string NomeUser      {
            get { return nomeUser; }
            set { nomeUser = value; }
        }
        public string SenhaUser     {
            get { return senhaUser; }
            set { senhaUser = value; }
        }
    }
}
