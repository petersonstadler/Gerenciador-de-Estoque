namespace Gerenciador_de_Estoque.MODEL
{
    public class ItemNoPedido
    {
        private int idpedido;
        private int idproduto;
        private decimal custo;
        private decimal preco;
        private float quantidade;
        private decimal desconto;
        private decimal acrescimo;

        public int Idpedido { get => idpedido; set => idpedido = value; }
        public int Idproduto { get => idproduto; set => idproduto = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public float Quantidade { get => quantidade; set => quantidade = value; }
        public decimal Desconto { get => desconto; set => desconto = value; }
        public decimal Acrescimo { get => acrescimo; set => acrescimo = value; }
        public decimal Custo { get => custo; set => custo = value; }
    }
}
