using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Entidade
{
    public class Cliente : EntidadeBase
    {

        public int IdPosicao { get; set; }

        public string NickName { get; set; }

        public string Personagem { get; set; }

        public string Personagem_Alterado { get; set; }

        public int Vida { get; set; }

        public int Escudo { get; set; }

        public int Matou { get; set; }

        public int Morreu { get; set; }

    }
}
