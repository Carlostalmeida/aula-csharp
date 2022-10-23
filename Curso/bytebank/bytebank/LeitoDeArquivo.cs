using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class LeitoDeArquivo
    {
        public string Arquivo { get; }

        public LeitoDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            throw new FileNotFoundException();
            Console.WriteLine("Abrir arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            //throw new IOException();
            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
