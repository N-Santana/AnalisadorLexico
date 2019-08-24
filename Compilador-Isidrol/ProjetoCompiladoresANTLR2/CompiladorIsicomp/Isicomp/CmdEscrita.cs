using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class CmdEscrita : ICommand
    {

        private string value;
        private string tipo;

        public CmdEscrita(string value, string tipo)
        {
            this.value = value;
            this.tipo = tipo;
        }

        public string ToJava()
        {
            return $"System.out.println({value});";
        }

        public string ToC()
        {
            string printType = tipo == "string" ? "%s" : "%lf";
            return $"printf(\"{printType}{"\\n"}\", {value});";
        }
    }
}
