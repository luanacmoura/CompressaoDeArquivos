using System;
using System.IO;
using System.IO.Compression;
using CompressaoArquivos.Util;
using CompressaoArquivos.ViewControllers;

namespace Teste_Compressao
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao, opcao2;
            string arquivoinsert;

            do { 
                Menu.Primario();
                opcao = int.Parse(Console.ReadLine());
                
                if (opcao == 1)
                {
                    Console.Clear();
                    //Pega o caminho que o usuário inseriu!
                    Console.WriteLine("Digite o endereço onde está a pasta que deseja comprimir!");
                    arquivoinsert = Console.ReadLine();

                    //Se a pasta existir, ele segue com o programa!
                    if (Directory.Exists(arquivoinsert)) {

                        Menu.CompressionLevel();
                        opcao2 = int.Parse(Console.ReadLine());

                            switch (opcao2)
                            {
                                case 1: {
                                    Compressao.Fastest(arquivoinsert);
                                    break;
                                }

                                case 2: {
                                    Compressao.Optimal(arquivoinsert);
                                    break;
                                }

                                case 3: {
                                    Compressao.NoCompression(arquivoinsert);
                                    break;
                                }

                                default: {
                                    Console.WriteLine("Opção inválida!");
                                    break;
                                }
                            }
                    }
                    //Se a pasta não existir, aparece caminho inválido!
                    else { 
                        Console.WriteLine("Caminho inválido!");
                    }
                }

                else if (opcao == 2) {
                    Console.Clear();
                    Console.WriteLine("Digite o endereço em que a pasta comprimida está!");
                    arquivoinsert = Console.ReadLine();
                    
                    Descompressao.Arquivos(arquivoinsert);
                }

                else if (opcao == 0) {
                    Console.Clear();
                    Console.WriteLine("Obrigada por usar o programa!");
                }

                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            } while (opcao !=0);
       }
    }
}
