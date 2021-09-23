
namespace Gerenciador_de_Estoque
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconDiminuir = new System.Windows.Forms.PictureBox();
            this.iconAumentar = new System.Windows.Forms.PictureBox();
            this.iconFechar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDiminuir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAumentar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BarraTitulo.Controls.Add(this.iconMinimizar);
            this.BarraTitulo.Controls.Add(this.iconDiminuir);
            this.BarraTitulo.Controls.Add(this.iconAumentar);
            this.BarraTitulo.Controls.Add(this.iconFechar);
            this.BarraTitulo.Controls.Add(this.btnSlide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(250, 50);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1050, 600);
            this.panelPrincipal.TabIndex = 2;
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Gerenciador_de_Estoque.Properties.Resources.minimizarIcon;
            this.iconMinimizar.Location = new System.Drawing.Point(966, 9);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.TabIndex = 4;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconDiminuir
            // 
            this.iconDiminuir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconDiminuir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDiminuir.Image = global::Gerenciador_de_Estoque.Properties.Resources.diminuirIcon;
            this.iconDiminuir.Location = new System.Drawing.Point(992, 9);
            this.iconDiminuir.Name = "iconDiminuir";
            this.iconDiminuir.Size = new System.Drawing.Size(20, 20);
            this.iconDiminuir.TabIndex = 3;
            this.iconDiminuir.TabStop = false;
            this.iconDiminuir.Visible = false;
            this.iconDiminuir.Click += new System.EventHandler(this.iconDiminuir_Click);
            // 
            // iconAumentar
            // 
            this.iconAumentar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconAumentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAumentar.Image = global::Gerenciador_de_Estoque.Properties.Resources.aumentarIcon;
            this.iconAumentar.Location = new System.Drawing.Point(992, 9);
            this.iconAumentar.Name = "iconAumentar";
            this.iconAumentar.Size = new System.Drawing.Size(20, 20);
            this.iconAumentar.TabIndex = 2;
            this.iconAumentar.TabStop = false;
            this.iconAumentar.Click += new System.EventHandler(this.iconAumentar_Click);
            // 
            // iconFechar
            // 
            this.iconFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconFechar.Image = global::Gerenciador_de_Estoque.Properties.Resources.Xiconcerto;
            this.iconFechar.Location = new System.Drawing.Point(1018, 9);
            this.iconFechar.Name = "iconFechar";
            this.iconFechar.Size = new System.Drawing.Size(20, 20);
            this.iconFechar.TabIndex = 1;
            this.iconFechar.TabStop = false;
            this.iconFechar.Click += new System.EventHandler(this.iconFechar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide.Image = global::Gerenciador_de_Estoque.Properties.Resources.menuIcon;
            this.btnSlide.Location = new System.Drawing.Point(6, 9);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(35, 35);
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Produtos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Text = "Principal";
            this.MenuVertical.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDiminuir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAumentar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconFechar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconDiminuir;
        private System.Windows.Forms.PictureBox iconAumentar;
        private System.Windows.Forms.Button button1;
    }
}

