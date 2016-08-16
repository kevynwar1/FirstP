package telas;

import beans.Usuarios;
import conexao.ModuloConexao;
import daoMetodos.Tabela;
import daoMetodos.MetodoUsuario;
import java.sql.*;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.ListSelectionModel;


public class FrmUsuario extends javax.swing.JInternalFrame {

    ModuloConexao conex = new ModuloConexao();
    MetodoUsuario use = new MetodoUsuario();
    Usuarios mod = new Usuarios();

    public FrmUsuario() {
        initComponents();
        preencherTabela("SELECT * FROM tbusuarios ORDER BY usuario");

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTableU = new javax.swing.JTable();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jTextFieldIdU = new javax.swing.JTextField();
        jTextFieldNomeU = new javax.swing.JTextField();
        jFormattedTextTelefoneU = new javax.swing.JFormattedTextField();
        jTextFieldLoginU = new javax.swing.JTextField();
        jTextFieldSenhaU = new javax.swing.JTextField();
        jTextFieldPesquisaU = new javax.swing.JTextField();
        jButtonCadastra = new javax.swing.JButton();
        jButtonEditar = new javax.swing.JButton();
        jButtonExcluir = new javax.swing.JButton();
        jButtonCancelar = new javax.swing.JButton();
        jButtonNovo = new javax.swing.JButton();

        setClosable(true);
        setIconifiable(true);
        setTitle("Cadastro de Usuários");
        setToolTipText("");

        jTableU.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {

            }
        ));
        jTableU.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTableUMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(jTableU);

        jLabel1.setText("Pesquisar:");

        jLabel2.setText("ID:");

        jLabel3.setText("Nome:");

        jLabel4.setText("Telefone:");

        jLabel5.setText("Login:");

        jLabel6.setText("Senha:");

        jTextFieldIdU.setEnabled(false);
        jTextFieldIdU.setFocusable(false);

        jTextFieldNomeU.setEnabled(false);
        jTextFieldNomeU.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldNomeUFocusLost(evt);
            }
        });

        try {
            jFormattedTextTelefoneU.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.MaskFormatter("(##) ####-####")));
        } catch (java.text.ParseException ex) {
            ex.printStackTrace();
        }
        jFormattedTextTelefoneU.setEnabled(false);

        jTextFieldLoginU.setEnabled(false);

        jTextFieldSenhaU.setEnabled(false);

        jTextFieldPesquisaU.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                jTextFieldPesquisaUKeyReleased(evt);
            }
        });

        jButtonCadastra.setText("Cadastra");
        jButtonCadastra.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonCadastraActionPerformed(evt);
            }
        });

        jButtonEditar.setText("Editar");
        jButtonEditar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonEditarActionPerformed(evt);
            }
        });

        jButtonExcluir.setText("Deletar");
        jButtonExcluir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonExcluirActionPerformed(evt);
            }
        });

        jButtonCancelar.setText("Cancelar");
        jButtonCancelar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonCancelarActionPerformed(evt);
            }
        });

        jButtonNovo.setText("Novo");
        jButtonNovo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonNovoActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 515, Short.MAX_VALUE)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel2)
                                    .addComponent(jLabel3)
                                    .addComponent(jLabel1))
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(2, 2, 2)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(jTextFieldNomeU, javax.swing.GroupLayout.PREFERRED_SIZE, 369, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jTextFieldIdU, javax.swing.GroupLayout.PREFERRED_SIZE, 43, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addGroup(layout.createSequentialGroup()
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jTextFieldPesquisaU, javax.swing.GroupLayout.PREFERRED_SIZE, 398, javax.swing.GroupLayout.PREFERRED_SIZE))))
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                    .addComponent(jLabel6)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                    .addComponent(jTextFieldSenhaU))
                                .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(jLabel4)
                                        .addComponent(jLabel5))
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addComponent(jFormattedTextTelefoneU, javax.swing.GroupLayout.PREFERRED_SIZE, 152, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addComponent(jTextFieldLoginU, javax.swing.GroupLayout.PREFERRED_SIZE, 180, javax.swing.GroupLayout.PREFERRED_SIZE))))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(44, 44, 44)
                                .addComponent(jButtonNovo)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addComponent(jButtonCadastra)
                                .addGap(18, 18, 18)
                                .addComponent(jButtonEditar)
                                .addGap(18, 18, 18)
                                .addComponent(jButtonExcluir)
                                .addGap(18, 18, 18)
                                .addComponent(jButtonCancelar)))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 124, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(21, 21, 21)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(jTextFieldPesquisaU, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(jTextFieldIdU, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(jTextFieldNomeU, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(jFormattedTextTelefoneU, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(jTextFieldLoginU, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel6)
                    .addComponent(jTextFieldSenhaU, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButtonCadastra)
                    .addComponent(jButtonEditar)
                    .addComponent(jButtonExcluir)
                    .addComponent(jButtonCancelar)
                    .addComponent(jButtonNovo))
                .addGap(0, 23, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonCancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonCancelarActionPerformed
        jTextFieldIdU.setText("");
        jTextFieldNomeU.setText("");
        jFormattedTextTelefoneU.setText("");
        jTextFieldLoginU.setText("");
        jTextFieldSenhaU.setText("");
    }//GEN-LAST:event_jButtonCancelarActionPerformed

    private void jButtonCadastraActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonCadastraActionPerformed
        mod.setNome(jTextFieldNomeU.getText());
        mod.setTelefone(jFormattedTextTelefoneU.getText());
        mod.setLogin(jTextFieldLoginU.getText());
        mod.setSenha(jTextFieldSenhaU.getText());
        use.cadastraUsuario(mod);
        jTextFieldNomeU.requestFocus(true);
        preencherTabela("SELECT * FROM tbusuarios ORDER BY usuario");
    }//GEN-LAST:event_jButtonCadastraActionPerformed

    private void jButtonEditarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonEditarActionPerformed
        mod.setId_Usuario(Integer.parseInt(jTextFieldIdU.getText()));
        mod.setNome(jTextFieldNomeU.getText());
        mod.setTelefone(jFormattedTextTelefoneU.getText());
        mod.setLogin(jTextFieldLoginU.getText());
        mod.setSenha(jTextFieldSenhaU.getText());
        use.editarUsuario(mod);

        preencherTabela("SELECT * FROM tbusuarios ORDER BY usuario");

        jTextFieldNomeU.requestFocus(true);

    }//GEN-LAST:event_jButtonEditarActionPerformed

    private void jButtonExcluirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonExcluirActionPerformed
        int resposta = 0;
        resposta = JOptionPane.showConfirmDialog(rootPane, "Deseja Realmente Excluir ?");
        if (resposta == JOptionPane.YES_OPTION) {
            mod.setId_Usuario(Integer.parseInt(jTextFieldIdU.getText()));
            use.excluirUsuario(mod);

            preencherTabela("SELECT * FROM tbusuarios ORDER BY usuario");

            jTextFieldIdU.setText("");
            jTextFieldNomeU.setText("");
            jFormattedTextTelefoneU.setText("");
            jTextFieldLoginU.setText("");
            jTextFieldSenhaU.setText("");

            jTextFieldNomeU.requestFocus(true);
        }
    }//GEN-LAST:event_jButtonExcluirActionPerformed

    private void jTableUMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTableUMouseClicked
        String usuario = "" + jTableU.getValueAt(jTableU.getSelectedRow(), 1);
        conex.conector();
        conex.executasql("SELECT * FROM tbusuarios WHERE usuario ='" + usuario + "'");
        try {
            conex.rs.first();
            jTextFieldIdU.setText(String.valueOf(conex.rs.getInt("iduser")));
            jTextFieldNomeU.setText(conex.rs.getString("usuario"));
            jFormattedTextTelefoneU.setText(conex.rs.getString("fone"));
            jTextFieldLoginU.setText(conex.rs.getString("login"));
            jTextFieldSenhaU.setText(conex.rs.getString("senha"));

            jTextFieldNomeU.setEnabled(true);
            jFormattedTextTelefoneU.setEnabled(true);
            jTextFieldLoginU.setEnabled(true);
            jTextFieldSenhaU.setEnabled(true);

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "ERRO DURANTE O CLIQUE DO MOUSE" + ex);
        }
    }//GEN-LAST:event_jTableUMouseClicked

    private void jTextFieldPesquisaUKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jTextFieldPesquisaUKeyReleased
        mod.setPesquisa(jTextFieldPesquisaU.getText());
        Usuarios cli = use.buscaUsuario(mod);
        jTextFieldIdU.setText(String.valueOf(cli.getId_Usuario()));
        jTextFieldNomeU.setText(cli.getNome());
        jFormattedTextTelefoneU.setText(cli.getTelefone());
        jTextFieldLoginU.setText(cli.getLogin());
        jTextFieldSenhaU.setText(cli.getSenha());

    }//GEN-LAST:event_jTextFieldPesquisaUKeyReleased

    private void jButtonNovoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonNovoActionPerformed

        jTextFieldNomeU.setEnabled(true);
        jFormattedTextTelefoneU.setEnabled(true);
        jTextFieldLoginU.setEnabled(true);
        jTextFieldSenhaU.setEnabled(true);
        
        jTextFieldIdU.setText("");
        jTextFieldNomeU.setText("");
        jFormattedTextTelefoneU.setText("");
        jTextFieldLoginU.setText("");
        jTextFieldSenhaU.setText("");
        
        jTextFieldNomeU.requestFocus(true);

    }//GEN-LAST:event_jButtonNovoActionPerformed

    private void jTextFieldNomeUFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldNomeUFocusLost
