/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package daoMetodos;

import beans.Clientes;
import beans.Os;
import conexao.ModuloConexao;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import javax.swing.JOptionPane;

/**
 *
 * @author pessoal
 */
public class OrdemServico {

    ModuloConexao conex = new ModuloConexao();
    Os mod = new Os();
    Clientes cli = new Clientes();

    public void cadastraServico(Os mod, Clientes cli) {
        conex.conector();
        try {
            PreparedStatement pst = conex.con.prepareStatement("INSERT INTO tbos(equipamento,defeito,servico,tecnico,valor,idcli) VALUES (?,?,?,?,?,?)");
            pst.setString(1, mod.getEquipamento());
            pst.setString(2, mod.getDefeito());
            pst.setString(3, mod.getServico());
            pst.setString(4, mod.getTecnico());
            pst.setDouble(5, mod.getValor());
            pst.setInt(6, cli.getId_CLiente());
            pst.execute();
            JOptionPane.showMessageDialog(null, "cadastrado com Sucesso!!!");
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null, "Erro ao inserir dados/nError:" + ex);
        }

    }

    public Os buscaServico(Os mod) {
        conex.conector();

        try {
            conex.executasql("SELECT * FROM tbos WHERE equipamento like'%" + mod.getPesquisa() + "%'");
            conex.rs.first();
            mod.setId(conex.rs.getInt("os"));
            mod.setEquipamento(conex.rs.getString("equipamento"));
            mod.setDefeito(conex.rs.getString("defeito"));
            mod.setServico(conex.rs.getString("servico"));
            mod.setTecnico(conex.rs.getString("tecnico"));
            mod.setValor(conex.rs.getDouble("valor"));

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao busca Ordem de Serviço/n  :" + ex);
        }

        return mod;

    }

    public void editarServico(Os mod, Clientes cli) {
        conex.conector();
        try {
            PreparedStatement pst = conex.con.prepareStatement("UPDATE tbos SET equipamento = ?,defeito = ?, servico= ?,tecnico = ?, valor = ?, idcli = ? WHERE os = ? ");
            pst.setString(1, mod.getEquipamento());
            pst.setString(2, mod.getDefeito());
            pst.setString(3, mod.getServico());
            pst.setString(4, mod.getTecnico());
            pst.setDouble(5, mod.getValor());
            pst.setInt(6, cli.getId_CLiente());
            pst.setInt(7, mod.getId());
            pst.execute();

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "error na edição dos campos" + ex);
        }

    }

}
