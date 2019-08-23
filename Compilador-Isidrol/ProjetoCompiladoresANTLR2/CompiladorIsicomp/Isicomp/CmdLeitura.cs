using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class CmdLeitura: ICommand
    {
        private string idVar;

        public CmdLeitura(string idVar)
        {
            this.idVar = idVar;
        }

        public String ToJava()
        {
            return idVar + "=" + Programa.INPUT + ".nextFloat();";
        }
    }
}
