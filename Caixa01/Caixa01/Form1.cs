using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa01
{
    public partial class Form1 : Form
    {
        string[] codProd = new string[6];
        string[] nomeProd = new string[6];
        decimal[] valorProd = new decimal[6];
        decimal somaTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProdutos();
            somaTotal = 0;
        }
        private void loadProdutos() {
            codProd[1] = "12345";
            codProd[2] = "12346";
            codProd[3] = "12347";
            codProd[4] = "12348";
            codProd[5] = "12349";
            

            nomeProd[1] = "Cadeira Aconchegante";
            nomeProd[2] = "Tinta Branca";
            nomeProd[3] = "Suco de Fruta";
            nomeProd[4] = "Luvas Latex";
            nomeProd[5] = "Aliviador de Stress";

            valorProd[1] = 159.99M;
            valorProd[2] = 69.99M;
            valorProd[3] = 25M;
            valorProd[4] = 14.99M;
            valorProd[5] = 259.99M;

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text.Length == 5)
            {
                int ind = 0;

                for (int i = 1; i < 6; i++) {
                    if (txtCod.Text == codProd[i]) {
                        ind = i;
                    }
                }
                if (ind > 0)
                {
                    listProd.Items.Add(string.Format("#{0} - {1} - {2:C}", codProd [ind],nomeProd[ind],valorProd[ind]));
                    picProd.ImageLocation = "C:/Users/pessoal/Desktop/C#/" + codProd[ind] + ".png";
                    somaTotal += valorProd[ind];
                    txtTotal.Text = Convert.ToString(somaTotal);
                    txtCod.Text = "";
                    txtCod.Focus();
                }
                else {
                    MessageBox.Show("Produto não encontrado");
                }
            }
        }
    }

}
