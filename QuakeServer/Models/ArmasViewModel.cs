using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuakeServer.Models
{
    public class ArmasViewModel
    {
        public int Id { get; set; }

        public string NomeArma { get; set; }

        public int Municao { get; set; }

        public int Dano { get; set; }

    }
}
