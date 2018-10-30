using System;
using System.IO;
using System.IO.Compression;

namespace CompressaoArquivos.ViewControllers
{
    public class Descompressao
    {
        public static void Arquivos (string arquivoinsert) {
            string diretorio, diretorioinsert, arquivo;

            arquivo = $@"{arquivoinsert}"; //necessário para que não coloque duas barras

            diretorioinsert = arquivo.Remove(arquivo.Length - 4);
            diretorio = $@"{diretorioinsert}"; //necessário para que eu não coloque duas barras

            ZipFile.ExtractToDirectory(arquivo, diretorio);

            Console.WriteLine($"Pasta descompactada!!");
            Console.WriteLine($"O endereço onde a pasta descompactada está é: {diretorioinsert}!");
            Console.ReadKey();
        }
    }
}