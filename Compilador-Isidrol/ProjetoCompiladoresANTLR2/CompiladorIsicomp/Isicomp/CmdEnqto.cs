using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class CmdEnqto : ICommand
    {
        string p1;
        string op;
        string p2;
        bool doWhile;
        public CmdEnqto(string p1, string op, string p2, bool doWhile)
        {
            this.p1 = p1;
            this.op = op;
            this.p2 = p2;
            this.doWhile = doWhile;
        }

        public string ToJava()
        {
            return doWhile ? $"while({p1} {op} {p2});" : $"while({p1} {op} {p2}) {{";
        }

        public string ToC()
        {
            return this.ToJava();
        }
    }
}
