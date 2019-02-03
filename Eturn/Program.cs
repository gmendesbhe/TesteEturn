using Eturn.Escritor;
using Eturn.Leitor;
using Eturn.Trilhas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new TimeSpan() == new TimeSpan());
            var parametros = ParametrosEntrada.Instance;
            #region leituraParametros
            int parametroArquivo = Array.FindIndex(args, a => a == "-f");
            if (parametroArquivo > -1)
            {
                parametros.Leitura = TipoLeituraEnum.Arquivo;
                parametros.CaminhoArquivoPalestras = args[parametroArquivo + 1];
            }
            else
            {
                throw new Exception("Favor informar arquivo com as palestras");
            }
            int parametroSeparadorCsv = Array.FindIndex(args, a => a == "-s");
            parametros.SeparadorCsv = ",";
            if (parametroSeparadorCsv > -1)
            {
                parametros.SeparadorCsv = args[parametroSeparadorCsv + 1];
            }
            int parametroArquivoSaida = Array.FindIndex(args, a => a == "-o");
            parametros.Escrita = EscritaEnum.Console;
            if (parametroArquivoSaida > -1)
            {
                parametros.Escrita = EscritaEnum.Arquivo;
                parametros.CaminhoArquivoSaida = args[parametroArquivoSaida + 1];
            }
            #endregion
            ILeitor leitor = FabricaLeitor.ObterLeitor();
            List<Palestra> listaPalestras = leitor.ObterListaPalestras();

            List<Trilha> trilhas = Trilha.ObterTrilhas();
            var listaPalestrasExcedentes = new Distribuidor().DistribuirPalestras(listaPalestras, trilhas);
            IEscritor escritor = FabricaEscritor.ObterEscritor();
            

            escritor.EscreverTrilhas(trilhas, listaPalestrasExcedentes);
        }
    }
}
