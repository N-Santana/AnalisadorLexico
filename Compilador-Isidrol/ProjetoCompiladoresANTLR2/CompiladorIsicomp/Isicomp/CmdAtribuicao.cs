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

        public string ToC()
        {
            if(varValue[0] != '"')
                return this.ToJava();
            else
            {
                /*varValue = varValue.Substring(1, varValue.Length - 2);
                var attrib = $"{varName} = {{";
                foreach (var c in varValue)
                {
                    attrib += $"{"'"}{c}{"'"}, ";
                }
                attrib += $"{"'"}{"\\"}0{"'"}}}";

                return attrib;*/
                return this.ToJava();
            }
        }
    }
}
