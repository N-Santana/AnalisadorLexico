using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class CmdAtribuicao : ICommand
    {
        private string varName;
        private string varValue;

        public CmdAtribuicao(string name, string expression)
        {
            //expression.eval();
            varName = name;
            varValue = expression.ToString();
        }

        public string ToJava()
        {
            return $"{varName} = {varValue};";
        }
    }
}
