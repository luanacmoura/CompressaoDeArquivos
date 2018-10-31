using System;
using System.IO;
using System.IO.Compression;

namespace CompressaoArquivos.ViewControllers
{
    /// <summary>
    /// Classe responsável pela compressão dos arquivos!
    /// </summary>
    public class Compressao
    {   
        /// <summary>
        /// Classe responsável pela compressão do tipo fastest dos arquivos!
        /// </summary>
        /// <param name="arquivoinsert"> Arquivo que deseja comprimir!</param>
        public static void Fastest(string arquivoinsert) {
            string arquivo, diretorio;
            int opcao;
            bool flag = false;
            
            Console.Clear();
            
            //atribui o valor inserido pelo usuário a variável arquivo, em que, devido ao uso do @ automaticamente interpretará com barras duplas! Este passo é necessário para que seja interpretado como um caminho válido pelo ZipFile!
            arquivo = $@"{arquivoinsert}";
            //ao atribuir o mesmo caminho inserido pelo usuário ao diretório + .zip, definimos que o arquivo .zip será criado no mesmo diretório e com o mesmo nome, apenas com extensão diferente.
            diretorio = $@"{arquivoinsert}.zip";

            //looping para que a pessoa escolha se deseja ou não que a pasta seja comprimida, ou apenas os arquivos
            do {
                Console.WriteLine("Deseja que a pasta seja comprimida junto (1), ou apenas os arquivos (2)?");
                opcao = int.Parse(Console.ReadLine());
                //se deseja que a pasta seja comprimida junto, flag recebe true
                if (opcao == 1) {
                    flag = true;
                }
                //se deseja que apenas os arquivos sejam comprimidos, flag recebe false
                else if (opcao==2) {
                    flag = false;
                }
                else {
                    Console.WriteLine("Opção inválida! Tente novamente...");
                }
            } while (opcao > 2 || opcao < 0); //se digitar algo diferente de 1 e 2, continua o looping

            //arquivo é o arquivo que será zipado, diretorio é aonde será salva a pasta zipada, nível de compressão priorizando a velocidade, e a flag que define se irá ou não comprimir a pasta junto...
            ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.Fastest, flag); 
            Console.WriteLine("");
            Console.WriteLine($"Pasta zipada!");
            Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
            Console.ReadKey();
        }

        /// <summary>
        /// Classe responsável pela compressão do tipo optimal, dos arquivos!
        /// </summary>
        /// <param name="arquivoinsert"> Arquivo que deseja comprimir! </param>
        public static void Optimal (string arquivoinsert) {
            string arquivo, diretorio;
            int opcao;
            bool flag = false;

            Console.Clear();

            //atribui o valor inserido pelo usuário a variável arquivo, em que, devido ao uso do @ automaticamente interpretará com barras duplas! Este passo é necessário para que seja interpretado como um caminho válido pelo ZipFile!
            arquivo = $@"{arquivoinsert}";
            //ao atribuir o mesmo caminho inserido pelo usuário ao diretório + .zip, definimos que o arquivo .zip será criado no mesmo diretório e com o mesmo nome, apenas com extensão diferente.
            diretorio = $@"{arquivoinsert}.zip";
            
            //looping para que a pessoa escolha se deseja ou não que a pasta seja comprimida, ou apenas os arquivos
            do {
                Console.WriteLine("Deseja que a pasta seja comprimida junto (1), ou apenas os arquivos (2)?");
                opcao = int.Parse(Console.ReadLine());
                //se deseja que a pasta seja comprimida junto, flag recebe true
                if (opcao == 1) {
                    flag = true;
                }
                //se deseja que apenas os arquivos sejam comprimidos, flag recebe false
                else if (opcao==2) {
                    flag = false;
                }
                else {
                    Console.WriteLine("Opção inválida! Tente novamente...");
                }
            } while (opcao > 2 || opcao < 0); //se digitar algo diferente de 1 e 2, continua o looping

            //arquivo é o arquivo que será zipado, diretorio é aonde será salva a pasta zipada, nível de compressão priorizando a qualidade da compressão, e a flag que define se irá ou não comprimir a pasta junto...
            ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.Optimal, flag);
            Console.WriteLine("");
            Console.WriteLine($"Pasta zipada!");
            Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
            Console.ReadKey();
        }

        /// <summary>
        /// Classe responsável pela compressão do tipo NoCompression, dos arquivos!
        /// </summary>
        /// <param name="arquivoinsert"> Arquivo que deseja comprimir! </param>
        public static void NoCompression (string arquivoinsert) {
            string arquivo, diretorio;
            int opcao;
            bool flag = false;
            
            Console.Clear();
            //atribui o valor inserido pelo usuário a variável arquivo, em que, devido ao uso do @ automaticamente interpretará com barras duplas! Este passo é necessário para que seja interpretado como um caminho válido pelo ZipFile!
            arquivo = $@"{arquivoinsert}";
            //ao atribuir o mesmo caminho inserido pelo usuário ao diretório + .zip, definimos que o arquivo .zip será criado no mesmo diretório e com o mesmo nome, apenas com extensão diferente.
            diretorio = $@"{arquivoinsert}.zip";

            //looping para que a pessoa escolha se deseja ou não que a pasta seja comprimida, ou apenas os arquivos
            do {
                Console.WriteLine("Deseja que a pasta seja comprimida junto (1), ou apenas os arquivos (2)?");
                opcao = int.Parse(Console.ReadLine());
                //se deseja que a pasta seja comprimida junto, flag recebe true                
                if (opcao == 1) {
                    flag = true;
                }
                //se deseja que apenas os arquivos sejam comprimidos, flag recebe false
                else if (opcao==2) {
                    flag = false;
                }
                else {
                    Console.WriteLine("Opção inválida! Tente novamente...");
                }
            } while (opcao > 2 || opcao < 0); //se digitar algo diferente de 1 e 2, continua o looping
            
            //arquivo é o arquivo que será zipado, diretorio é aonde será salva a pasta zipada, sem compressão, e a flag que define se irá ou não comprimir a pasta junto...
            ZipFile.CreateFromDirectory(arquivo, diretorio, CompressionLevel.NoCompression, flag);
            Console.WriteLine("");
            Console.WriteLine($"Pasta zipada!");
            Console.WriteLine($"O endereço onde a pasta comprimida está é: {arquivoinsert}.zip");
            Console.ReadKey();
        }
    }
}