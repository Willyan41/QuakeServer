using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Entidade
{
    public class Armas : EntidadeBase
    {
        public string NomeArma { get; set; }

        public int Municao { get; set; }

        public int Dano { get; set; }


    }
}
