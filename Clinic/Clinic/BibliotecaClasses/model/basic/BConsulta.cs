namespace BibliotecaClasses.model.basic {
    public class BConsulta {
        private int codConsulta;
        private BPaciente paciente;
        private BTipoConsulta tipoConsulta;
        private string data;
        private string horario;
        private BMedico medico;
        
        public BConsulta() {
            this.Paciente       = new BPaciente();
            this.Medico         = new BMedico();
            this.TipoConsulta   = new BTipoConsulta();
        }

        public int CodConsulta              {
            get { return codConsulta; }
            set { codConsulta = value; }
        }
        public BPaciente Paciente           {
            get { return paciente; }
            set { paciente = value; }
        }
        public BTipoConsulta TipoConsulta   {
            get { return tipoConsulta; }
            set { tipoConsulta = value; }
        }
        public string Data                  {
            get { return data; }
            set { data = value; }
        }
        public string Horario               {
            get { return horario; }
            set { horario = value; }
        }
        public BMedico Medico               {
            get { return medico; }
            set { medico = value; }
        }
    }
}
