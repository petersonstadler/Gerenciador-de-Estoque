﻿
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBoxFinanceiro = new System.Windows.Forms.ComboBox();
            this.lblFinanceiro = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            this.dataGridItensPedido = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbID.Location = new System.Drawing.Point(12, 9);
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
            this.lblData.Location = new System.Drawing.Point(88, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 17);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // dateTimePickerPedido
            // 
            this.dateTimePickerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPedido.Location = new System.Drawing.Point(68, 29);
            this.dateTimePickerPedido.MinDate = new System.DateTime(2011, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerPedido.Name = "dateTimePickerPedido";
            this.dateTimePickerPedido.Size = new System.Drawing.Size(158, 24);
            this.dateTimePickerPedido.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtID.Location = new System.Drawing.Point(12, 29);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(50, 24);
            this.txtID.TabIndex = 3;
            // 
            // txtPessoa
            // 
            this.txtPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPessoa.Location = new System.Drawing.Point(12, 85);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(311, 24);
            this.txtPessoa.TabIndex = 5;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPessoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPessoa.Location = new System.Drawing.Point(12, 65);
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
            this.lblOperacao.Location = new System.Drawing.Point(12, 123);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(71, 17);
            this.lblOperacao.TabIndex = 6;
            this.lblOperacao.Text = "Operação";
            // 
            // comboBoxOperacao
            // 
            this.comboBoxOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxOperacao.FormattingEnabled = true;
            this.comboBoxOperacao.Location = new System.Drawing.Point(12, 143);
            this.comboBoxOperacao.Name = "comboBoxOperacao";
            this.comboBoxOperacao.Size = new System.Drawing.Size(141, 26);
            this.comboBoxOperacao.TabIndex = 7;
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFrete.Location = new System.Drawing.Point(181, 123);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(41, 17);
            this.lblFrete.TabIndex = 8;
            this.lblFrete.Text = "Frete";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(159, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 24);
            this.textBox1.TabIndex = 9;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(12, 201);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(141, 26);
            this.comboBoxStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(12, 181);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // comboBoxFinanceiro
            // 
            this.comboBoxFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxFinanceiro.FormattingEnabled = true;
            this.comboBoxFinanceiro.Location = new System.Drawing.Point(12, 261);
            this.comboBoxFinanceiro.Name = "comboBoxFinanceiro";
            this.comboBoxFinanceiro.Size = new System.Drawing.Size(141, 26);
            this.comboBoxFinanceiro.TabIndex = 13;
            // 
            // lblFinanceiro
            // 
            this.lblFinanceiro.AutoSize = true;
            this.lblFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFinanceiro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinanceiro.Location = new System.Drawing.Point(12, 241);
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
            this.lblItens.Location = new System.Drawing.Point(326, 9);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(86, 17);
            this.lblItens.TabIndex = 14;
            this.lblItens.Text = "Itens Pedido";
            // 
            // dataGridItensPedido
            // 
            this.dataGridItensPedido.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItensPedido.Location = new System.Drawing.Point(329, 29);
            this.dataGridItensPedido.Name = "dataGridItensPedido";
            this.dataGridItensPedido.Size = new System.Drawing.Size(400, 273);
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
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 360);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dataGridItensPedido);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.comboBoxFinanceiro);
            this.Controls.Add(this.lblFinanceiro);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.textBox1);
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
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItensPedido)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBoxFinanceiro;
        private System.Windows.Forms.Label lblFinanceiro;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.DataGridView dataGridItensPedido;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
    }
}