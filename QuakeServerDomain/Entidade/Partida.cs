using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Entidade
{
    public class Partida : EntidadeBase
    {
        public string Tipo { get; set; }

        public int NMaxJogadores { get; set; }

        public int Cliente { get; set; }

        public int TotalMortes { get; set; }

        public int ScoreCliente { get; set; }

        public int NPartida { get; set; }

                              
    }
}
