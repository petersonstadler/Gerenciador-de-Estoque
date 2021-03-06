using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador_de_Estoque.DAO;
using Gerenciador_de_Estoque.MODEL;
using Gerenciador_de_Estoque.VIEW;
using System.Runtime.InteropServices;

namespace Gerenciador_de_Estoque
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void RedimensionarFormNoPanel()
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                Form fh = (Form)panelPrincipal.Tag;
                fh.WindowState = FormWindowState.Maximized;
                this.panelPrincipal.Controls.RemoveAt(0);
                this.panelPrincipal.Controls.Add(fh);
            }
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if(MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
                RedimensionarFormNoPanel();
            }
            else
            {
                MenuVertical.Width = 250;
                RedimensionarFormNoPanel();
            }
        }

        private void iconFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconAumentar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconDiminuir.Visible = true;
            iconAumentar.Visible = false;
            RedimensionarFormNoPanel();
        }

        private void iconDiminuir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconAumentar.Visible = true;
            iconDiminuir.Visible = false;
            RedimensionarFormNoPanel();
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            RedimensionarFormNoPanel();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object form)
        {
            if(this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new TelaProdutos());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new TelaPedidos1());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            TelaCategorias telaCategorias = new TelaCategorias();
            telaCategorias.ShowDialog();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new TelaFinanceiro());
            /*Financeiro financeiro = new Financeiro();
            FinanceiroDAO financeiroDAO = new FinanceiroDAO();
            financeiro.DataInicial = new DateTime(2021, 8, 1, 8, 30, 00);
            financeiro.DataFinal = DateTime.Now;
            financeiro.Faturamento = financeiroDAO.CalcularFaturamentoPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            financeiro.Gastos = financeiroDAO.CalcularGastosPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            financeiro.Lucro = financeiro.Faturamento - financeiro.Gastos;
            financeiro.Fiado = financeiroDAO.CalcularFiadosPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            financeiro.Dividas = financeiroDAO.CalcularDividasPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            MessageBox.Show("As datas são: " + financeiro.DataInicial + " e " + financeiro.DataFinal + " O faturamento é: " + financeiro.Faturamento + " e os gastos são: " + financeiro.Gastos + " e o lucro é: " + financeiro.Lucro + " e para receber tem: " + financeiro.Fiado + " e suas dividas são: " + financeiro.Dividas);
            financeiroDAO.CloseConnections();*/
        }
    }
}
