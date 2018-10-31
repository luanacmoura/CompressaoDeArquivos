using System;
using System.IO;
using System.IO.Compression;

namespace CompressaoArquivos.ViewControllers
{
    public class Descompressao
    {
        /// <summary>
        /// Classe responsável pela descompressão de arquivos!
        /// </summary>
        /// <param name="arquivoinsert"> Arquivo que deseja descomprimir! </param>
        public static void Arquivos (string arquivoinsert) {
            string diretorio, diretorioinsert, arquivo;

            //atribui o valor inserido pelo usuário a variável arquivo, em que, devido ao uso do @ automaticamente interpretará com barras duplas! Este passo é necessário para que seja interpretado como um caminho válido pelo ZipFile!
            arquivo = $@"{arquivoinsert}"; //necessário para que eu não coloque duas barras

            //remove a extensão .zip (-4) do caminho inserido pelo usuário, para que se crie no mesmo caminho uma pasta de mesmo nome!
            diretorioinsert = arquivo.Remove(arquivo.Length - 4);

            //atribui o caminho definido sem .zip e preparado com barras duplas a variável diretório
            diretorio = $@"{diretorioinsert}"; 

            //arquivo é o arquivo que será descomprimido, e diretorio é aonde será descomprimido
            ZipFile.ExtractToDirectory(arquivo, diretorio);

            Console.WriteLine($"Pasta descompactada!!");
            Console.WriteLine($"O endereço onde a pasta descompactada está é: {diretorioinsert}!");
            Console.ReadKey();
        }
    }
}