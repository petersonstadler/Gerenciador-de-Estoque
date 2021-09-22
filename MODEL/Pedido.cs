using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Estoque.MODEL
{
    class Pedido
    {
        private int id;
        private string operacao;
        private string pessoa;
        private DateTime data;
        private decimal frete;
        private string status;
        private string financeiro;

        public int Id { get => id; set => id = value; }
        public string Operacao { get => operacao; set => operacao = value; }
        public string Pessoa { get => pessoa; set => pessoa = value; }
        public DateTime Data { get => data; set => data = value; }
        public decimal Frete { get => frete; set => frete = value; }
        public string Status { get => status; set => status = value; }
        public string Financeiro { get => financeiro; set => financeiro = value; }
    }
}
