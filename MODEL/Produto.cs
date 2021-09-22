using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_de_Estoque.MODEL
{
    class Produto
    {
        private int id;
        private string nome;
        private string descricao;
        private string tamanho;
        private decimal custo;
        private decimal preco;
        private int idcategoria;
        private float quantidade;
        private bool ativo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Tamanho { get => tamanho; set => tamanho = value; }
        public decimal Custo { get => custo; set => custo = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public float Quantidade { get => quantidade; set => quantidade = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
