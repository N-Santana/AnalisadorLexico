using antlr;
using Antlr.Runtime;
using Isicomp;
using System;

using System.IO;
using System.Text;

namespace ProjetoCompiladores
{
    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o nome do arquivo: ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Digite 1 para java e 2 para C");
                int language = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do arquivo a ser gerado.");
                string nomeDoArquivo = Console.ReadLine();
                string progContent = File.ReadAllText($"..\\..\\{fileName}");

                byte[] byteArray = Encoding.UTF8.GetBytes(progContent);
                MemoryStream stream = new MemoryStream(byteArray);

                IsicompLexer lexer = new IsicompLexer(stream);
                IsicompParser parser = new IsicompParser(lexer);
                parser.ProgramaObj = new Programa(nomeDoArquivo);
                parser.programa();
                if(language == 1)
                    parser.ProgramaObj.saveToFile(Programa.Linguagem.JAVA);
                else if(language == 2)
                    parser.ProgramaObj.saveToFile(Programa.Linguagem.C);
                else
                    Console.WriteLine("Inválido");

            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (TokenStreamRecognitionException ex)
            {
                Console.WriteLine($"{ex.Message} at {ex.recog.line}:{ex.recog.column}");
            }
            finally
            {
                Console.WriteLine("Fim.");
                Console.ReadKey();
            }
        }
    }
}