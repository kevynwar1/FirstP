package telas;

import beans.Clientes;
import conexao.ModuloConexao;
import daoMetodos.MetodoCliente;
import daoMetodos.Tabela;

import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.ListSelectionModel;

public class FrmClientes extends javax.swing.JInternalFrame {
// a classe abaixo possui os metodos do cliente

    MetodoCliente control = new MetodoCliente();
    // a classe abaixo possui os atributos do cliente
    Clientes mod = new Clientes();
    ModuloConexao conex = new ModuloConexao();
    
    public FrmClientes() {
        initComponents();
        preencherTabela("SELECT * FROM tbclientes");
        
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTextFieldPesquisa = new javax.swing.JTextField();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        jTextFieldNome = new javax.swing.JTextField();
        jTextFieldEndereco = new javax.swing.JTextField();
        jTextFieldEmail = new javax.swing.JTextField();
        jTextFieldBairro = new javax.swing.JTextField();
        jTextFieldCidade = new javax.swing.JTextField();
        jLabel9 = new javax.swing.JLabel();
        jTextFieldId = new javax.swing.JTextField();
        jButtonCadastra = new javax.swing.JButton();
        jButtonEditar = new javax.swing.JButton();
        jButtonCancelar = new javax.swing.JButton();
        jFormattedTextFieldCpf = new javax.swing.JFormattedTextField();
        jFormattedTextFieldFone = new javax.swing.JFormattedTextField();
        jButtonExcluir = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jButtonNovo = new javax.swing.JButton();

        setClosable(true);
        setIconifiable(true);
        setTitle("Cadastro de Clientes");

        jTextFieldPesquisa.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                jTextFieldPesquisaKeyReleased(evt);
            }
        });

        jLabel2.setText("ID:");

        jLabel3.setText("Nome:");

        jLabel4.setText("Telefone:");

        jLabel5.setText("Endereço:");

        jLabel6.setText("Email:");

        jLabel7.setText("Bairro:");

        jLabel8.setText("Cidade:");

        jTextFieldNome.setEnabled(false);
        jTextFieldNome.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldNomeFocusLost(evt);
            }
        });

        jTextFieldEndereco.setEnabled(false);
        jTextFieldEndereco.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldEnderecoFocusLost(evt);
            }
        });

        jTextFieldEmail.setEnabled(false);
        jTextFieldEmail.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldEmailFocusLost(evt);
            }
        });

        jTextFieldBairro.setEnabled(false);
        jTextFieldBairro.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldBairroFocusLost(evt);
            }
        });

        jTextFieldCidade.setEnabled(false);
        jTextFieldCidade.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldCidadeFocusLost(evt);
            }
        });

        jLabel9.setText("CPF:");

        jTextFieldId.setEnabled(false);
        jTextFieldId.setFocusable(false);

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

        jButtonCancelar.setText("Cancelar");
        jButtonCancelar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonCancelarActionPerformed(evt);
            }
        });

        try {
            jFormattedTextFieldCpf.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.MaskFormatter("###.###.###-##")));
        } catch (java.text.ParseException ex) {
            ex.printStackTrace();
        }
        jFormattedTextFieldCpf.setEnabled(false);

        try {
            jFormattedTextFieldFone.setFormatterFactory(new javax.swing.text.DefaultFormatterFactory(new javax.swing.text.MaskFormatter("(##)####-####")));
        } catch (java.text.ParseException ex) {
            ex.printStackTrace();
        }
        jFormattedTextFieldFone.setEnabled(false);

        jButtonExcluir.setText("Excluir");
        jButtonExcluir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonExcluirActionPerformed(evt);
            }
        });

        jTable1.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jTable1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTable1MouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(jTable1);

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
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jTextFieldPesquisa, javax.swing.GroupLayout.PREFERRED_SIZE, 503, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                            .addGap(18, 18, 18)
                            .addComponent(jLabel2)
                            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                            .addComponent(jTextFieldId, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGroup(layout.createSequentialGroup()
                            .addGap(28, 28, 28)
                            .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 550, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGroup(layout.createSequentialGroup()
                            .addContainerGap()
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addComponent(jLabel4)
                                .addComponent(jLabel3))
                            .addGap(26, 26, 26)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addComponent(jTextFieldNome, javax.swing.GroupLayout.PREFERRED_SIZE, 385, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGroup(layout.createSequentialGroup()
                                    .addComponent(jFormattedTextFieldFone, javax.swing.GroupLayout.PREFERRED_SIZE, 109, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jLabel9)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jFormattedTextFieldCpf, javax.swing.GroupLayout.PREFERRED_SIZE, 149, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addComponent(jTextFieldEndereco, javax.swing.GroupLayout.PREFERRED_SIZE, 390, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(jTextFieldEmail, javax.swing.GroupLayout.PREFERRED_SIZE, 390, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(jTextFieldBairro, javax.swing.GroupLayout.PREFERRED_SIZE, 390, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(jTextFieldCidade, javax.swing.GroupLayout.PREFERRED_SIZE, 390, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGroup(layout.createSequentialGroup()
                            .addContainerGap()
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                                        .addComponent(jLabel6)
                                        .addGap(21, 21, 21))
                                    .addComponent(jLabel7)
                                    .addComponent(jLabel8)
                                    .addComponent(jLabel5))
                                .addGroup(layout.createSequentialGroup()
                                    .addComponent(jButtonNovo)
                                    .addGap(18, 18, 18)
                                    .addComponent(jButtonCadastra)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jButtonEditar)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                    .addComponent(jButtonExcluir)
                                    .addGap(18, 18, 18)
                                    .addComponent(jButtonCancelar)
                                    .addGap(162, 162, 162))))))
                .addContainerGap(42, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jTextFieldPesquisa, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 108, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(23, 23, 23)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(jTextFieldId, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(jTextFieldNome, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(jLabel9)
                    .addComponent(jFormattedTextFieldCpf, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jFormattedTextFieldFone, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(141, 141, 141)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jButtonCadastra)
                            .addComponent(jButtonEditar)
                            .addComponent(jButtonCancelar)
                            .addComponent(jButtonExcluir)
                            .addComponent(jButtonNovo)))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel5)
                            .addComponent(jTextFieldEndereco, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel6)
                            .addComponent(jTextFieldEmail, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel7)
                            .addComponent(jTextFieldBairro, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(12, 12, 12)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel8)
                            .addComponent(jTextFieldCidade, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addContainerGap(67, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonCadastraActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonCadastraActionPerformed
        mod.setNome(jTextFieldNome.getText());
        mod.setEndereco(jTextFieldEndereco.getText());
        mod.setTelefone(jFormattedTextFieldFone.getText());
        mod.setEmail(jTextFieldEmail.getText());
        mod.setCpf(jFormattedTextFieldCpf.getText());
        mod.setBairro(jTextFieldBairro.getText());
        mod.setCidade(jTextFieldCidade.getText());
        control.cadastraCliente(mod);
        preencherTabela("SELECT * FROM tbclientes");
        jTextFieldNome.requestFocus(true);

    }//GEN-LAST:event_jButtonCadastraActionPerformed

    private void jButtonEditarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonEditarActionPerformed
        mod.setId_Cliente(Integer.parseInt(jTextFieldId.getText()));
        mod.setNome(jTextFieldNome.getText());
        mod.setEndereco(jTextFieldEndereco.getText());
        mod.setTelefone(jFormattedTextFieldFone.getText());
        mod.setEmail(jTextFieldEmail.getText());
        mod.setCpf(jFormattedTextFieldCpf.getText());
        mod.setBairro(jTextFieldBairro.getText());
        mod.setCidade(jTextFieldCidade.getText());
        control.editarCliente(mod);
        preencherTabela("SELECT * FROM tbclientes");
        
        jTextFieldNome.requestFocus(true);
    }//GEN-LAST:event_jButtonEditarActionPerformed

    private void jButtonCancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonCancelarActionPerformed
        jTextFieldId.setText("");
        jTextFieldNome.setText("");
        jTextFieldEndereco.setText("");
        jFormattedTextFieldFone.setText("");
        jTextFieldEmail.setText("");
        jFormattedTextFieldCpf.setText("");
        jTextFieldBairro.setText("");
        jTextFieldCidade.setText("");
        jTextFieldNome.requestFocus(true);
        jButtonCadastra.setEnabled(false);
    }//GEN-LAST:event_jButtonCancelarActionPerformed

    private void jTextFieldPesquisaKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jTextFieldPesquisaKeyReleased
        mod.setPesquisa(jTextFieldPesquisa.getText());
        Clientes cli = control.buscaCliente(mod);
        jTextFieldId.setText(String.valueOf(cli.getId_CLiente()));
        jTextFieldNome.setText(cli.getNome());
        jTextFieldEndereco.setText(cli.getEndereco());
        jFormattedTextFieldFone.setText(cli.getTelefone());
        jTextFieldEmail.setText(cli.getEmail());
        jFormattedTextFieldCpf.setText(cli.getCpf());
        jTextFieldBairro.setText(cli.getBairro());
        jTextFieldCidade.setText(cli.getCidade());
    }//GEN-LAST:event_jTextFieldPesquisaKeyReleased

    private void jButtonExcluirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonExcluirActionPerformed
        int resposta = 0;
        resposta = JOptionPane.showConfirmDialog(rootPane, "Deseja Realmente Excluir ?");
        if (resposta == JOptionPane.YES_OPTION) {
            mod.setId_Cliente(Integer.parseInt(jTextFieldId.getText()));
            control.excluirCliente(mod);
            preencherTabela("SELECT * FROM tbclientes");
            jTextFieldId.setText("");
            jTextFieldNome.setText("");
            jTextFieldEndereco.setText("");
            jFormattedTextFieldFone.setText("");
            jTextFieldEmail.setText("");
            jFormattedTextFieldCpf.setText("");
            jTextFieldBairro.setText("");
            jTextFieldCidade.setText("");
            jTextFieldNome.requestFocus(true);
            jButtonCadastra.setEnabled(true);
        }
        

    }//GEN-LAST:event_jButtonExcluirActionPerformed

    private void jTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable1MouseClicked
        String nomecli = "" + jTable1.getValueAt(jTable1.getSelectedRow(), 1);
        conex.conector();
        conex.executasql("SELECT * FROM tbclientes WHERE nomecli ='" + nomecli + "'");
        try {
            conex.rs.first();
            jTextFieldId.setText(String.valueOf(conex.rs.getInt("idcli")));
            jTextFieldNome.setText(conex.rs.getString("nomecli"));
            jTextFieldEndereco.setText(conex.rs.getString("endcli"));
            jFormattedTextFieldFone.setText(conex.rs.getString("fonecli"));
            jTextFieldEmail.setText(conex.rs.getString("emailcli"));
            jFormattedTextFieldCpf.setText(conex.rs.getString("cpfcli"));
            jTextFieldBairro.setText(conex.rs.getString("bairrocli"));
            jTextFieldCidade.setText(conex.rs.getString("cidadecli"));
            jTextFieldNome.setEnabled(true);
            jTextFieldEndereco.setEnabled(true);
            jFormattedTextFieldFone.setEnabled(true);
            jTextFieldEmail.setEnabled(true);
            jFormattedTextFieldCpf.setEnabled(true);
            jTextFieldBairro.setEnabled(true);
            jTextFieldCidade.setEnabled(true);
            jButtonCadastra.setEnabled(false);
            
        } catch (SQLException ex) {
          JOptionPane.showMessageDialog(null,"Erro ao clicar na tabela");
        }

    }//GEN-LAST:event_jTable1MouseClicked

    private void jButtonNovoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonNovoActionPerformed
      
        jTextFieldNome.setEnabled(true);
        jTextFieldEndereco.setEnabled(true);
        jFormattedTextFieldFone.setEnabled(true);
        jTextFieldEmail.setEnabled(true);
        jFormattedTextFieldCpf.setEnabled(true);
        jTextFieldBairro.setEnabled(true);
        jTextFieldCidade.setEnabled(true);
        jTextFieldNome.requestFocus(true);
        jTextFieldId.setText("");
        jTextFieldNome.setText("");
        jTextFieldEndereco.setText("");
        jFormattedTextFieldFone.setText("");
        jTextFieldEmail.setText("");
        jFormattedTextFieldCpf.setText("");
        jTextFieldBairro.setText("");
        jTextFieldCidade.setText("");
        jButtonCadastra.setEnabled(true);
    }//GEN-LAST:event_jButtonNovoActionPerformed

    private void jTextFieldNomeFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldNomeFocusLost
        String cap = jTextFieldNome.getText();
        jTextFieldNome.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldNomeFocusLost

    private void jTextFieldEnderecoFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldEnderecoFocusLost
        String cap = jTextFieldEndereco.getText();
        jTextFieldEndereco.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldEnderecoFocusLost

    private void jTextFieldEmailFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldEmailFocusLost
        String cap = jTextFieldEmail.getText();
        jTextFieldEmail.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldEmailFocusLost

    private void jTextFieldBairroFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldBairroFocusLost
        String cap = jTextFieldBairro.getText();
        jTextFieldBairro.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldBairroFocusLost

    private void jTextFieldCidadeFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldCidadeFocusLost
        String cap = jTextFieldCidade.getText();
        jTextFieldCidade.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldCidadeFocusLost
   // metodo para preenchimento das tabelas 
    public void preencherTabela(String sql) {
        ArrayList dados = new ArrayList();
        String[] colunas = new String[]{"ID", "Nome", "Endereço", "Telefone", "Email", "CPF", "Bairro", "Cidade"};
        conex.conector();
        conex.executasql(sql);
        try {
            conex.rs.first();
            do {
                dados.add(new Object[]{conex.rs.getInt("idcli"), conex.rs.getString("nomecli"), conex.rs.getString("endcli"), conex.rs.getString("fonecli"), conex.rs.getString("emailcli"), conex.rs.getString("cpfcli"), conex.rs.getString("bairrocli"), conex.rs.getString("cidadecli")});
            } while (conex.rs.next());
            
        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(rootPane, "Error ao Preencher no arraylist " + ex);
        }
        Tabela tabela = new Tabela(dados, colunas);
        jTable1.setModel(tabela);
        jTable1.getColumnModel().getColumn(0).setPreferredWidth(23);
        jTable1.getColumnModel().getColumn(0).setResizable(false);
        jTable1.getColumnModel().getColumn(1).setPreferredWidth(180);
        jTable1.getColumnModel().getColumn(1).setResizable(false);
        jTable1.getColumnModel().getColumn(2).setPreferredWidth(250);
        jTable1.getColumnModel().getColumn(2).setResizable(false);
        jTable1.getColumnModel().getColumn(3).setPreferredWidth(150);
        jTable1.getColumnModel().getColumn(3).setResizable(false);
        jTable1.getColumnModel().getColumn(4).setPreferredWidth(200);
        jTable1.getColumnModel().getColumn(4).setResizable(false);
        jTable1.getColumnModel().getColumn(5).setPreferredWidth(150);
        jTable1.getColumnModel().getColumn(5).setResizable(false);
        jTable1.getColumnModel().getColumn(6).setPreferredWidth(100);
        jTable1.getColumnModel().getColumn(6).setResizable(false);
        jTable1.getColumnModel().getColumn(7).setPreferredWidth(100);
        jTable1.getColumnModel().getColumn(7).setResizable(false);
        jTable1.getTableHeader().setReorderingAllowed(false);
        jTable1.setAutoResizeMode(jTable1.AUTO_RESIZE_OFF);
        jTable1.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonCadastra;
    private javax.swing.JButton jButtonCancelar;
    private javax.swing.JButton jButtonEditar;
    private javax.swing.JButton jButtonExcluir;
    private javax.swing.JButton jButtonNovo;
    private javax.swing.JFormattedTextField jFormattedTextFieldCpf;
    private javax.swing.JFormattedTextField jFormattedTextFieldFone;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTable jTable1;
    private javax.swing.JTextField jTextFieldBairro;
    private javax.swing.JTextField jTextFieldCidade;
    private javax.swing.JTextField jTextFieldEmail;
    private javax.swing.JTextField jTextFieldEndereco;
    private javax.swing.JTextField jTextFieldId;
    private javax.swing.JTextField jTextFieldNome;
    private javax.swing.JTextField jTextFieldPesquisa;
    // End of variables declaration//GEN-END:variables
}
