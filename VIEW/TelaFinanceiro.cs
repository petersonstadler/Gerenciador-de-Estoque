using System.Windows.Forms;
using Gerenciador_de_Estoque.MODEL;
using Gerenciador_de_Estoque.DAO;
using System;

namespace Gerenciador_de_Estoque.VIEW
{
    public partial class TelaFinanceiro : Form
    {
        private Financeiro financeiro = new Financeiro();

        public TelaFinanceiro()
        {
            InitializeComponent();
        }

        private void TelaFinanceiro_Load(object sender, EventArgs e)
        {
            financeiro.DataInicial = new DateTime(2018, 01, 01, 00, 00, 00);
            financeiro.DataFinal = DateTime.Now;
            GerarFinanceiro();
        }

        private void GerarFinanceiro()
        {
            CalcularFaturamento();
            CalcularGastos();
            CalcularLucro();
            CalcularLucroVendas();
            CalcularDividas();
            CalcularFiado();
        }

        private void CalcularFaturamento()
        {
            FinanceiroDAO financeiroDAO = new FinanceiroDAO();
            financeiro.Faturamento = financeiroDAO.CalcularFaturamentoPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            financeiroDAO.CloseConnections();
            lblValorFaturamentoTotal.Text = "R$" + financeiro.Faturamento;
        }

        private void CalcularGastos()
        {
            FinanceiroDAO financeiroDAO = new FinanceiroDAO();
            financeiro.Gastos = financeiroDAO.CalcularGastosPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            financeiroDAO.CloseConnections();
            lblValorGastos.Text = "R$" + financeiro.Gastos;
        }

        private void CalcularLucro()
        {
            financeiro.CalcularLucro();
            lblValorLucroLiquido.Text = "R$" + financeiro.Lucro;
        }

        private void CalcularLucroVendas()
        {
            FinanceiroDAO financeiroDAO = new FinanceiroDAO();
            financeiro.LucroDasVendas = financeiroDAO.CalcularLucroDeVendasPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            financeiroDAO.CloseConnections();
            lblValorLucroVendas.Text = "R$" + financeiro.LucroDasVendas;
        }

        private void CalcularDividas()
        {
            FinanceiroDAO financeiroDAO = new FinanceiroDAO();
            financeiro.Dividas = financeiroDAO.CalcularDividasPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            financeiroDAO.CloseConnections();
            lblValorDividas.Text = "R$" + financeiro.Dividas;
        }

        private void CalcularFiado()
        {
            FinanceiroDAO financeiroDAO = new FinanceiroDAO();
            financeiro.Fiado = financeiroDAO.CalcularFiadosPorPeriodo(financeiro.DataInicial, financeiro.DataFinal);
            financeiroDAO.CloseConnections();
            lblValorFiado.Text = "R$" + financeiro.Fiado;
        }
    }
}
