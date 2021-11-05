
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
            this.panelCentral.SuspendLayout();
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
            this.cardFaturamento.BackColor = System.Drawing.Color.RoyalBlue;
            this.cardFaturamento.Location = new System.Drawing.Point(3, 3);
            this.cardFaturamento.Name = "cardFaturamento";
            this.cardFaturamento.Size = new System.Drawing.Size(211, 100);
            this.cardFaturamento.TabIndex = 0;
            // 
            // cardLucro
            // 
            this.cardLucro.BackColor = System.Drawing.Color.Green;
            this.cardLucro.Location = new System.Drawing.Point(220, 3);
            this.cardLucro.Name = "cardLucro";
            this.cardLucro.Size = new System.Drawing.Size(211, 100);
            this.cardLucro.TabIndex = 1;
            // 
            // cardLucroVendas
            // 
            this.cardLucroVendas.BackColor = System.Drawing.Color.DarkGreen;
            this.cardLucroVendas.Location = new System.Drawing.Point(437, 3);
            this.cardLucroVendas.Name = "cardLucroVendas";
            this.cardLucroVendas.Size = new System.Drawing.Size(211, 100);
            this.cardLucroVendas.TabIndex = 1;
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
    }
}