using System;

namespace OO.Class.AGA
{
    public class Matricula
    {
        private Aluno _aluno;
        private Aula _aula;
        private DateTime _dataMatricula;

        public Matricula (Aluno aluno, Aula aula)
        {
            _aluno = aluno;
            _aula = aula;
            _dataMatricula = DateTime.Now;
        }

        public Aluno Aluno { get { return _aluno; } }
        public Aula Aula { get { return _aula; } }
        public DateTime DataMatricula { get { return _dataMatricula; } }
    }
}
