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
            string arquivoinsert, diretorioinsert, arquivo, diretorio;

            Menu.Primario();
            opcao = int.Parse(Console.ReadLine());
            
            if (opcao == 1)
            {
                Console.Clear();
                Console.WriteLine("Digite o endereço onde está a pasta que deseja comprimir!");
                arquivoinsert = Console.ReadLine();

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
            }

            else if (opcao == 2)
            {
                // if (Directory.Exists(arquivoinsert)) {
                //     Directory.Delete(arquivoinsert);
                // }
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
