using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OO.Class
{
    public class Aluno
    {
        private string _nome;
        private string _cpf;
        private DateTime _dataNascimento;
        private string _email;
        private IList<Matricula> _matriculas;

        public Aluno(string nome, string cpf, DateTime dataNascimento, string email)
        {
            _nome = nome;
            _cpf = cpf;
            _dataNascimento = dataNascimento;
            _email = email;
        }

        public string Nome { get { return _nome; } }
        public string Cpf { get { return _cpf; } }
        public DateTime DataNascimento {  get { return _dataNascimento; } }
        public string Email { get { return _email; } }
        public IList<Matricula> Matriculas { get { return _matriculas; } }
    }
}
