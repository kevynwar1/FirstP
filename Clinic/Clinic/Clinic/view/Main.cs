using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Clinic.local;
using Clinic.view;

namespace Clinic {
    public partial class Main : Form {
        Service1Client serv = new Service1Client();

        BAdministrador  bAdm = new BAdministrador();
        BConsulta       bCos = new BConsulta();
        BTipoConsulta   bTip = new BTipoConsulta();

        List<BAdministrador> lAdm = new List<BAdministrador>();
        List<BConsulta>      lCos = new List<BConsulta>();
        List<BMedico>        lMed = new List<BMedico>();
        List<BPaciente>      lPac = new List<BPaciente>();
        List<BTipoConsulta>  lTip = new List<BTipoConsulta>();

        public Main() {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e) {
            horario();
            DateTime data = DateTime.Now;
            int dia = Convert.ToInt16(data.ToString("dd"));
            int mes = Convert.ToInt16(data.ToString("MM"));
            int ano = Convert.ToInt16(data.ToString("yyyy"));
            this.txData.MinDate = new System.DateTime(ano, mes, dia, 0, 0, 0, 0);
        }

        #region List
        private void listPaciente()     {
            cbPaciente.Items.Clear();
            BPaciente bPac = new BPaciente();
            lPac = serv.listPaciente(bPac).ToList();
            foreach (BPaciente bPacie in lPac) {
                cbPaciente.Items.Add(bPacie.Nome);
            }
        }
        private void listMedico()       {
            cbMedico.Items.Clear();
            BMedico bMed = new BMedico();
            lMed = serv.listMedico(bMed).ToList();
            foreach (BMedico bMedic in lMed) {
                cbMedico.Items.Add(bMedic.Nome);
            }
        }
        private void listTipoConsulta() {
            cbTipoConsulta.Items.Clear();
            BTipoConsulta bTip = new BTipoConsulta();
            lTip = serv.listTipoConsulta(bTip).ToList();
            foreach (BTipoConsulta bTipoC in lTip) {
                cbTipoConsulta.Items.Add(bTipoC.Nome);
            }
        }
        #endregion
        #region Consulta
        private void listarConsulta() {
            string search = txSearch.Text.Trim();
            if(cbFiltro.SelectedIndex == 0) {
                bCos.Horario = search;
            } else if(cbFiltro.SelectedIndex == 1) {
                bCos.Medico.Nome = search;
            } else if(cbFiltro.SelectedIndex == 2) {
                bCos.Paciente.Nome = search;
            }

            if (checkHoje.Checked == true) {
                DateTime data = DateTime.Now;
                bCos.Data = data.ToString("dd/MM/yyyy");
            } else { bCos.Data = null; }

            listView.Items.Clear();
            listView.Columns.Clear();

            listView.View = View.Details;
            listView.Columns.Add("Paciente", 100);
            listView.Columns.Add("Médico", 100);
            listView.Columns.Add("Data", 75);
            listView.Columns.Add("Horário", 60);
            listView.Columns.Add("Consulta", 80);

            try {
                lCos = serv.listConsulta(bCos).ToList();
            } catch(Exception ex) {
                MessageBox.Show("Erro nas listagem das consultas\n"+ex.Message);
            }
            foreach (BConsulta bCons in lCos) {
                ListViewItem lvItem = new ListViewItem(bCons.Paciente.Nome);
                lvItem.SubItems.Add(bCons.Medico.Nome);
                lvItem.SubItems.Add(bCons.Data);
                lvItem.SubItems.Add(bCons.Horario);
                lvItem.SubItems.Add(bCons.TipoConsulta.Nome);
                listView.Items.Add(lvItem);
            }
        }
        private void listarTipoConsulta() {
            bTip.Nome = txSearch.Text;

            listView.Items.Clear();
            listView.Columns.Clear();

            listView.View = View.Details;
            listView.Columns.Add("Tipo Consulta", 110);
            listView.Columns.Add("Descrição", 310);

            lTip = serv.listTipoConsulta(bTip).ToList();
            foreach (BTipoConsulta bTipo in lTip) {
                ListViewItem lvItem = new ListViewItem(bTipo.Nome);
                lvItem.SubItems.Add(bTipo.Descricao);
                listView.Items.Add(lvItem);
            }
        }
        private void listView_MouseClick(object sender, MouseEventArgs e) {
            splitUpdate.Visible = true;

            listPaciente();
            listMedico();
            listTipoConsulta();

            cbPaciente.Enabled      = false;
            cbTipoConsulta.Enabled  = false;

            bCos = lCos.ElementAt(listView.FocusedItem.Index);

            cbPaciente.SelectedItem     = bCos.Paciente.Nome;
            txData.Text                 = bCos.Data;
            cbHorario.SelectedItem      = bCos.Horario;
            cbMedico.SelectedItem       = bCos.Medico.Nome;
            cbTipoConsulta.SelectedItem = bCos.TipoConsulta.Nome;

            btMarcarConsulta.Visible = false;
            btRemarcar.Visible       = true;
            btSuspender.Visible      = true;
        }

