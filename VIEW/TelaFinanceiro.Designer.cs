
namespace Gerenciador_de_Estoque.VIEW
{
    partial class TelaFinanceiro
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
            this.lblFiltrarDe = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.dataInicialPicker = new System.Windows.Forms.DateTimePicker();
            this.dataFinalPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panelApoioDeCima = new System.Windows.Forms.Panel();
            this.panelApoioDeBaixo = new System.Windows.Forms.Panel();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.cardFaturamento = new System.Windows.Forms.Panel();
            this.cardLucro = new System.Windows.Forms.Panel();
            this.cardLucroVendas = new System.Windows.Forms.Panel();
            this.labelFaturamentoTotal = new System.Windows.Forms.Label();
            this.lblLucroLiquido = new System.Windows.Forms.Label();
            this.lblValorFaturamentoTotal = new System.Windows.Forms.Label();
            this.lblValorLucroLiquido = new System.Windows.Forms.Label();
            this.lblValorLucroVendas = new System.Windows.Forms.Label();
            this.lblLucroDeVendas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorFiado = new System.Windows.Forms.Label();
            this.lblFiado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblValorDividas = new System.Windows.Forms.Label();
            this.lblDividas = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblValorGastos = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.panelCentral.SuspendLayout();
            this.cardFaturamento.SuspendLayout();
            this.cardLucro.SuspendLayout();
            this.cardLucroVendas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFiltrarDe
            // 
            this.lblFiltrarDe.AutoSize = true;
            this.lblFiltrarDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFiltrarDe.Location = new System.Drawing.Point(12, 9);
            this.lblFiltrarDe.Name = "lblFiltrarDe";
            this.lblFiltrarDe.Size = new System.Drawing.Size(79, 20);
            this.lblFiltrarDe.TabIndex = 0;
            this.lblFiltrarDe.Text = "Filtrar de: ";
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAte.Location = new System.Drawing.Point(279, 9);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(34, 20);
            this.lblAte.TabIndex = 1;
            this.lblAte.Text = "Até";
            // 
            // dataInicialPicker
            // 
            this.dataInicialPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataInicialPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicialPicker.Location = new System.Drawing.Point(97, 9);
            this.dataInicialPicker.Name = "dataInicialPicker";
            this.dataInicialPicker.Size = new System.Drawing.Size(176, 20);
            this.dataInicialPicker.TabIndex = 2;
            // 
            // dataFinalPicker
            // 
            this.dataFinalPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dataFinalPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinalPicker.Location = new System.Drawing.Point(319, 9);
            this.dataFinalPicker.Name = "dataFinalPicker";
            this.dataFinalPicker.Size = new System.Drawing.Size(176, 20);
            this.dataFinalPicker.TabIndex = 3;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAtualizar.Location = new System.Drawing.Point(501, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(162, 30);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar Informações";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // panelApoioDeCima
            // 
            this.panelApoioDeCima.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelApoioDeCima.Location = new System.Drawing.Point(12, 35);
            this.panelApoioDeCima.Name = "panelApoioDeCima";
            this.panelApoioDeCima.Size = new System.Drawing.Size(651, 36);
            this.panelApoioDeCima.TabIndex = 5;
            // 
            // panelApoioDeBaixo
            // 
            this.panelApoioDeBaixo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelApoioDeBaixo.Location = new System.Drawing.Point(12, 403);
            this.panelApoioDeBaixo.Name = "panelApoioDeBaixo";
            this.panelApoioDeBaixo.Size = new System.Drawing.Size(651, 36);
            this.panelApoioDeBaixo.TabIndex = 6;
            // 
            // panelCentral
            // 
            this.panelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCentral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCentral.Controls.Add(this.panel1);
            this.panelCentral.Controls.Add(this.panel2);
            this.panelCentral.Controls.Add(this.panel3);
            this.panelCentral.Controls.Add(this.cardLucroVendas);
            this.panelCentral.Controls.Add(this.cardLucro);
            this.panelCentral.Controls.Add(this.cardFaturamento);
            this.panelCentral.Location = new System.Drawing.Point(12, 77);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(651, 320);
            this.panelCentral.TabIndex = 7;
            // 
            // cardFaturamento
            // 
            this.cardFaturamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardFaturamento.BackColor = System.Drawing.Color.RoyalBlue;
            this.cardFaturamento.Controls.Add(this.lblValorFaturamentoTotal);
            this.cardFaturamento.Controls.Add(this.labelFaturamentoTotal);
            this.cardFaturamento.Location = new System.Drawing.Point(3, 3);
            this.cardFaturamento.Name = "cardFaturamento";
            this.cardFaturamento.Size = new System.Drawing.Size(211, 100);
            this.cardFaturamento.TabIndex = 0;
            // 
            // cardLucro
            // 
            this.cardLucro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardLucro.BackColor = System.Drawing.Color.Green;
            this.cardLucro.Controls.Add(this.lblValorLucroLiquido);
            this.cardLucro.Controls.Add(this.lblLucroLiquido);
            this.cardLucro.Location = new System.Drawing.Point(220, 3);
            this.cardLucro.Name = "cardLucro";
            this.cardLucro.Size = new System.Drawing.Size(211, 100);
            this.cardLucro.TabIndex = 1;
            // 
            // cardLucroVendas
            // 
            this.cardLucroVendas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardLucroVendas.BackColor = System.Drawing.Color.DarkGreen;
            this.cardLucroVendas.Controls.Add(this.lblValorLucroVendas);
            this.cardLucroVendas.Controls.Add(this.lblLucroDeVendas);
            this.cardLucroVendas.Location = new System.Drawing.Point(437, 3);
            this.cardLucroVendas.Name = "cardLucroVendas";
            this.cardLucroVendas.Size = new System.Drawing.Size(211, 100);
            this.cardLucroVendas.TabIndex = 1;
            // 
            // labelFaturamentoTotal
            // 
            this.labelFaturamentoTotal.AutoSize = true;
            this.labelFaturamentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelFaturamentoTotal.Location = new System.Drawing.Point(3, 7);
            this.labelFaturamentoTotal.Name = "labelFaturamentoTotal";
            this.labelFaturamentoTotal.Size = new System.Drawing.Size(188, 26);
            this.labelFaturamentoTotal.TabIndex = 0;
            this.labelFaturamentoTotal.Text = "Faturamento Total";
            // 
            // lblLucroLiquido
            // 
            this.lblLucroLiquido.AutoSize = true;
            this.lblLucroLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLucroLiquido.Location = new System.Drawing.Point(3, 7);
            this.lblLucroLiquido.Name = "lblLucroLiquido";
            this.lblLucroLiquido.Size = new System.Drawing.Size(142, 26);
            this.lblLucroLiquido.TabIndex = 0;
            this.lblLucroLiquido.Text = "Lucro Liquido";
            // 
            // lblValorFaturamentoTotal
            // 
            this.lblValorFaturamentoTotal.AutoSize = true;
            this.lblValorFaturamentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblValorFaturamentoTotal.Location = new System.Drawing.Point(3, 46);
            this.lblValorFaturamentoTotal.Name = "lblValorFaturamentoTotal";
            this.lblValorFaturamentoTotal.Size = new System.Drawing.Size(52, 26);
            this.lblValorFaturamentoTotal.TabIndex = 0;
            this.lblValorFaturamentoTotal.Text = "R$0";
            // 
            // lblValorLucroLiquido
            // 
            this.lblValorLucroLiquido.AutoSize = true;
            this.lblValorLucroLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblValorLucroLiquido.Location = new System.Drawing.Point(3, 46);
            this.lblValorLucroLiquido.Name = "lblValorLucroLiquido";
            this.lblValorLucroLiquido.Size = new System.Drawing.Size(52, 26);
            this.lblValorLucroLiquido.TabIndex = 1;
            this.lblValorLucroLiquido.Text = "R$0";
            // 
            // lblValorLucroVendas
            // 
            this.lblValorLucroVendas.AutoSize = true;
            this.lblValorLucroVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblValorLucroVendas.Location = new System.Drawing.Point(3, 46);
            this.lblValorLucroVendas.Name = "lblValorLucroVendas";
            this.lblValorLucroVendas.Size = new System.Drawing.Size(52, 26);
            this.lblValorLucroVendas.TabIndex = 3;
            this.lblValorLucroVendas.Text = "R$0";
            // 
            // lblLucroDeVendas
            // 
            this.lblLucroDeVendas.AutoSize = true;
            this.lblLucroDeVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLucroDeVendas.Location = new System.Drawing.Point(3, 7);
            this.lblLucroDeVendas.Name = "lblLucroDeVendas";
            this.lblLucroDeVendas.Size = new System.Drawing.Size(146, 26);
            this.lblLucroDeVendas.TabIndex = 2;
            this.lblLucroDeVendas.Text = "Lucro Vendas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lblValorFiado);
            this.panel1.Controls.Add(this.lblFiado);
            this.panel1.Location = new System.Drawing.Point(437, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 100);
            this.panel1.TabIndex = 4;
            // 
            // lblValorFiado
            // 
            this.lblValorFiado.AutoSize = true;
            this.lblValorFiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblValorFiado.Location = new System.Drawing.Point(3, 46);
            this.lblValorFiado.Name = "lblValorFiado";
            this.lblValorFiado.Size = new System.Drawing.Size(52, 26);
            this.lblValorFiado.TabIndex = 3;
            this.lblValorFiado.Text = "R$0";
            // 
            // lblFiado
            // 
            this.lblFiado.AutoSize = true;
            this.lblFiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblFiado.Location = new System.Drawing.Point(3, 7);
            this.lblFiado.Name = "lblFiado";
            this.lblFiado.Size = new System.Drawing.Size(66, 26);
            this.lblFiado.TabIndex = 2;
            this.lblFiado.Text = "Fiado";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.lblValorDividas);
            this.panel2.Controls.Add(this.lblDividas);
            this.panel2.Location = new System.Drawing.Point(220, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 100);
            this.panel2.TabIndex = 3;
            // 
            // lblValorDividas
            // 
            this.lblValorDividas.AutoSize = true;
            this.lblValorDividas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblValorDividas.Location = new System.Drawing.Point(3, 46);
            this.lblValorDividas.Name = "lblValorDividas";
            this.lblValorDividas.Size = new System.Drawing.Size(52, 26);
            this.lblValorDividas.TabIndex = 1;
            this.lblValorDividas.Text = "R$0";
            // 
            // lblDividas
            // 
            this.lblDividas.AutoSize = true;
            this.lblDividas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDividas.Location = new System.Drawing.Point(3, 7);
            this.lblDividas.Name = "lblDividas";
            this.lblDividas.Size = new System.Drawing.Size(84, 26);
            this.lblDividas.TabIndex = 0;
            this.lblDividas.Text = "Dividas";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.lblValorGastos);
            this.panel3.Controls.Add(this.lblGastos);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 100);
            this.panel3.TabIndex = 2;
            // 
            // lblValorGastos
            // 
            this.lblValorGastos.AutoSize = true;
            this.lblValorGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblValorGastos.Location = new System.Drawing.Point(3, 46);
            this.lblValorGastos.Name = "lblValorGastos";
            this.lblValorGastos.Size = new System.Drawing.Size(52, 26);
            this.lblValorGastos.TabIndex = 0;
            this.lblValorGastos.Text = "R$0";
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblGastos.Location = new System.Drawing.Point(3, 7);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(81, 26);
            this.lblGastos.TabIndex = 0;
            this.lblGastos.Text = "Gastos";
            // 
            // TelaFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 451);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelApoioDeBaixo);
            this.Controls.Add(this.panelApoioDeCima);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataFinalPicker);
            this.Controls.Add(this.dataInicialPicker);
            this.Controls.Add(this.lblAte);
            this.Controls.Add(this.lblFiltrarDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaFinanceiro";
            this.Text = "TelaFinanceiro";
            this.panelCentral.ResumeLayout(false);
            this.cardFaturamento.ResumeLayout(false);
            this.cardFaturamento.PerformLayout();
            this.cardLucro.ResumeLayout(false);
            this.cardLucro.PerformLayout();
            this.cardLucroVendas.ResumeLayout(false);
            this.cardLucroVendas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrarDe;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.DateTimePicker dataInicialPicker;
        private System.Windows.Forms.DateTimePicker dataFinalPicker;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panelApoioDeCima;
        private System.Windows.Forms.Panel panelApoioDeBaixo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel cardFaturamento;
        private System.Windows.Forms.Panel cardLucroVendas;
        private System.Windows.Forms.Panel cardLucro;
        private System.Windows.Forms.Label lblValorLucroLiquido;
        private System.Windows.Forms.Label lblLucroLiquido;
        private System.Windows.Forms.Label lblValorFaturamentoTotal;
        private System.Windows.Forms.Label labelFaturamentoTotal;
        private System.Windows.Forms.Label lblValorLucroVendas;
        private System.Windows.Forms.Label lblLucroDeVendas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorFiado;
        private System.Windows.Forms.Label lblFiado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblValorDividas;
        private System.Windows.Forms.Label lblDividas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblValorGastos;
        private System.Windows.Forms.Label lblGastos;
    }
}