using BibliotecaClasses.model.basic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BibliotecaClasses.controller.data {
    public class DMedico {
        private Connection conn = new Connection();

        public void insertMedico(BMedico bMed) {
            string sql = "INSERT INTO medico (crm, dataInscricao, nome, cpf, endereco, bairro, cidade, uf, clinica, nomeUser, senhaUser) ";
                   sql += "VALUES ('" + bMed.Crm + "', '" + bMed.DataInscricao + "', '" + bMed.Nome + "', '" + bMed.Cpf + "', '" + bMed.Endereco + "', '" + bMed.Bairro + "', '" + bMed.Cidade + "', '" + bMed.Uf + "', '" + bMed.Clinica.Cnpj + "', '" + bMed.NomeUser + "', '" + bMed.SenhaUser + "')";
            conn.update(sql);
        }
        public void alterMedico(BMedico bMed) {
            string sql = "UPDATE medico ";
                   sql += "SET nome = '" + bMed.Nome + "', endereco = '" + bMed.Endereco + "', bairro = '" + bMed.Bairro + "', cidade = '" + bMed.Cidade + "', uf = '" + bMed.Uf + "' ";
                   sql += "WHERE crm = '" + bMed.Crm + "' ";
            conn.update(sql);
        }
        public void deleteMedico(BMedico bMed){
            string sql = "DELETE FROM medico WHERE crm = '" + bMed.Crm + "' ";
            conn.update(sql);
        }
        public List<BMedico> listMedico(BMedico bMed) {
            List<BMedico> lMed = new List<BMedico>();
            try {
                MySqlConnection con = new MySqlConnection("server=localhost; database=clinic; uid=root; password=''");
                string sql = "SELECT crm, dataInscricao, nome, cpf, endereco, bairro, cidade, uf, clinica, nomeUser, senhaUser ";
                       sql += "FROM medico";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read()) {
                    BMedico bMedi = new BMedico();
                    bMedi.Crm           = mdr.GetString("crm");
                    bMedi.DataInscricao = mdr.GetString("dataInscricao");
                    bMedi.Nome          = mdr.GetString("nome");
                    bMedi.Cpf           = mdr.GetString("cpf");
                    bMedi.Endereco      = mdr.GetString("endereco");
                    bMedi.Bairro        = mdr.GetString("bairro");
                    bMedi.Cidade        = mdr.GetString("cidade");
                    bMedi.Uf            = mdr.GetString("uf");
                    bMedi.Clinica.Cnpj  = mdr.GetString("clinica");
                    bMedi.NomeUser      = mdr.GetString("nomeUser");
                    bMedi.SenhaUser     = mdr.GetString("senhaUser");
                    lMed.Add(bMedi);
                }
                con.Close();
            } catch (Exception ex) {
                throw new Exception("Erro na Consulta do Médico\n" + ex.Message);
            }
            return lMed;
        }
    }
}
