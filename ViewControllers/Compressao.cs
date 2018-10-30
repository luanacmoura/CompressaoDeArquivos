using System;
using System.IO;
using System.IO.Compression;

namespace CompressaoArquivos.ViewControllers
{
    public class Compressao
    {
        public static void Fastest(string arquivoinsert) {
            string arquivo, diretorio;
            
            Console.Clear();
            arquivo = $@"{arquivoinsert}";
            diretorio = $@"{arquivoinsert}.zip";
            ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.Fastest, true); //pra onde vai, e qual arquivo será zipado!
            Console.WriteLine("");
            Console.WriteLine($"Pasta zipada!");
            Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
            Console.ReadKey();
        }

        public static void Optimal (string arquivoinsert) {
            string arquivo, diretorio;
            
            Console.Clear();
            arquivo = $@"{arquivoinsert}";
            diretorio = $@"{arquivoinsert}.zip";
            ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.Optimal, true); //pra onde vai, e qual arquivo será zipado!
            Console.WriteLine("");
            Console.WriteLine($"Pasta zipada!");
            Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
            Console.ReadKey();
        }

        public static void NoCompression (string arquivoinsert) {
            string arquivo, diretorio;
            
            Console.Clear();
            arquivo = $@"{arquivoinsert}";
            diretorio = $@"{arquivoinsert}.zip";
            ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.NoCompression, true); //pra onde vai, e qual arquivo será zipado!
            Console.WriteLine("");
            Console.WriteLine($"Pasta zipada!");
            Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
            Console.ReadKey();
        }
    }
}