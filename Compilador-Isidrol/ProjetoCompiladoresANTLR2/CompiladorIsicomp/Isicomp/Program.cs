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

                //AntlrInputStream inputStream = new AntlrInputStream(text.ToString());
                //SpeakLexer speakLexer = new SpeakLexer(inputStream);
                //CommonTokenStream commonTokenStream = new CommonTokenStream(speakLexer);
                //SpeakParser speakParser = new SpeakParser(commonTokenStream);
                //SpeakParser.ChatContext chatContext = speakParser.chat();
                //SpeakVisitor visitor = new SpeakVisitor();
                //visitor.Visit(chatContext);

                //foreach (var line in visitor.Lines)
                //{
                //    Console.WriteLine("{0} has said \"{1}\"", line.Person, line.Text);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}