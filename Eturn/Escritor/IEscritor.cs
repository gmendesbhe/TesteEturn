using Eturn.Trilhas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Escritor
{
    interface IEscritor
    {
        void EscreverTrilhas(List<Trilha> trilhas, List<Palestra> listaPalestrasExcedentes);
    }
}
