
namespace Gerenciador_de_Estoque.VIEW.TelaPedidos
{
    partial class FormPedido
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
            this.lbID = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePickerPedido = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.comboBoxOperacao = new System.Windows.Forms.ComboBox();
            this.lblFrete = new System.Windows.Forms.Label();
            this.txtFrete = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBoxFinanceiro = new System.Windows.Forms.ComboBox();
            this.lblFinanceiro = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            this.dataGridItensPedido = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMsgOperacao = new System.Windows.Forms.Label();
            this.lblMsgFrete = new System.Windows.Forms.Label();
            this.lblMsgStatus = new System.Windows.Forms.Label();
            this.lblMsgFinanceiro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItensPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(12, 36);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 17);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblData.Location = new System.Drawing.Point(88, 36);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 17);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // dateTimePickerPedido
            // 
            this.dateTimePickerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPedido.Location = new System.Drawing.Point(68, 56);
            this.dateTimePickerPedido.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerPedido.Name = "dateTimePickerPedido";
            this.dateTimePickerPedido.Size = new System.Drawing.Size(158, 24);
            this.dateTimePickerPedido.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtID.Location = new System.Drawing.Point(12, 56);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 24);
            this.txtID.TabIndex = 3;
            // 
            // txtPessoa
            // 
            this.txtPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPessoa.Location = new System.Drawing.Point(12, 112);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(311, 24);
            this.txtPessoa.TabIndex = 5;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPessoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPessoa.Location = new System.Drawing.Point(12, 92);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(115, 17);
            this.lblPessoa.TabIndex = 4;
            this.lblPessoa.Text = "Pessoa/Empresa";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOperacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOperacao.Location = new System.Drawing.Point(12, 150);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(71, 17);
            this.lblOperacao.TabIndex = 6;
            this.lblOperacao.Text = "Operação";
            // 
            // comboBoxOperacao
            // 
            this.comboBoxOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxOperacao.FormattingEnabled = true;
            this.comboBoxOperacao.Location = new System.Drawing.Point(12, 170);
            this.comboBoxOperacao.Name = "comboBoxOperacao";
            this.comboBoxOperacao.Size = new System.Drawing.Size(141, 26);
            this.comboBoxOperacao.TabIndex = 7;
            this.comboBoxOperacao.TextChanged += new System.EventHandler(this.comboBoxOperacao_TextChanged);
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFrete.Location = new System.Drawing.Point(181, 150);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(41, 17);
            this.lblFrete.TabIndex = 8;
            this.lblFrete.Text = "Frete";
            // 
            // txtFrete
            // 
            this.txtFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFrete.Location = new System.Drawing.Point(159, 172);
            this.txtFrete.Name = "txtFrete";
            this.txtFrete.Size = new System.Drawing.Size(107, 24);
            this.txtFrete.TabIndex = 9;
            this.txtFrete.TextChanged += new System.EventHandler(this.txtFrete_TextChanged);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(12, 228);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(141, 26);
            this.comboBoxStatus.TabIndex = 11;
            this.comboBoxStatus.TextChanged += new System.EventHandler(this.comboBoxStatus_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(12, 208);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // comboBoxFinanceiro
            // 
            this.comboBoxFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxFinanceiro.FormattingEnabled = true;
            this.comboBoxFinanceiro.Location = new System.Drawing.Point(12, 288);
            this.comboBoxFinanceiro.Name = "comboBoxFinanceiro";
            this.comboBoxFinanceiro.Size = new System.Drawing.Size(141, 26);
            this.comboBoxFinanceiro.TabIndex = 13;
            this.comboBoxFinanceiro.TextChanged += new System.EventHandler(this.comboBoxFinanceiro_TextChanged);
            // 
            // lblFinanceiro
            // 
            this.lblFinanceiro.AutoSize = true;
            this.lblFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFinanceiro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinanceiro.Location = new System.Drawing.Point(12, 268);
            this.lblFinanceiro.Name = "lblFinanceiro";
            this.lblFinanceiro.Size = new System.Drawing.Size(74, 17);
            this.lblFinanceiro.TabIndex = 12;
            this.lblFinanceiro.Text = "Financeiro";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblItens.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblItens.Location = new System.Drawing.Point(326, 36);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(86, 17);
            this.lblItens.TabIndex = 14;
            this.lblItens.Text = "Itens Pedido";
            // 
            // dataGridItensPedido
            // 
            this.dataGridItensPedido.AllowUserToAddRows = false;
            this.dataGridItensPedido.AllowUserToDeleteRows = false;
            this.dataGridItensPedido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItensPedido.Location = new System.Drawing.Point(329, 56);
            this.dataGridItensPedido.Name = "dataGridItensPedido";
            this.dataGridItensPedido.ReadOnly = true;
            this.dataGridItensPedido.Size = new System.Drawing.Size(400, 246);
            this.dataGridItensPedido.TabIndex = 15;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnOk.Location = new System.Drawing.Point(557, 308);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 40);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancelar.Location = new System.Drawing.Point(646, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 40);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 33);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTitulo.Location = new System.Drawing.Point(309, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pedidos";
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitulo_MouseDown);
            // 
            // lblMsgOperacao
            // 
            this.lblMsgOperacao.AutoSize = true;
            this.lblMsgOperacao.ForeColor = System.Drawing.Color.Red;
            this.lblMsgOperacao.Location = new System.Drawing.Point(78, 154);
            this.lblMsgOperacao.Name = "lblMsgOperacao";
            this.lblMsgOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblMsgOperacao.TabIndex = 19;
            // 
            // lblMsgFrete
            // 
            this.lblMsgFrete.AutoSize = true;
            this.lblMsgFrete.ForeColor = System.Drawing.Color.Red;
            this.lblMsgFrete.Location = new System.Drawing.Point(217, 155);
            this.lblMsgFrete.Name = "lblMsgFrete";
            this.lblMsgFrete.Size = new System.Drawing.Size(0, 13);
            this.lblMsgFrete.TabIndex = 20;
            // 
            // lblMsgStatus
            // 
            this.lblMsgStatus.AutoSize = true;
            this.lblMsgStatus.ForeColor = System.Drawing.Color.Red;
            this.lblMsgStatus.Location = new System.Drawing.Point(57, 213);
            this.lblMsgStatus.Name = "lblMsgStatus";
            this.lblMsgStatus.Size = new System.Drawing.Size(0, 13);
            this.lblMsgStatus.TabIndex = 21;
            // 
            // lblMsgFinanceiro
            // 
            this.lblMsgFinanceiro.AutoSize = true;
            this.lblMsgFinanceiro.ForeColor = System.Drawing.Color.Red;
            this.lblMsgFinanceiro.Location = new System.Drawing.Point(81, 273);
            this.lblMsgFinanceiro.Name = "lblMsgFinanceiro";
            this.lblMsgFinanceiro.Size = new System.Drawing.Size(0, 13);
            this.lblMsgFinanceiro.TabIndex = 22;
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 360);
            this.Controls.Add(this.lblMsgFinanceiro);
            this.Controls.Add(this.lblMsgStatus);
            this.Controls.Add(this.lblMsgFrete);
            this.Controls.Add(this.lblMsgOperacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dataGridItensPedido);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.comboBoxFinanceiro);
            this.Controls.Add(this.lblFinanceiro);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtFrete);
            this.Controls.Add(this.lblFrete);
            this.Controls.Add(this.comboBoxOperacao);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtPessoa);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dateTimePickerPedido);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(741, 360);
            this.MinimumSize = new System.Drawing.Size(741, 360);
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedido";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItensPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePickerPedido;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.ComboBox comboBoxOperacao;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.TextBox txtFrete;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBoxFinanceiro;
        private System.Windows.Forms.Label lblFinanceiro;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.DataGridView dataGridItensPedido;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMsgOperacao;
        private System.Windows.Forms.Label lblMsgFrete;
        private System.Windows.Forms.Label lblMsgStatus;
        private System.Windows.Forms.Label lblMsgFinanceiro;
    }
}