
namespace Gerenciador_de_Estoque.VIEW.TelaPedidos
{
    partial class SeletorDeProduto
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
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblAcrescimo = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.lblMsgQuantidade = new System.Windows.Forms.Label();
            this.lblMsgPreco = new System.Windows.Forms.Label();
            this.lblMsgDesconto = new System.Windows.Forms.Label();
            this.lblMsgAcrescimo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.AllowUserToAddRows = false;
            this.dataGridProduto.AllowUserToDeleteRows = false;
            this.dataGridProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Location = new System.Drawing.Point(12, 35);
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.ReadOnly = true;
            this.dataGridProduto.Size = new System.Drawing.Size(308, 280);
            this.dataGridProduto.TabIndex = 0;
            this.dataGridProduto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduto_CellEnter);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(351, 325);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancela.Location = new System.Drawing.Point(432, 325);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 2;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantidade.Location = new System.Drawing.Point(376, 56);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPreco.Location = new System.Drawing.Point(376, 108);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(50, 20);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesconto.Location = new System.Drawing.Point(376, 160);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(78, 20);
            this.lblDesconto.TabIndex = 5;
            this.lblDesconto.Text = "Desconto";
            // 
            // lblAcrescimo
            // 
            this.lblAcrescimo.AutoSize = true;
            this.lblAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAcrescimo.Location = new System.Drawing.Point(376, 212);
            this.lblAcrescimo.Name = "lblAcrescimo";
            this.lblAcrescimo.Size = new System.Drawing.Size(83, 20);
            this.lblAcrescimo.TabIndex = 6;
            this.lblAcrescimo.Text = "Acréscimo";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantidade.Location = new System.Drawing.Point(376, 79);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 26);
            this.txtQuantidade.TabIndex = 7;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPreco.Location = new System.Drawing.Point(376, 131);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 26);
            this.txtPreco.TabIndex = 8;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDesconto.Location = new System.Drawing.Point(376, 183);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 26);
            this.txtDesconto.TabIndex = 9;
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAcrescimo.Location = new System.Drawing.Point(376, 235);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(100, 26);
            this.txtAcrescimo.TabIndex = 10;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBusca.Location = new System.Drawing.Point(12, 327);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(308, 21);
            this.txtBusca.TabIndex = 11;
            this.txtBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lblAddItem);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 34);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblAddItem.Location = new System.Drawing.Point(175, 5);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(166, 29);
            this.lblAddItem.TabIndex = 0;
            this.lblAddItem.Text = "Adicionar Item";
            this.lblAddItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAddItem_MouseDown);
            // 
            // lblMsgQuantidade
            // 
            this.lblMsgQuantidade.AutoSize = true;
            this.lblMsgQuantidade.ForeColor = System.Drawing.Color.Red;
            this.lblMsgQuantidade.Location = new System.Drawing.Point(462, 61);
            this.lblMsgQuantidade.Name = "lblMsgQuantidade";
            this.lblMsgQuantidade.Size = new System.Drawing.Size(0, 13);
            this.lblMsgQuantidade.TabIndex = 13;
            // 
            // lblMsgPreco
            // 
            this.lblMsgPreco.AutoSize = true;
            this.lblMsgPreco.ForeColor = System.Drawing.Color.Red;
            this.lblMsgPreco.Location = new System.Drawing.Point(422, 114);
            this.lblMsgPreco.Name = "lblMsgPreco";
            this.lblMsgPreco.Size = new System.Drawing.Size(0, 13);
            this.lblMsgPreco.TabIndex = 14;
            // 
            // lblMsgDesconto
            // 
            this.lblMsgDesconto.AutoSize = true;
            this.lblMsgDesconto.ForeColor = System.Drawing.Color.Red;
            this.lblMsgDesconto.Location = new System.Drawing.Point(449, 165);
            this.lblMsgDesconto.Name = "lblMsgDesconto";
            this.lblMsgDesconto.Size = new System.Drawing.Size(0, 13);
            this.lblMsgDesconto.TabIndex = 15;
            // 
            // lblMsgAcrescimo
            // 
            this.lblMsgAcrescimo.AutoSize = true;
            this.lblMsgAcrescimo.ForeColor = System.Drawing.Color.Red;
            this.lblMsgAcrescimo.Location = new System.Drawing.Point(453, 218);
            this.lblMsgAcrescimo.Name = "lblMsgAcrescimo";
            this.lblMsgAcrescimo.Size = new System.Drawing.Size(0, 13);
            this.lblMsgAcrescimo.TabIndex = 16;
            // 
            // SeletorDeProduto
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancela;
            this.ClientSize = new System.Drawing.Size(529, 360);
            this.Controls.Add(this.lblMsgAcrescimo);
            this.Controls.Add(this.lblMsgDesconto);
            this.Controls.Add(this.lblMsgPreco);
            this.Controls.Add(this.lblMsgQuantidade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.txtAcrescimo);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblAcrescimo);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dataGridProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(529, 360);
            this.MinimumSize = new System.Drawing.Size(529, 360);
            this.Name = "SeletorDeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeletorDeProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblAcrescimo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.Label lblMsgQuantidade;
        private System.Windows.Forms.Label lblMsgPreco;
        private System.Windows.Forms.Label lblMsgDesconto;
        private System.Windows.Forms.Label lblMsgAcrescimo;
    }
}