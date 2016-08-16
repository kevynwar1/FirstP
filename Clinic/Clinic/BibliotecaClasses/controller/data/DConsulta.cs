using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using BibliotecaClasses.model.basic;

namespace BibliotecaClasses.controller.data {
    public class DConsulta {
        public Connection connect = new Connection();
        String data = DateTime.Now.ToString("dd/MM/yyyy");

        private bool verifyConsulta(BConsulta bCos) {
            string consult = "SELECT codConsulta, paciente, tipoConsulta, dataConsulta, horario, medico ";
                   consult += "FROM consulta ";
                   consult += "WHERE dataConsulta = '" + bCos.Data + "' ";
                   consult += "AND horario = '" + bCos.Horario + "' ";
                   consult += "AND medico = '" + bCos.Medico.Crm + "' ";
            try {
                MySqlConnection con = new MySqlConnection("server=localhost; database=clinic; uid=root; password=''");
                con.Open();
                MySqlCommand mcd = new MySqlCommand(consult, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                if (mdr.Read()) {
                    return false;
                } else {
                    return true;
                }
            } catch (Exception ex) {
                throw new Exception("Erro na verificação da consulta\n" + ex.Message);
            }
        }

        public bool insertConsulta (BConsulta bCos) {
            if (verifyConsulta(bCos) == true) {
                string sql = "INSERT INTO consulta(paciente, tipoConsulta, dataConsulta, horario, medico) ";
                sql += "VALUES('"+bCos.Paciente.Cpf+"', '" + bCos.TipoConsulta.CodTipoCons + "', '" + bCos.Data + "', '" + bCos.Horario + "', '" + bCos.Medico.Crm + "')";
                connect.update(sql);
                return true;
            }
            return false;
        }
        public bool alterConsulta  (BConsulta bCos) {
            if (verifyConsulta(bCos) == true) {
                string sql = "UPDATE consulta ";
                       sql += "SET dataConsulta = '" + bCos.Data + "', horario = '" + bCos.Horario + "', medico = '" + bCos.Medico.Crm + "' ";
                       sql += "WHERE codConsulta = " + bCos.CodConsulta;
                connect.update(sql);
                return true;
            }
            return false;
        }
        public void deleteConsulta (BConsulta bCos) {
            string sql = "DELETE FROM consulta";
                   sql += " WHERE codConsulta = " + bCos.CodConsulta;
            connect.update(sql);
        }
        public List<BConsulta> listConsulta(BConsulta bCos) {
            List<BConsulta> lCos = new List<BConsulta>();
            string sql = "SELECT codConsulta, p.nome AS paciente, t.nome AS tipoConsulta, dataConsulta, horario, m.nome AS medico ";
                    sql += "FROM consulta c ";
                    sql += "INNER JOIN paciente p ON p.cpf = c.paciente ";
                    sql += "INNER JOIN medico m ON m.crm = c.medico ";
                    sql += "INNER JOIN tipoconsulta t ON t.codTipoCons = c.tipoconsulta ";
            /*if (bCos.Paciente.Nome != null) {
                sql += "WHERE p.nome LIKE '%" + bCos.Paciente.Nome + "%' ";
            } else if(bCos.Medico.Nome != null) {
                sql += "WHERE m.nome LIKE '%" + bCos.Medico.Nome + "%' ";
            } else */ if(bCos.Horario != null) {
                sql += "WHERE horario LIKE '%" + bCos.Horario +"%' ";
            }

            if (bCos.Data != null) {
                sql += "AND dataConsulta = '" + bCos.Data + "' ";
            } else {
                sql += "AND dataConsulta >= '" + data + "' ";
            }
                    sql += "ORDER BY data DESC, horario ASC";
            try {
                MySqlConnection con = new MySqlConnection("server=localhost; database=clinic; uid=root; password=''");
                con.Open();
                MySqlCommand mcd = new MySqlCommand(sql, con);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while(mdr.Read()) {
                    BConsulta bCons = new BConsulta();
                    bCons.CodConsulta       = mdr.GetInt16(mdr.GetOrdinal("codConsulta"));
                    bCons.Paciente.Nome     = mdr.GetString(mdr.GetOrdinal("paciente"));
                    bCons.TipoConsulta.Nome = mdr.GetString(mdr.GetOrdinal("tipoConsulta"));
                    bCons.Data              = mdr.GetString(mdr.GetOrdinal("dataConsulta"));
                    bCons.Horario           = mdr.GetString(mdr.GetOrdinal("horario"));
                    bCons.Medico.Nome       = mdr.GetString(mdr.GetOrdinal("medico"));

                    lCos.Add(bCons);
                }
                con.Dispose();
                con.Close();
            } catch (Exception ex) {
                throw new Exception("Erro na listagem da Consulta\n" + ex.Message);
            }
            return lCos;
        }
    }
}