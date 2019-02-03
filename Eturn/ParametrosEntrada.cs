using Eturn.Escritor;
using Eturn.Leitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eturn
{
    sealed class ParametrosEntrada
    {
        private static ParametrosEntrada instance = null;
        public EscritaEnum Escrita { get; internal set; }
        public string CaminhoArquivoSaida { get; internal set; }
        public string CaminhoArquivoPalestras { get; internal set; }
        public string SeparadorCsv { get; internal set; }

        private ParametrosEntrada()
        {
        }

        public static ParametrosEntrada Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ParametrosEntrada();
                }
                return instance;
            }
        }

        public TipoLeituraEnum Leitura { get; internal set; }
    }
}
