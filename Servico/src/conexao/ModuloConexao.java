package conexao;

import java.sql.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

public class ModuloConexao {

    public Statement st;
    public ResultSet rs;
    public Connection con;
    private String driver = "com.mysql.jdbc.Driver";
    private String caminho = "jdbc:mysql://localhost:3306/os";
    private String usuario = "root";
    private String senha = "";
// metodo para estabelecer conexao com o banco

    public void conector() {

        try {
            System.setProperty("jdbc.Drivers", driver);
            con = DriverManager.getConnection(caminho, usuario, senha);
        } catch (SQLException ex) {
           JOptionPane.showMessageDialog(null,"impossivel conectar"+ ex);
        }

    }

    public void executasql(String sql) {

        try {
            st = con.createStatement(rs.TYPE_SCROLL_INSENSITIVE, rs.CONCUR_READ_ONLY);
            rs = st.executeQuery(sql);
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(null, "erro executasql:\n" + ex);
        }

    }

}