String cap = jTextFieldNomeU.getText();
jTextFieldNomeU.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldNomeUFocusLost
    public void preencherTabela(String sql) {
        ArrayList dados = new ArrayList();
        String[] colunas = new String[]{"ID", "Nome", "Telefone", "Login", "Senha"};
        conex.conector();
        conex.executasql(sql);
        try {
            conex.rs.first();
            do {
                dados.add(new Object[]{conex.rs.getInt("iduser"), conex.rs.getString("usuario"), conex.rs.getString("fone"), conex.rs.getString("login"), conex.rs.getString("senha")});
            } while (conex.rs.next());

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(rootPane, "Error ao Preencher no arraylist " + ex);
        }
        Tabela tabela = new Tabela(dados, colunas);
        jTableU.setModel(tabela);
        jTableU.getColumnModel().getColumn(0).setPreferredWidth(23);
        jTableU.getColumnModel().getColumn(0).setResizable(false);
        jTableU.getColumnModel().getColumn(1).setPreferredWidth(180);
        jTableU.getColumnModel().getColumn(1).setResizable(false);
        jTableU.getColumnModel().getColumn(2).setPreferredWidth(250);
        jTableU.getColumnModel().getColumn(2).setResizable(false);
        jTableU.getColumnModel().getColumn(3).setPreferredWidth(150);
        jTableU.getColumnModel().getColumn(3).setResizable(false);
        jTableU.getColumnModel().getColumn(4).setPreferredWidth(200);
        jTableU.getColumnModel().getColumn(4).setResizable(false);
        jTableU.getTableHeader().setReorderingAllowed(false);
        jTableU.setAutoResizeMode(jTableU.AUTO_RESIZE_OFF);
        jTableU.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonCadastra;
    private javax.swing.JButton jButtonCancelar;
    private javax.swing.JButton jButtonEditar;
    private javax.swing.JButton jButtonExcluir;
    private javax.swing.JButton jButtonNovo;
    private javax.swing.JFormattedTextField jFormattedTextTelefoneU;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTableU;
    private javax.swing.JTextField jTextFieldIdU;
    private javax.swing.JTextField jTextFieldLoginU;
    private javax.swing.JTextField jTextFieldNomeU;
    private javax.swing.JTextField jTextFieldPesquisaU;
    private javax.swing.JTextField jTextFieldSenhaU;
    // End of variables declaration//GEN-END:variables
}
