package telas;

import beans.Clientes;
import beans.Os;
import conexao.ModuloConexao;
import daoMetodos.OrdemServico;
import daoMetodos.Tabela;
import java.sql.*;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.ListSelectionModel;

public class FrmOs extends javax.swing.JInternalFrame {

    ModuloConexao conex = new ModuloConexao();
    Os mod = new Os();
    OrdemServico ser = new OrdemServico();
    Clientes cli = new Clientes();

    public FrmOs() {
        initComponents();
        preencherTabela("SELECT * FROM tbos ORDER BY equipamento");

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTable1 = new javax.swing.JTable();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jTextFieldEquipamento = new javax.swing.JTextField();
        jTextFieldDefeito = new javax.swing.JTextField();
        jTextFieldServico = new javax.swing.JTextField();
        jTextFieldTecnico = new javax.swing.JTextField();
        jTextFieldOs = new javax.swing.JTextField();
        jTextFieldCliente = new javax.swing.JTextField();
        jTextFieldTotal = new javax.swing.JTextField();
        jButtonCadastra = new javax.swing.JButton();
        jButtonEditar = new javax.swing.JButton();
        jButtonCancelar = new javax.swing.JButton();
        jLabel8 = new javax.swing.JLabel();
        jTextFieldIdCliente = new javax.swing.JTextField();
        jButtonNovo = new javax.swing.JButton();
        jTextFieldPesquisa = new javax.swing.JTextField();

        setClosable(true);
        setIconifiable(true);

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
        jScrollPane1.setViewportView(jTable1);

        jLabel1.setText("Equipamento:");

        jLabel2.setText("Defeito:");

        jLabel3.setText("Serviço:");

        jLabel4.setText("Tecnico:");

        jLabel5.setText("ID OS:");

        jLabel6.setText("Cliente:");

        jLabel7.setText("Valor Total:");

        jTextFieldEquipamento.setEnabled(false);
        jTextFieldEquipamento.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldEquipamentoFocusLost(evt);
            }
        });

        jTextFieldDefeito.setEnabled(false);
        jTextFieldDefeito.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldDefeitoFocusLost(evt);
            }
        });

        jTextFieldServico.setEnabled(false);
        jTextFieldServico.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldServicoFocusLost(evt);
            }
        });

        jTextFieldTecnico.setEnabled(false);
        jTextFieldTecnico.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldTecnicoFocusLost(evt);
            }
        });
        jTextFieldTecnico.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextFieldTecnicoActionPerformed(evt);
            }
        });

        jTextFieldOs.setEnabled(false);
        jTextFieldOs.setFocusable(false);

        jTextFieldCliente.setEnabled(false);
        jTextFieldCliente.setFocusable(false);
        jTextFieldCliente.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextFieldClienteActionPerformed(evt);
            }
        });

        jTextFieldTotal.setEnabled(false);

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

        jLabel8.setText("ID Cliente:");

        jTextFieldIdCliente.setEnabled(false);
        jTextFieldIdCliente.addFocusListener(new java.awt.event.FocusAdapter() {
            public void focusLost(java.awt.event.FocusEvent evt) {
                jTextFieldIdClienteFocusLost(evt);
            }
        });

        jButtonNovo.setText("Novo");
        jButtonNovo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonNovoActionPerformed(evt);
            }
        });

        jTextFieldPesquisa.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                jTextFieldPesquisaKeyPressed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(20, 20, 20)
                                        .addComponent(jButtonNovo)
                                        .addGap(42, 42, 42)
                                        .addComponent(jButtonCadastra)
                                        .addGap(37, 37, 37)
                                        .addComponent(jButtonEditar)
                                        .addGap(28, 28, 28)
                                        .addComponent(jButtonCancelar))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(jLabel6)
                                            .addComponent(jLabel7))
                                        .addGap(23, 23, 23)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(jTextFieldCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 339, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jTextFieldTotal, javax.swing.GroupLayout.PREFERRED_SIZE, 161, javax.swing.GroupLayout.PREFERRED_SIZE)))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                                .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                                    .addComponent(jLabel5)
                                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                                    .addComponent(jTextFieldOs))
                                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                    .addComponent(jLabel1)
                                                    .addComponent(jLabel2)
                                                    .addComponent(jLabel3)
                                                    .addComponent(jLabel4)))
                                            .addComponent(jLabel8))
                                        .addGap(12, 12, 12)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(jTextFieldIdCliente, javax.swing.GroupLayout.PREFERRED_SIZE, 32, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jTextFieldTecnico, javax.swing.GroupLayout.PREFERRED_SIZE, 441, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jTextFieldServico, javax.swing.GroupLayout.PREFERRED_SIZE, 441, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jTextFieldDefeito, javax.swing.GroupLayout.PREFERRED_SIZE, 441, javax.swing.GroupLayout.PREFERRED_SIZE)
                                            .addComponent(jTextFieldEquipamento, javax.swing.GroupLayout.PREFERRED_SIZE, 441, javax.swing.GroupLayout.PREFERRED_SIZE))))
                                .addGap(0, 44, Short.MAX_VALUE))))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(21, 21, 21)
                        .addComponent(jTextFieldPesquisa)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(25, 25, 25)
                .addComponent(jTextFieldPesquisa, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 106, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(2, 2, 2)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(jTextFieldOs, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(jTextFieldEquipamento, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(jTextFieldDefeito, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(jTextFieldServico, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(jTextFieldTecnico, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel8)
                    .addComponent(jTextFieldIdCliente, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel6)
                    .addComponent(jTextFieldCliente, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel7)
                    .addComponent(jTextFieldTotal, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(36, 36, 36)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButtonCadastra)
                    .addComponent(jButtonEditar)
                    .addComponent(jButtonCancelar)
                    .addComponent(jButtonNovo))
                .addContainerGap(117, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jTextFieldTecnicoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextFieldTecnicoActionPerformed

    }//GEN-LAST:event_jTextFieldTecnicoActionPerformed

    private void jButtonCadastraActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonCadastraActionPerformed
        mod.setEquipamento(jTextFieldEquipamento.getText());
        mod.setDefeito(jTextFieldDefeito.getText());
        mod.setServico(jTextFieldServico.getText());
        mod.setTecnico(jTextFieldTecnico.getText());
        mod.setValor(Double.parseDouble(jTextFieldTotal.getText()));
        cli.setId_Cliente(Integer.parseInt(jTextFieldIdCliente.getText()));
        ser.cadastraServico(mod, cli);
        preencherTabela("SELECT * FROM tbos ORDER BY equipamento ");
    }//GEN-LAST:event_jButtonCadastraActionPerformed

    private void jButtonEditarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonEditarActionPerformed
        mod.setId(Integer.parseInt(jTextFieldOs.getText()));
        mod.setEquipamento(jTextFieldEquipamento.getText());
        mod.setDefeito(jTextFieldDefeito.getText());
        mod.setServico(jTextFieldServico.getText());
        mod.setTecnico(jTextFieldTecnico.getText());
        mod.setValor(Double.parseDouble(jTextFieldTotal.getText()));
        cli.setId_Cliente(Integer.parseInt(jTextFieldIdCliente.getText()));
        ser.editarServico(mod, cli);
        preencherTabela("SELECT * FROM tbos ORDER BY equipamento ");
    }//GEN-LAST:event_jButtonEditarActionPerformed

    private void jButtonCancelarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonCancelarActionPerformed
        jTextFieldEquipamento.setText("");
        jTextFieldDefeito.setText("");
        jTextFieldServico.setText("");
        jTextFieldTecnico.setText("");
        jTextFieldTotal.setText("");
        jTextFieldIdCliente.setText("");
        jTextFieldCliente.setText("");
        jTextFieldEquipamento.requestFocus(true);
        jButtonCadastra.setEnabled(true);

    }//GEN-LAST:event_jButtonCancelarActionPerformed

    private void jTable1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTable1MouseClicked
        String equipamento = "" + jTable1.getValueAt(jTable1.getSelectedRow(), 1);
        conex.conector();
        conex.executasql("SELECT * FROM tbos WHERE equipamento ='" + equipamento + "'");
        try {
            conex.rs.first();
            jTextFieldOs.setText(String.valueOf(conex.rs.getInt("os")));
            jTextFieldEquipamento.setText(conex.rs.getString("equipamento"));
            jTextFieldDefeito.setText(conex.rs.getString("defeito"));
            jTextFieldServico.setText(conex.rs.getString("servico"));
            jTextFieldTecnico.setText(conex.rs.getString("tecnico"));
            jTextFieldIdCliente.setText(conex.rs.getString("idcli"));
            jTextFieldTotal.setText(conex.rs.getString("valor"));

            String lost = "" + jTextFieldIdCliente.getText();
            conex.conector();
            conex.executasql("SELECT * FROM tbclientes WHERE idcli ='" + lost + "'");
            try {
                conex.rs.first();

                jTextFieldCliente.setText(conex.rs.getString("nomecli"));

            } catch (SQLException ex) {
                JOptionPane.showMessageDialog(null, "erro no focus lost FORM OS" + ex);
            }

            jTextFieldEquipamento.setEnabled(true);
            jTextFieldDefeito.setEnabled(true);
            jTextFieldServico.setEnabled(true);
            jTextFieldTecnico.setEnabled(true);
            jTextFieldTotal.setEnabled(true);
            jTextFieldIdCliente.setEnabled(true);

            jButtonCadastra.setEnabled(false);

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "ERRO NO CLIQUE DO MOUSE" + ex);
        }
    }//GEN-LAST:event_jTable1MouseClicked

    private void jTextFieldClienteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextFieldClienteActionPerformed

    }//GEN-LAST:event_jTextFieldClienteActionPerformed

    private void jButtonNovoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonNovoActionPerformed
        jTextFieldEquipamento.setEnabled(true);
        jTextFieldDefeito.setEnabled(true);
        jTextFieldServico.setEnabled(true);
        jTextFieldTecnico.setEnabled(true);
        jTextFieldIdCliente.setEnabled(true);
        jTextFieldTotal.setEnabled(true);

        jTextFieldEquipamento.setText("");
        jTextFieldDefeito.setText("");
        jTextFieldServico.setText("");
        jTextFieldTecnico.setText("");
        jTextFieldTotal.setText("");
        jTextFieldIdCliente.setText("");
        jTextFieldCliente.setText("");

        jTextFieldEquipamento.requestFocus(true);
        jButtonCadastra.setEnabled(true);
    }//GEN-LAST:event_jButtonNovoActionPerformed

    private void jTextFieldIdClienteFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldIdClienteFocusLost
        String lost = "" + jTextFieldIdCliente.getText();
        conex.conector();
        conex.executasql("SELECT * FROM tbclientes WHERE idcli ='" + lost + "'");
        try {
            conex.rs.first();

            jTextFieldCliente.setText(conex.rs.getString("nomecli"));

        } catch (SQLException ex) {
            JOptionPane.showMessageDialog(null, "erro no focus lost FORM OS" + ex);
        }
    }//GEN-LAST:event_jTextFieldIdClienteFocusLost

    private void jTextFieldEquipamentoFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldEquipamentoFocusLost
        String cap = jTextFieldEquipamento.getText();
        jTextFieldEquipamento.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldEquipamentoFocusLost

    private void jTextFieldDefeitoFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldDefeitoFocusLost
        String cap = jTextFieldDefeito.getText();
        jTextFieldDefeito.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldDefeitoFocusLost

    private void jTextFieldServicoFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldServicoFocusLost
        String cap = jTextFieldServico.getText();
        jTextFieldServico.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldServicoFocusLost

    private void jTextFieldTecnicoFocusLost(java.awt.event.FocusEvent evt) {//GEN-FIRST:event_jTextFieldTecnicoFocusLost
        String cap = jTextFieldTecnico.getText();
        jTextFieldTecnico.setText(cap.toUpperCase());
    }//GEN-LAST:event_jTextFieldTecnicoFocusLost

    private void jTextFieldPesquisaKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_jTextFieldPesquisaKeyPressed
        mod.setPesquisa(jTextFieldPesquisa.getText());
        Os ordem = ser.buscaServico(mod);
        jTextFieldOs.setText(String.valueOf(ordem.getId()));
        jTextFieldEquipamento.setText(ordem.getEquipamento());
        jTextFieldDefeito.setText(ordem.getDefeito());
        jTextFieldServico.setText(ordem.getServico());
        jTextFieldTecnico.setText(ordem.getTecnico());
        jTextFieldTotal.setText(String.valueOf(ordem.getValor()));


    }//GEN-LAST:event_jTextFieldPesquisaKeyPressed
    public void preencherTabela(String sql) {
        ArrayList dados = new ArrayList();
        String[] colunas = new String[]{"ID Serviço", "Equipamento", "Defeito", "Serviço", "Tecnico", "Valor", "ID Cliente"};
        conex.conector();
        conex.executasql(sql);
        try {
            conex.rs.first();
            do {
                dados.add(new Object[]{conex.rs.getInt("os"), conex.rs.getString("equipamento"), conex.rs.getString("defeito"), conex.rs.getString("servico"), conex.rs.getString("tecnico"), conex.rs.getDouble("valor"), conex.rs.getInt("idcli")});
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

        jTable1.getTableHeader().setReorderingAllowed(false);
        jTable1.setAutoResizeMode(jTable1.AUTO_RESIZE_OFF);
        jTable1.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonCadastra;
    private javax.swing.JButton jButtonCancelar;
    private javax.swing.JButton jButtonEditar;
    private javax.swing.JButton jButtonNovo;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTable1;
    private javax.swing.JTextField jTextFieldCliente;
    private javax.swing.JTextField jTextFieldDefeito;
    private javax.swing.JTextField jTextFieldEquipamento;
    private javax.swing.JTextField jTextFieldIdCliente;
    private javax.swing.JTextField jTextFieldOs;
    private javax.swing.JTextField jTextFieldPesquisa;
    private javax.swing.JTextField jTextFieldServico;
    private javax.swing.JTextField jTextFieldTecnico;
    private javax.swing.JTextField jTextFieldTotal;
    // End of variables declaration//GEN-END:variables
}
