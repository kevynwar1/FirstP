package daoMetodos;

import beans.Clientes;
import conexao.ModuloConexao;
import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class MetodoCliente {

    ModuloConexao conex = new ModuloConexao();
    Clientes mod = new Clientes();

    public void cadastraCliente(Clientes mod) {
        conex.conector();
        try {
            PreparedStatement pst = conex.con.prepareStatement("INSERT INTO tbclientes(nomecli,endcli,fonecli,emailcli,cpfcli,bairrocli,cidadecli) VALUES (?,?,?,?,?,?,?)");

            pst.setString(1, mod.getNome());
            pst.setString(2, mod.getEndereco());
            pst.setString(3, mod.getTelefone());
            pst.setString(4, mod.getEmail());
            pst.setString(5, mod.getCpf());
            pst.setString(6, mod.getBairro());
            pst.setString(7, mod.getCidade());
            pst.execute();
            JOptionPane.showMessageDialog(null, "cadastrado com Sucesso!!!");
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null, "Erro ao inserir dados/nError:" + ex);
        }

    }

    public Clientes buscaCliente(Clientes mod) {
        conex.conector();

        try {
            conex.executasql("SELECT * FROM tbclientes WHERE nomecli like'%" + mod.getPesquisa() + "%'");
            conex.rs.first();
            mod.setId_Cliente(conex.rs.getInt("idcli"));
            mod.setNome(conex.rs.getString("nomecli"));
            mod.setEndereco(conex.rs.getString("endcli"));
            mod.setTelefone(conex.rs.getString("fonecli"));
            mod.setEmail(conex.rs.getString("emailcli"));
            mod.setCpf(conex.rs.getString("cpfcli"));
            mod.setBairro(conex.rs.getString("bairrocli"));
            mod.setCidade(conex.rs.getString("cidadecli"));
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao busca Cliente/n  :" + ex);
        }

        return mod;

    }

    public void editarCliente(Clientes mod) {
        conex.conector();
        try {
            PreparedStatement pst = conex.con.prepareStatement("UPDATE tbclientes SET nomecli = ?, endcli = ?, fonecli= ?, emailcli = ?, cpfcli = ?, bairrocli = ?, cidadecli= ? WHERE idcli = ?");
            pst.setString(1, mod.getNome());
            pst.setString(2, mod.getEndereco());
            pst.setString(3, mod.getTelefone());
            pst.setString(4, mod.getEmail());
            pst.setString(5, mod.getCpf());
            pst.setString(6, mod.getBairro());
            pst.setString(7, mod.getCidade());
            pst.setInt(8,mod.getId_CLiente());
            pst.execute();

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null,"error na edição dos campos"+ ex);
        }

    }
    
    public void excluirCliente (Clientes mod){
        conex.conector();
        try {
          PreparedStatement pst = conex.con.prepareStatement("DELETE  FROM tbclientes WHERE idcli = ? ");
          pst.setInt(1,mod.getId_CLiente());
          pst.execute();
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null,"erro ao excluir dados" + ex);
        }
        
        
        
    }

}
