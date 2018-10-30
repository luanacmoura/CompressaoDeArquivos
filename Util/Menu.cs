using System;

namespace CompressaoArquivos.Util
{
    public class Menu
    {
        public static void Primario () {
            Console.Clear();
            Console.WriteLine("Opções");
            Console.WriteLine("1. Comprimir");
            Console.WriteLine("2. Descomprimir");
            Console.WriteLine("3. Adicionar arquivos num .zip já existente!");
        }

        public static void CompressionLevel () {
            Console.Clear();
            Console.WriteLine("Você deseja uma:");
            Console.WriteLine("1. Compactação rápida");
            Console.WriteLine("2. Compactação otimizada");
            Console.WriteLine("3. Não compactar");
        }
    }
}