using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucoes.Model
{
    abstract class SistemasModelo
    {
        public int Codigo { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public DateTime DataUltimaGravacao { get; set; }
        public string QuemGravou { get; set; }
    }
}
