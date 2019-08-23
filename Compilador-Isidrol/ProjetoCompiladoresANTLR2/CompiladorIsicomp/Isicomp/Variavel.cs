using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class Variavel
    {
        public const string STRING = "string";
        public const string NUMERICO = "float";

        public Variavel(string nome, string tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }

        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}
