namespace BibliotecaClasses.model.basic {
    public class BConvenio {
        private string cnpj;
        private string nome;
        private string endereco;
        private string bairro;
        private string cidade;
        private string email;
        private string descricao;
        private string data;
        private string hora;

        public string Cnpj      {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Nome      {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco  {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Bairro    {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade    {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Email     {
            get { return email; }
            set { email = value; }
        }
        public string Descricao {
            get { return descricao; }
            set { descricao = value; }
        }
        public string Data      {
            get { return data; }
            set { data = value; }
        }
        public string Hora      {
            get { return hora; }
            set { hora = value; }
        }
    }
}
