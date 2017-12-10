using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucoes.Model
{
    class Sistemas : SistemasModelo
    {

        public override string ToString()
        {
            return "Código: "+this.Codigo + "  -  Assunto: "+this.Assunto;
        }
    }
}
