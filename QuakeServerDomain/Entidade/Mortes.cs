using System;
using System.Collections.Generic;
using System.Text;

namespace QuakeServerDomain.Entidade
{
    public class Mortes : EntidadeBase
    {
        public int IdClienteMatou { get; set; }

        public string Cliente_Matou { get; set; }

        public int IdArma { get; set; }

        public int Quantidade { get; set; }

        public int IdClienteMorto { get; set; }
        public string Cliente_Morto { get; set; }

        public int IdPartida { get; set; }

        
    }
}
