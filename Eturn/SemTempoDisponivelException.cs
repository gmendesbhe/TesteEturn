using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn
{
    class SemTempoDisponivelException: Exception
    {
        public SemTempoDisponivelException():base("Nao ha tempo disponivel para tal palestra nesta sessao")
        {
        }
    }
}
