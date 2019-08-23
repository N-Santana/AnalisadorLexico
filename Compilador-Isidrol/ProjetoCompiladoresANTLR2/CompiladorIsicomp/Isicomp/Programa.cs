using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class Programa
    {
        public const string INPUT = "__isiC_input_MACRO_v1";
        private string name;

        public List<Variavel> Variaveis { get; set; }
        List<ICommand> comandos;

        public Programa(string name)
        {
            this.name = name;
            comandos = new List<ICommand>();
            Variaveis = new List<Variavel>();
        }

        public void AddCommand(ICommand c)
        {
            comandos.Add(c);
        }

        public void saveToFile()
        {
            try
            {
                StringBuilder f = new StringBuilder();
                f.Append("public class " + name + "{\n");
                f.Append("    public static void main(String args[]){\n");
                f.Append("      java.util.Scanner " + INPUT + "=new java.util.Scanner(System.in);\n");
                foreach (Variavel variavel in Variaveis)
                {
                    f.Append($"{variavel.Tipo} {variavel.Nome};\n");
                }
                foreach (ICommand c in comandos)
                {
                    f.Append(c.ToJava() + "\n");
                }
                f.Append("}");
                f.Append("}");

                System.IO.File.WriteAllText($"{name}.java", f.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO:" + ex.Message);
            }
        }
    }
}
