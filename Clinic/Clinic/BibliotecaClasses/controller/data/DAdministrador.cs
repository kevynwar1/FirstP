using BibliotecaClasses.model.basic;
using BibliotecaClasses.model.interfaces;
using BibliotecaClasses.controller.xml;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaClasses.controller.data {
    public class DAdministrador : IAdministrador {
        private Connection conn = new Connection();
        private XMLLogin xLog = new XMLLogin();

        public void insertAdministrador(BAdministrador bAdm) {
            string sql = "INSERT INTO administrador (cpfAdmin, senhaAdm, nomeAdm) ";
            sql += "VALUES ('" + bAdm.Cpf + "', '" + bAdm.Senha + "', '" + bAdm.Nome + "')";
            conn.update(sql);
        }
        public void alterAdministrador(BAdministrador bAdm) {
            string sql = "UPDATE administrador ";
            sql += "SET (senhaAdm = '" + bAdm.Senha + "', nomeAdm = '" + bAdm.Nome + "')";
            sql += "WHERE cpfAdmin = '" + bAdm.Cpf + "' ";
            conn.update(sql);
        }
        public void deleteAdministrador(BAdministrador bAdm) {
            string sql = "DELETE FROM administrador WHERE cpfAdmin = '" + bAdm.Cpf + "' ";
            conn.update(sql);
        }
        public List<BAdministrador> listAdministrador(BAdministrador bAdm) {
            List<BAdministrador> lAdm = new List<BAdministrador>();
            try {
                MySqlConnection con = new MySqlConnection("server=localhost; database=clinic; uid=root; password=''");
                string sql = "SELECT cpfAdmin, senhaAdm, nomeAdm FROM administrador ";
                       sql += "WHERE cpfAdmin = '"+bAdm.Cpf+"' ";
                if (bAdm.Senha.Length > 0) {
                    sql += "AND senhaAdm = '"+bAdm.Senha+"' ";
                }
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                if(mdr.Read()) {
                    bAdm.Cpf    = mdr.GetString(mdr.GetOrdinal("cpfAdmin"));
                    bAdm.Senha  = mdr.GetString(mdr.GetOrdinal("senhaAdm"));
                    bAdm.Nome   = mdr.GetString(mdr.GetOrdinal("nomeAdm"));
                    xLog.insertLog(bAdm);
                    lAdm.Add(bAdm);
                }
                con.Close();
            } catch (Exception ex) {
                MessageBox.Show("Erro na Consulta do Administrador\n" + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lAdm;
        }
    }
}
