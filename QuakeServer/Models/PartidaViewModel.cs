using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuakeServer.Models
{
    public class PartidaViewModel
    {
        public int Id { get; set; }
        
        public string Tipo { get; set; }

        public int NMaxJogadores { get; set; }

        public int Cliente { get; set; }

        public int TotalMortes { get; set; }

        public int ScoreCliente { get; set; }

        public int NPartida { get; set; }
    }
}
