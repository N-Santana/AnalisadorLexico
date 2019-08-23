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

        public CmdEscrita(string value)
        {
            this.value = value;
        }

        public string ToJava()
        {
            return $"System.out.println({value});";
        }
    }
}
