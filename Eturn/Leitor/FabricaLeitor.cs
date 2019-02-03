using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn.Leitor
{
    static class FabricaLeitor
    {
        public static ILeitor ObterLeitor()
        {
            switch (ParametrosEntrada.Instance.Leitura)
            {
                case TipoLeituraEnum.Arquivo:
                default:
                    return new LeitorArquivo();
            }
        }
    }
}
