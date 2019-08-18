using Antlr4.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
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
                string progContent = File.ReadAllText($"..\\..\\..\\{fileName}");

                AntlrInputStream inputStream = new AntlrInputStream(progContent);
                IsicompLexer lexer = new IsicompLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                IsicompParser parser = new IsicompParser(commonTokenStream);
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
        }
    }
}