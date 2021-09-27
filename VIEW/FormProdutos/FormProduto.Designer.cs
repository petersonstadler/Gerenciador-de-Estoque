﻿
namespace Gerenciador_de_Estoque.VIEW.FormProdutos
{
    partial class FormProduto
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
            this.lbId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.cbBoxTamanho = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbBoxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblVenda = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.ckBoxAtivo = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbId.Location = new System.Drawing.Point(12, 61);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 17);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtID.Location = new System.Drawing.Point(39, 58);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(37, 23);
            this.txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNome.Location = new System.Drawing.Point(133, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(305, 23);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNome.Location = new System.Drawing.Point(82, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 33);
            this.panel1.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitulo.Location = new System.Drawing.Point(176, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(98, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Produto";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescricao.Location = new System.Drawing.Point(12, 84);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescricao.Location = new System.Drawing.Point(12, 104);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(426, 94);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTamanho.Location = new System.Drawing.Point(12, 205);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(68, 17);
            this.lblTamanho.TabIndex = 7;
            this.lblTamanho.Text = "Tamanho";
            // 
            // cbBoxTamanho
            // 
            this.cbBoxTamanho.FormattingEnabled = true;
            this.cbBoxTamanho.Location = new System.Drawing.Point(86, 204);
            this.cbBoxTamanho.Name = "cbBoxTamanho";
            this.cbBoxTamanho.Size = new System.Drawing.Size(66, 21);
            this.cbBoxTamanho.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCategoria.Location = new System.Drawing.Point(158, 205);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbBoxCategoria
            // 
            this.cbBoxCategoria.FormattingEnabled = true;
            this.cbBoxCategoria.Location = new System.Drawing.Point(233, 204);
            this.cbBoxCategoria.Name = "cbBoxCategoria";
            this.cbBoxCategoria.Size = new System.Drawing.Size(205, 21);
            this.cbBoxCategoria.TabIndex = 10;
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCusto.Location = new System.Drawing.Point(12, 234);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(44, 17);
            this.lblCusto.TabIndex = 11;
            this.lblCusto.Text = "Custo";
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVenda.Location = new System.Drawing.Point(14, 263);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(49, 17);
            this.lblVenda.TabIndex = 12;
            this.lblVenda.Text = "Venda";
            // 
            // txtCusto
            // 
            this.txtCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCusto.Location = new System.Drawing.Point(62, 231);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.ReadOnly = true;
            this.txtCusto.Size = new System.Drawing.Size(90, 23);
            this.txtCusto.TabIndex = 14;
            // 
            // txtVenda
            // 
            this.txtVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVenda.Location = new System.Drawing.Point(62, 260);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.ReadOnly = true;
            this.txtVenda.Size = new System.Drawing.Size(90, 23);
            this.txtVenda.TabIndex = 15;
            // 
            // ckBoxAtivo
            // 
            this.ckBoxAtivo.AutoSize = true;
            this.ckBoxAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ckBoxAtivo.Location = new System.Drawing.Point(5, 323);
            this.ckBoxAtivo.Name = "ckBoxAtivo";
            this.ckBoxAtivo.Size = new System.Drawing.Size(58, 21);
            this.ckBoxAtivo.TabIndex = 16;
            this.ckBoxAtivo.Text = "Ativo";
            this.ckBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(282, 321);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(363, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormProduto
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(450, 356);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ckBoxAtivo);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.cbBoxCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbBoxTamanho);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 356);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 356);
            this.Name = "FormProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.ComboBox cbBoxTamanho;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbBoxCategoria;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.CheckBox ckBoxAtivo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}