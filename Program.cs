﻿using System;
using System.IO;
using System.IO.Compression;

namespace Teste_Compressao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, opcao2;
            string arquivoinsert, diretorioinsert, arquivo, diretorio;

            Console.WriteLine("Opções");
            Console.WriteLine("1. Comprimir");
            Console.WriteLine("2. Descomprimir");
            opcao = int.Parse(Console.ReadLine());
            

            if (opcao == 1)
            {
                Console.WriteLine("Digite o endereço onde está a pasta que deseja comprimir!");
                arquivoinsert = Console.ReadLine();

                if (File.Exists(arquivoinsert)) {
                    Console.Clear();
                    Console.WriteLine("1. Compactação rápida");
                    Console.WriteLine("2. Compactação otimizada");
                    Console.WriteLine("3. Sem compactação");
                    opcao2 = int.Parse(Console.ReadLine());

                        switch (opcao2)
                        {
                            case 1: {
                                Console.Clear();
                                arquivo = $@"{arquivoinsert}";
                                diretorio = $@"{arquivoinsert}.zip";
                                ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.Fastest); //pra onde vai, e qual arquivo será zipado!
                                Console.WriteLine("");
                                Console.WriteLine($"Pasta zipada!");
                                Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
                                Console.ReadKey();
                                break;
                            }

                            case 2: {
                                Console.Clear();
                                arquivo = $@"{arquivoinsert}";
                                diretorio = $@"{arquivoinsert}.zip";
                                ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.Optimal); //pra onde vai, e qual arquivo será zipado!
                                Console.WriteLine("");
                                Console.WriteLine($"Pasta zipada!");
                                Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
                                Console.ReadKey();
                                break;
                            }

                            case 3: {
                                Console.Clear();
                                arquivo = $@"{arquivoinsert}";
                                diretorio = $@"{arquivoinsert}.zip";
                                ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.NoCompression); //pra onde vai, e qual arquivo será zipado!
                                Console.WriteLine("");
                                Console.WriteLine($"Pasta zipada!");
                                Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
                                Console.ReadKey();
                                break;
                            }

                            default: {
                                Console.WriteLine("Opção inválida!");
                                break;
                            }
                        }
                }
            }

            else if (opcao == 2)
            {

                Console.WriteLine("Digite o endereço em que a pasta comprimida está!");
                arquivoinsert = Console.ReadLine();

                arquivo = $@"{arquivoinsert}"; //necessário para que não coloque duas barras

                diretorioinsert = arquivo.Remove(arquivo.Length - 4);

                diretorio = $@"{diretorioinsert}"; //necessário para que eu não coloque duas barras

                ZipFile.ExtractToDirectory(arquivo, diretorio);
            }

            else
            {
                Console.WriteLine("Opção inválida!");
            }



        }
    }
}
