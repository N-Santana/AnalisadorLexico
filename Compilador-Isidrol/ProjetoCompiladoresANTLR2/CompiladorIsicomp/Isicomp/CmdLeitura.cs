﻿using System;
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

        public string ToJava()
        {
            return idVar + "=" + Programa.INPUT + ".nextDouble();";
        }

        public string ToC()
        {
            return $"scanf(\"%lf\", &{idVar});";
        }
    }
}
