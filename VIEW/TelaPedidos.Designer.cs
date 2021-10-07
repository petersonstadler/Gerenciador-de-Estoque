
namespace Gerenciador_de_Estoque.VIEW
{
    partial class TelaPedidos1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            this.dataGridPedidos = new System.Windows.Forms.DataGridView();
            this.dataGridItens = new System.Windows.Forms.DataGridView();
            this.lblX = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.05732F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.94268F));
            this.tableLayoutPanel1.Controls.Add(this.lblPedidos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblItens, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridPedidos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridItens, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 427);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPedidos.Location = new System.Drawing.Point(3, 0);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(83, 25);
            this.lblPedidos.TabIndex = 0;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItens.Location = new System.Drawing.Point(398, 0);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(54, 25);
            this.lblItens.TabIndex = 1;
            this.lblItens.Text = "Itens";
            // 
            // dataGridPedidos
            // 
            this.dataGridPedidos.AllowUserToAddRows = false;
            this.dataGridPedidos.AllowUserToDeleteRows = false;
            this.dataGridPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPedidos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedidos.Location = new System.Drawing.Point(3, 28);
            this.dataGridPedidos.Name = "dataGridPedidos";
            this.dataGridPedidos.ReadOnly = true;
            this.dataGridPedidos.Size = new System.Drawing.Size(389, 396);
            this.dataGridPedidos.TabIndex = 2;
            // 
            // dataGridItens
            // 
            this.dataGridItens.AllowUserToAddRows = false;
            this.dataGridItens.AllowUserToDeleteRows = false;
            this.dataGridItens.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridItens.Location = new System.Drawing.Point(398, 28);
            this.dataGridItens.Name = "dataGridItens";
            this.dataGridItens.ReadOnly = true;
            this.dataGridItens.Size = new System.Drawing.Size(227, 396);
            this.dataGridItens.TabIndex = 3;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(12, 12);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 17);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // TelaPedidos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 451);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPedidos1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPedidos";
            this.Load += new System.EventHandler(this.TelaPedidos_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.DataGridView dataGridPedidos;
        private System.Windows.Forms.DataGridView dataGridItens;
    }
}