        private void btMarcarConsulta_Click (object sender, EventArgs e) {
            try {
                bCos.Paciente     = lPac.ElementAt(cbPaciente.SelectedIndex);
                bCos.Data         = txData.Text;
                bCos.Horario      = cbHorario.SelectedItem.ToString();
                bCos.Medico       = lMed.ElementAt(cbMedico.SelectedIndex);
                bCos.TipoConsulta = lTip.ElementAt(cbTipoConsulta.SelectedIndex);

                if (serv.insertConsulta(bCos)) {
                    listarConsulta();
                    btInserir_Click(sender, e);
                } else {
                    MessageBox.Show("A marcação da consulta não poderá ser realizada, pois o médico escolhido está associado a uma consulta no mesmo dia e hora", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch(Exception ex) {
                MessageBox.Show("Erro na inserção da consulta\n"+ex.Message);
            }
        }
        private void btRemarcar_Click       (object sender, EventArgs e) {
            bCos = lCos.ElementAt(listView.FocusedItem.Index);
            bCos.Data = txData.Text;
            bCos.Horario = cbHorario.SelectedItem.ToString();
            bCos.Medico = lMed.ElementAt(cbMedico.SelectedIndex);

            DialogResult dialogResult = MessageBox.Show("Clinic\n"+bAdm.Nome+" tem certeza que deseja remarcar a consulta de "+bCos.Paciente.Nome+" ?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogResult == DialogResult.Yes) {
                if(serv.alterConsulta(bCos)) {
                    listarConsulta();
                    splitUpdate.Visible = false;
                } else {
                    MessageBox.Show(bAdm.Nome + "\nVocê não pode remarcar uma consulta na mesma data e horário \nonde o médico tem outra consulta marcada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btSuspender_Click      (object sender, EventArgs e) {
            bCos = lCos.ElementAt(listView.FocusedItem.Index);
            DialogResult dialogResult = MessageBox.Show("Clinic\n"+bAdm.Nome+" tem certeza que deseja suspender a consulta de "+bCos.Paciente.Nome+" ?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) {
                serv.deleteConsulta(bCos);
                listarConsulta();
                splitUpdate.Visible = false;
            }
        }
        #endregion
        #region Events
        private void horario() {
            cbHorario.Items.Clear();
            cbHorario.Items.Add("06:00");
            cbHorario.Items.Add("06:15");
            cbHorario.Items.Add("06:30");
            cbHorario.Items.Add("06:45");
            cbHorario.Items.Add("07:00");
            cbHorario.Items.Add("07:15");
            cbHorario.Items.Add("07:30");
            cbHorario.Items.Add("07:45");
            cbHorario.Items.Add("08:00");
            cbHorario.Items.Add("08:15");
            cbHorario.Items.Add("08:30");
            cbHorario.Items.Add("08:45");
            cbHorario.Items.Add("09:00");
            cbHorario.Items.Add("09:15");
            cbHorario.Items.Add("09:30");
            cbHorario.Items.Add("09:45");
            cbHorario.Items.Add("10:00");
            cbHorario.Items.Add("10:15");
            cbHorario.Items.Add("10:30");
            cbHorario.Items.Add("10:45");
            cbHorario.Items.Add("11:00");
            cbHorario.Items.Add("11:15");
            cbHorario.Items.Add("11:30");
            cbHorario.Items.Add("11:45");
            cbHorario.Items.Add("12:00");

            cbHorario.Items.Add("14:00");
            cbHorario.Items.Add("14:15");
            cbHorario.Items.Add("14:30");
            cbHorario.Items.Add("14:45");
            cbHorario.Items.Add("15:00");
            cbHorario.Items.Add("15:15");
            cbHorario.Items.Add("15:30");
            cbHorario.Items.Add("15:45");
        }
        private void filtro() {
            cbFiltro.Items.Clear();
            cbFiltro.Items.Add("Horário");
            cbFiltro.Items.Add("Médico");
            cbFiltro.Items.Add("Paciente");
            cbFiltro.SelectedItem = "Horário";
        }

        private void clear() {
            txCpf.Text = "";
            txSenha.Text = "Senha";
            txData.Text = "";
        }

        private void btEntrar_Click(object sender, EventArgs e) {
            int i = 0;
            pbProgress.Increment(-100);
            bAdm.Cpf    = txCpf.Text;
            bAdm.Senha  = txSenha.Text;

            lAdm = serv.listAdministrador(bAdm).ToList();
            foreach (BAdministrador bAdmi in lAdm) {
                ++i; lbNome.Text = "Olá, "+ bAdmi.Nome;
            }

            if(i == 1) { login(); }
            else { MessageBox.Show("CPF e/ou Senha incorreto(s)\nTente novamente...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            pbProgress.Increment(100);
        }
        private void login()  {
            lbCpf.Visible       = false;
            lbSenha.Visible     = false;
            txCpf.Visible       = false;
            txSenha.Visible     = false;
            btEntrar.Visible    = false;
            txSearch.Visible    = true;
            txSearch.Focus();
            pbSearch.Visible    = true;
            lbSearch.Visible    = true;
            pnAdm.Visible       = true;
            cbFiltro.Visible    = true;
            filtro();
        }
        private void logout() {
            clear();
            lbCpf.Visible       = true;
            lbSenha.Visible     = true;
            txCpf.Visible       = true;
            txSenha.Visible     = true;
            btEntrar.Visible    = true;
            txSearch.Visible    = false;
            lbSearch.Visible    = false;
            pbSearch.Visible    = false;
            pnAdm.Visible       = false;
            cbFiltro.Visible    = false;
            txCpf.Focus();
            pbProgress.Increment(-100);
            Chat chat = new Chat();
            chat.Dispose();
        }

        private void txSenha_KeyUp (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btEntrar_Click(sender, e);
            }
        }
        private void txCpf_KeyUp   (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btEntrar_Click(sender, e);
            }
        }

        private void btMenu_Click(object sender, EventArgs e) {
            if(pnMenu.Visible == true) {
                pnMenu.Visible = false;
            } else {
                pnMenu.Visible = true;
            }
        }
        private void btMenu_MouseHover(object sender, EventArgs e) {
            if (pnMenu.Visible == true) {
                lbMenu.Text = "Esconder Menu";
            } else {
                lbMenu.Text = "Exibir Menu";
            }
        }
        private void btMenu_MouseLeave(object sender, EventArgs e) {
            lbMenu.Text = "Menu";
        }

        private void btConsulta_Click (object sender, EventArgs e) {
            listarConsulta();
            checkHoje.Visible       = true;
            btInserir.Visible       = true;
            splitConsulta.Visible   = true;
        }

        private void txSearch_KeyUp(object sender, KeyEventArgs e) {
            listarConsulta();
            if (e.KeyCode == Keys.Enter) {
                pbSearch_Click(sender, e);
            }
        }
        private void txSearch_Enter(object sender, EventArgs e) {
            splitUpdate.Visible = false;
        }
        private void lbSearch_Click(object sender, EventArgs e) {
            txSearch.Focus();
        }
        private void pbSearch_Click(object sender, EventArgs e) {
            string search = txSearch.Text;
            listarConsulta();
        }
        private void btInserir_Click(object sender, EventArgs e) {
            if (splitUpdate.Visible == true) {
                splitUpdate.Visible = false;
                btInserir.Text = "Nova Consulta";
            } else {
                clear();
                splitUpdate.Visible = true;
                listPaciente();
                listMedico();
                listTipoConsulta();

                cbPaciente.Enabled = true;
                cbTipoConsulta.Enabled = true;

                btSuspender.Visible = false;
                btRemarcar.Visible = false;
                btMarcarConsulta.Visible = true;
                splitUpdate.Visible = true;
                btInserir.Text = "Fechar Aba";
            }
        }

        private void btSair_Click(object sender, EventArgs e) {
            logout();
        }

        private void btTipoConsulta_Click(object sender, EventArgs e) {
            checkHoje.Visible = false;
            btInserir.Visible = false;
            listarTipoConsulta();
            splitConsulta.Visible = true;
        }

        private void checkHoje_Click(object sender, EventArgs e) {
            listarConsulta();
        }

        private void btChat_Click(object sender, EventArgs e) {
            Chat chat = new Chat();
            chat.Show();
        }
        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e) {
            
        }
    }
}
