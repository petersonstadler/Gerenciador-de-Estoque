﻿
namespace Gerenciador_de_Estoque.VIEW
{
    partial class FormProdutos
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
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.DtProdutos = new System.Windows.Forms.DataGridView();
            this.teste = new System.Windows.Forms.Button();
            this.DtMovimentos = new System.Windows.Forms.DataGridView();
            this.lblMovimentos = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DtProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtMovimentos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProdutos.Location = new System.Drawing.Point(3, 0);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(90, 25);
            this.lblProdutos.TabIndex = 0;
            this.lblProdutos.Text = "Produtos";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(12, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // DtProdutos
            // 
            this.DtProdutos.AllowUserToAddRows = false;
            this.DtProdutos.AllowUserToDeleteRows = false;
            this.DtProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtProdutos.BackgroundColor = System.Drawing.Color.White;
            this.DtProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtProdutos.GridColor = System.Drawing.Color.LightGray;
            this.DtProdutos.Location = new System.Drawing.Point(3, 28);
            this.DtProdutos.Name = "DtProdutos";
            this.DtProdutos.ReadOnly = true;
            this.DtProdutos.Size = new System.Drawing.Size(419, 399);
            this.DtProdutos.TabIndex = 2;
            // 
            // teste
            // 
            this.teste.Location = new System.Drawing.Point(12, 65);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(37, 23);
            this.teste.TabIndex = 3;
            this.teste.Text = "teste";
            this.teste.UseVisualStyleBackColor = true;
            this.teste.Click += new System.EventHandler(this.teste_Click);
            // 
            // DtMovimentos
            // 
            this.DtMovimentos.AllowUserToAddRows = false;
            this.DtMovimentos.AllowUserToDeleteRows = false;
            this.DtMovimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtMovimentos.BackgroundColor = System.Drawing.Color.White;
            this.DtMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtMovimentos.GridColor = System.Drawing.Color.LightGray;
            this.DtMovimentos.Location = new System.Drawing.Point(428, 28);
            this.DtMovimentos.Name = "DtMovimentos";
            this.DtMovimentos.ReadOnly = true;
            this.DtMovimentos.Size = new System.Drawing.Size(177, 399);
            this.DtMovimentos.TabIndex = 4;
            // 
            // lblMovimentos
            // 
            this.lblMovimentos.AutoSize = true;
            this.lblMovimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMovimentos.Location = new System.Drawing.Point(428, 0);
            this.lblMovimentos.Name = "lblMovimentos";
            this.lblMovimentos.Size = new System.Drawing.Size(118, 25);
            this.lblMovimentos.TabIndex = 5;
            this.lblMovimentos.Text = "Movimentos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.DtMovimentos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DtProdutos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMovimentos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProdutos, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(55, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 398);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.teste);
            this.Controls.Add(this.lblX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProdutos";
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtMovimentos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.DataGridView DtProdutos;
        private System.Windows.Forms.Button teste;
        private System.Windows.Forms.DataGridView DtMovimentos;
        private System.Windows.Forms.Label lblMovimentos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}