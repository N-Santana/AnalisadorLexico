﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public interface ICommand
    {
        string ToJava();
        string ToC();
    }
}
