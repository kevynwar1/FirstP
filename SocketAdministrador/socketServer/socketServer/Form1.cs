using System;
using System.Text;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Threading;

namespace socketServer
{
    public partial class Form1 : Form {
        int numPorta = 8000;
        TcpListener tcpListener;
        TcpClient tcpClient;
        NetworkStream networkStream;
        Thread thInteraction;

        public Form1() {
            InitializeComponent();
        }

        private bool connect() {
            bool retorno = false;
            try {
                tcpListener = new TcpListener(System.Net.IPAddress.Any, numPorta);
                tcpListener.Start();
                retorno = true;
            } catch { }
            return retorno;
        }
        private void disconnect() {
            if(thInteraction != null) {
                if(thInteraction.ThreadState == ThreadState.Running) {
                    thInteraction.Abort();
                }
            }
            if(tcpClient != null) {
                tcpClient.Client.Disconnect(true);
            }
            tcpListener.Stop();
            setMsg("## Conexões perdidas", true);
        }

        private void acceptConection() {
            try {
                tcpClient = tcpListener.AcceptTcpClient();
            } catch { }
        }

        private void enviarMsg(string mensagem) {
            if(podeEscrever()) {
                byte[] sendBytes = Encoding.ASCII.GetBytes(mensagem);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
        }

        private bool podeEscrever() {
            if(networkStream == null) {
                return false;
            }
            if(networkStream.CanWrite && tcpClient != null) {
                return true;
            } else {
                return false;
            }
        }

        delegate void delSetMsg(string mensagem, bool burlar);
        private void setMsg(string mensagem, bool burlar) {
            if(this.InvokeRequired) {
                this.BeginInvoke(new delSetMsg(setMsg), mensagem, burlar);
            } else {
                if(burlar == true || podeEscrever() == true) {
                    rtbConversa.Text += "\nEu: "+mensagem;
                }
            }
        }

        delegate void delGetMsg(string mensagem);
        private void getMsg(string mensagem) {
            if (this.InvokeRequired) {
                this.BeginInvoke(new delGetMsg(getMsg), mensagem);
            } else {
                if (podeEscrever() == true) {
                    rtbConversa.Text += "\nAdministrador: "+mensagem;
                }
            }
        }

        private void start() {
            if(connect()) {
                setMsg("## Aguardando conexão...", true);
            }
            thInteraction = new Thread(new ThreadStart(interaction));
            thInteraction.IsBackground = true;
            thInteraction.Priority = ThreadPriority.Highest;
            thInteraction.Name = "thInteration";
            thInteraction.Start();
        }

        private void interaction() {
            try {
                acceptConection();
                setMsg("## Conexão aceita", true);
                do {
                    networkStream = tcpClient.GetStream();
                    if(networkStream.CanRead) {
                        byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(tcpClient.ReceiveBufferSize));
                        string clientData = Encoding.ASCII.GetString(bytes);
                        if(clientData.Replace("\0", "").Trim() != "") {
                            getMsg(clientData);
                        } else {
                            tcpClient = null;
                        }
                    }
                } while (tcpClient != null);
                disconnect();
                start();
            } catch { }
        }

        private void Form1_Load(object sender, EventArgs e) {
            start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            setMsg("## Encerrando conexão com o servidor...", true);
            disconnect();
        }

        private void rtbMensagem_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                string mensagem = rtbMensagem.Text;
                enviarMsg(mensagem);
                setMsg(mensagem, false);
            }
        }

        private void rtbMensagem_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                rtbMensagem.Clear();
            }
        }
    }
}