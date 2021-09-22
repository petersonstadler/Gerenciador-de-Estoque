using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Estoque.MODEL
{
    class Movimento
    {
        private int id;
        private string descricao;
        private float quantidade;
        private int idproduto;
        private string operacao;
        private int idpedido;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public float Quantidade { get => quantidade; set => quantidade = value; }
        public int Idproduto { get => idproduto; set => idproduto = value; }
        public string Operacao { get => operacao; set => operacao = value; }
        public int Idpedido { get => idpedido; set => idpedido = value; }
    }
}
