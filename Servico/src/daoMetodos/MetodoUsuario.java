package daoMetodos;

import beans.Usuarios;
import conexao.ModuloConexao;
import java.sql.*;
import javax.swing.JOptionPane;

public class MetodoUsuario {

    ModuloConexao conex = new ModuloConexao();
    Usuarios mod = new Usuarios();

    public void cadastraUsuario(Usuarios mod) {
        conex.conector();
        try {
            PreparedStatement pst = conex.con.prepareStatement("INSERT INTO tbusuarios(usuario,fone,login,senha) VALUES (?,?,?,?)");

            pst.setString(1, mod.getNome());
            pst.setString(2, mod.getTelefone());
            pst.setString(3, mod.getLogin());
            pst.setString(4, mod.getSenha());
            pst.execute();
            JOptionPane.showMessageDialog(null, "cadastrado com Sucesso!!!");
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null, "Erro ao inserir dados/nError:" + ex);
        }

    }

    public Usuarios buscaUsuario(Usuarios mod) {
        conex.conector();

        try {
            conex.executasql("SELECT * FROM tbusuarios WHERE usuario like'%" + mod.getPesquisa() + "%'");
            conex.rs.first();
            mod.setId_Usuario(conex.rs.getInt("iduser"));
            mod.setNome(conex.rs.getString("usuario"));
            mod.setTelefone(conex.rs.getString("fone"));
            mod.setLogin(conex.rs.getString("login"));
            mod.setSenha(conex.rs.getString("senha"));

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "Erro ao busca Usuario/n  :" + ex);
        }

        return mod;

    }

    public void editarUsuario(Usuarios mod) {
        conex.conector();
        try {
            PreparedStatement pst = conex.con.prepareStatement("UPDATE tbusuarios SET usuario = ?, fone = ?, login= ?, senha = ? WHERE iduser = ?");
            pst.setString(1, mod.getNome());
            pst.setString(2, mod.getTelefone());
            pst.setString(3, mod.getLogin());
            pst.setString(4, mod.getSenha());
            pst.setInt(5, mod.getId_Usuario());
            pst.execute();

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "error na edição dos campos" + ex);
        }

    }
    
     public void excluirUsuario (Usuarios mod){
        conex.conector();
        try {
          PreparedStatement pst = conex.con.prepareStatement("DELETE  FROM tbusuarios WHERE iduser = ? ");
          pst.setInt(1,mod.getId_Usuario());
          pst.execute();
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null,"erro ao excluir dados" + ex);
        }
        
        
        
    }

}
