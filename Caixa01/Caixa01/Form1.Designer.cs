namespace Caixa01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picProd = new System.Windows.Forms.PictureBox();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.listProd = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picProd
            // 
            this.picProd.BackColor = System.Drawing.Color.Transparent;
            this.picProd.Location = new System.Drawing.Point(216, 126);
            this.picProd.Name = "picProd";
            this.picProd.Size = new System.Drawing.Size(215, 200);
            this.picProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProd.TabIndex = 1;
            this.picProd.TabStop = false;
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.BackColor = System.Drawing.Color.Transparent;
            this.lblProd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProd.Location = new System.Drawing.Point(213, 30);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(69, 13);
            this.lblProd.TabIndex = 2;
            this.lblProd.Text = "Cod Produto:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(472, 251);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(288, 27);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 4;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(522, 248);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // listProd
            // 
            this.listProd.FormattingEnabled = true;
            this.listProd.Location = new System.Drawing.Point(466, 30);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(164, 173);
            this.listProd.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caixa01.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.picProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picProd;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox listProd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

