using System.Collections.Generic;
using System.Linq;

namespace OO.Class.AGA
{
    public class Aula
    {
        private string _titulo;
        private string _descricao;
        private IList<Matricula> _matriculas;

        public Aula(string titulo, string descricao)
        {
            _titulo = titulo;
            _descricao = descricao;
        }

        public string Titulo { get { return _titulo; } }
        public string Descricao { get { return _descricao; } }
        public IList<Matricula> Matriculas { get { return _matriculas; } }


        public void MatricularAluno(Aluno aluno)
        {
            if (_matriculas.Any(m => m.Aluno == aluno))
                return;

            _matriculas.Add(new Matricula(aluno, this));
        }
    }
}
