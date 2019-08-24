using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class Programa
    {
        public enum Linguagem{
            C,
            JAVA
        }


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

        public void saveToFile(Linguagem l)
        {
            try
            {
                StringBuilder f = new StringBuilder();
                if (l == Linguagem.JAVA)
                {
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
                else if(l == Linguagem.C)
                {
                    f.AppendLine("#include <stdlib.h>");
                    f.AppendLine("#include <stdio.h>");
                    f.AppendLine("#include <string.h>");
                    f.AppendLine("int main() {");
                    foreach (Variavel variavel in Variaveis)
                    {
                        if(variavel.Tipo != "String")
                            f.Append($"{variavel.Tipo} {variavel.Nome};\n");
                        else
                        {
                            f.Append($"char* {variavel.Nome};");
                        }
                    }
                    foreach (ICommand c in comandos)
                    {
                        f.Append(c.ToC() + "\n");
                    }
                    f.AppendLine("return 0;");
                    f.Append("}");
                    System.IO.File.WriteAllText($"{name}.c", f.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO:" + ex.Message);
            }
        }
    }
}
