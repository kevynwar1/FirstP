using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Clinic.local;

namespace Clinic.view {
    public partial class Chat : Form {
        TcpClient tcpClient;
        NetworkStream networkStream;
        Thread thInteraction;

        public Chat() {
            InitializeComponent();
            administrador();
        }

        public void administrador() {
            lbName.Text = "<Administrador>";
        }

        private void connect() {
            try {
                tcpClient = new TcpClient();
                tcpClient.Connect("127.0.0.1", 8000); // IP Local, Porta // Bind //
                setMessage("## Conexão Estabelecida");
            } catch {
                setMessage("## Conexão mal-sucessida");
            }
        }
        private void disconnect() {
            if(thInteraction != null) {
                if(thInteraction.ThreadState == ThreadState.Running) {
                    thInteraction.Abort();
                }
            }
            tcpClient.Close();
        }

        private void enviarMsg(string mensagem) {
            if(networkStream.CanWrite) {
                byte[] sendBytes = Encoding.ASCII.GetBytes(mensagem);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
        }

        delegate void delSetMsg(string mensagem);
        private void setMessage(string mensagem) {
            if(this.InvokeRequired) {
                this.BeginInvoke(new delSetMsg(setMessage), mensagem);
            } else {
                rtbConversa.Text += "\nEu: " + mensagem;
            }
        }
        delegate void delGetMsg(string mensagem);
        private void getMessage(string mensagem) {
            if(this.InvokeRequired) {
                this.BeginInvoke(new delGetMsg(getMessage), mensagem);
            } else {
                rtbConversa.Text += "\nAtendente: " + mensagem;
            }
        }

        private void rtbMensagem_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                if(networkStream.CanWrite) {
                    string mensagem = rtbMensagem.Text;
                    enviarMsg(mensagem);
                    setMessage(mensagem);
                } else {
                    setMessage("## Não é possível enviar dados de stream");
                    disconnect();
                }
            }
        }

        private void rtbMensagem_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                rtbMensagem.Clear();
            }
        }

        private void interaction() {
            try {
                do {
                    networkStream = tcpClient.GetStream();
                    if (networkStream.CanRead) {
                        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(tcpClient.ReceiveBufferSize));
                        string returnData = Encoding.ASCII.GetString(bytes);
                        getMessage(returnData);
                    } else {
                        setMessage("## Não é possível ler dados para este stream...");
                        disconnect();
                    }
                } while(tcpClient.Connected);
            } catch { }
        }

        private void Chat_Load(object sender, EventArgs e) {
            connect();
            thInteraction = new Thread(new ThreadStart(interaction));
            thInteraction.IsBackground = true;
            thInteraction.Priority = ThreadPriority.Highest;
            thInteraction.Name = "thInteraction";
            thInteraction.Start();
        }
        private void Chat_FormClosing(object sender, FormClosingEventArgs e) {
            disconnect();
        }
    }
}
