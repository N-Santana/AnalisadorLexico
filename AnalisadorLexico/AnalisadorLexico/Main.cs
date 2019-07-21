using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            AnalisadorLexico lex = new AnalisadorLexico(@"C:\Users\ailat\Documents\DEV\AnalisadorLexico\prog.in.txt");
            Console.WriteLine(lex.nextToken());
            Console.WriteLine(lex.nextToken());
            Console.WriteLine(lex.nextToken());
        }
    }
}
