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
                parser.programa();
                Console.WriteLine("Compilado com sucesso");

            }
            catch (ApplicationException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}