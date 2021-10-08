using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gerenciador_de_Estoque.MODEL;

namespace Gerenciador_de_Estoque.VIEW.TelaPedidos
{
    public partial class FormPedido : Form
    {

        private String operacao;
        private List<ItemNoPedido> itens = new List<ItemNoPedido>();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public FormPedido()
        {
            InitializeComponent();
            operacao = "CRIAR";
        }

        public FormPedido(Pedido pedido)
        {
            InitializeComponent();
            operacao = "ALTERAR";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void GerarCbBoxFinanceiro()
        {
            comboBoxFinanceiro.Items.Add("Pago");
            comboBoxFinanceiro.Items.Add("Fiado");
            comboBoxFinanceiro.Text = "Pago";
        }

        private void GerarCbBoxOperacao()
        {
            comboBoxOperacao.Items.Add("ENTRADA");
            comboBoxOperacao.Items.Add("SAIDA");
            comboBoxOperacao.Text = "SAIDA";
        }

        private void GerarCbBoxStatus()
        {
            comboBoxStatus.Items.Add("Aberto");
            comboBoxStatus.Items.Add("Fechado");
            comboBoxStatus.Items.Add("Cancelado");
            comboBoxStatus.Text = "Aberto";
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            GerarCbBoxStatus();
            GerarCbBoxOperacao();
            GerarCbBoxFinanceiro();
        }
    }
}
