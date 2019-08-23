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
                string fileName = "prog.isi";// Console.ReadLine();
                string progContent = File.ReadAllText($"..\\..\\{fileName}");

                byte[] byteArray = Encoding.UTF8.GetBytes(progContent);
                MemoryStream stream = new MemoryStream(byteArray);

                IsicompLexer lexer = new IsicompLexer(stream);
                IsicompParser parser = new IsicompParser(lexer);
                parser.ProgramaObj = new Programa("JavaGerado");
                parser.programa();
                Console.WriteLine("Compilado com sucesso");
                parser.ProgramaObj.saveToFile();

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
                Console.ReadKey();
            }
        }
    }
}