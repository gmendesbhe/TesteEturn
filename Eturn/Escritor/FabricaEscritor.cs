using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Escritor
{
    static class FabricaEscritor
    {
        public static IEscritor ObterEscritor()
        {
            switch (ParametrosEntrada.Instance.Escrita)
            {
                case EscritaEnum.Arquivo:
                    return new EscritorArquivo(ParametrosEntrada.Instance.CaminhoArquivoSaida);
                case EscritaEnum.Console:
                default:
                   return new EscritorConsole();
            }
        }
    }
}
