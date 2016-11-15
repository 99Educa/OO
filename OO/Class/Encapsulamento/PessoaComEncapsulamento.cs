using System;

namespace OO.Class.Encapsulamento
{
    public class PessoaComEncapsulamento
    {
        private string _nome;

        public string Nome {  get { return _nome; } }
        public DateTime DataNascimento { get; private set; }

        public void AtribuirNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentNullException("Informe o nome.");

            if (nome.Length < 4)
                throw new ArgumentException("Nome deve conter no mínimo 4 caracteres.");

            _nome = nome;
        }

        public void AtribuirDataNascimento(DateTime dataNascimento)
        {
            if (dataNascimento.Date.CompareTo(DateTime.Now.Date) > 0)
                throw new ArgumentException("Data de nascimento não pode ser maior que a data atual.");

            this.DataNascimento = dataNascimento;
        }
    }
}
