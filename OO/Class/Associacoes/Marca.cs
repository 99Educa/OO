namespace OO.Class.Associacoes
{
    public class Marca
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }

        public Marca(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
