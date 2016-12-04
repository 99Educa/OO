namespace OO.Class.Associacoes
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Custo { get; private set; }
        public decimal Preco { get; private set; }
        public Marca Marca { get; private set; }

        public Produto(int id, string descricao, decimal custo, decimal preco, Marca marca)
        {
            Id = id;
            Descricao = descricao;
            Custo = custo;
            Preco = preco;
            Marca = marca;
        }
    }
}
