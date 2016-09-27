using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OO.Class.Agregacao
{
    public class Jogador
    {
        private Equipe _equipe;

        public void AtribuirEquipe(Equipe equipe)
        {
            _equipe = equipe;
        }
    }
}
