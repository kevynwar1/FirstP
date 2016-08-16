using BibliotecaClasses.model.basic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BibliotecaClasses.controller.data {
    public class DTipoConsulta {
        BTipoConsulta bTip = new BTipoConsulta();

        public List<BTipoConsulta> listTipoConsulta(BTipoConsulta bTip) {
            List<BTipoConsulta> lTip = new List<BTipoConsulta>();
            try {
                MySqlConnection con = new MySqlConnection("server=localhost; database=clinic; uid=root; password=''");
                string sql = "SELECT codTipoCons, nome, descricao FROM tipoconsulta";
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read()) {
                    BTipoConsulta bTipo = new BTipoConsulta();
                    bTipo.CodTipoCons = mdr.GetInt16("codTipoCons");
                    bTipo.Nome = mdr.GetString("nome");
                    bTipo.Descricao = mdr.GetString("descricao");
                    lTip.Add(bTipo);
                }
                con.Close();
            } catch (Exception ex) {
                throw new Exception("Erro na listagem do Tipo de Consulta\n" + ex.Message);
            }
            return lTip;
        }
    }
}
