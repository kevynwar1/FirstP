using BibliotecaClasses.model.basic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaClasses.controller.data
{
    public class DPaciente {
        private Connection conn = new Connection();

        public void insertPaciente(BPaciente bPac) {
            string sql = "INSERT INTO paciente (cpf, convenio, nome, endereco, bairro, telefone, email, data, hora) ";
            sql += "VALUES ('" + bPac.Cpf + "', '" + bPac.Convenio.Cnpj + "', '" + bPac.Nome + "', '" + bPac.Endereco + "', '" + bPac.Bairro + "', '" + bPac.Telefone + "', '" + bPac.Email + "', now(), now())";
            conn.update(sql);
        }
        public void alterPaciente(BPaciente bPac) {
            string sql = "UPDATE paciente ";
            sql += "SET nome = '" + bPac.Nome +"', endereco = '" + bPac.Endereco + "', bairro = '" + bPac.Bairro + "', telefone = " + bPac.Telefone + ", email = '" + bPac.Email + "' ";
            sql += "WHERE cpf = '" + bPac.Cpf + "' ";
        }
        public void deletePaciente(BPaciente bPac) {
            string sql = "DELETE FROM paciente WHERE cpfPaciente = " + bPac.Cpf + " ";
            conn.update(sql);
        }
        public List<BPaciente> listPaciente(BPaciente bPac) {
            List<BPaciente> lPac = new List<BPaciente>();
            try {
                MySqlConnection con = new MySqlConnection("server=localhost; database=clinic; uid=root; password=''");
                string sql = "SELECT cpf, cnpjConv as convenio, nome, endereco, bairro, telefone, email, data, hora FROM paciente";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while(mdr.Read()) {
                    BPaciente bPaci = new BPaciente();
                    bPaci.Cpf = mdr.GetString("cpf");
                    bPaci.Convenio.Cnpj = mdr.GetString("convenio");
                    bPaci.Nome = mdr.GetString("nome");
                    bPaci.Endereco = mdr.GetString("endereco");
                    bPaci.Bairro = mdr.GetString("bairro");
                    bPaci.Telefone = mdr.GetString("telefone");
                    bPaci.Email = mdr.GetString("email");
                    bPaci.Data = mdr.GetString("data");
                    bPaci.Hora = mdr.GetString("hora");
                    lPac.Add(bPaci);
                }
                con.Close();
            } catch (Exception ex) {
                MessageBox.Show("Erro na Consulta do Médico\n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lPac;
        }
    }
}
