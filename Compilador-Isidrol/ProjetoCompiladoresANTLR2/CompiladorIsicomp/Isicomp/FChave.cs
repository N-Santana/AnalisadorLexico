﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class FChave : ICommand
    {
        public string ToJava()
        {
            return "}";
        }

        public string ToC()
        {
            return this.ToJava();
        }
    }
}
