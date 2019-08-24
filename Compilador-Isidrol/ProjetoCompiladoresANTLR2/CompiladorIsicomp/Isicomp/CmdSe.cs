using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class CmdSe : ICommand
    {
        private string p1;
        private string op;
        private string p2;

        public CmdSe(string p1, string op, string p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.op = op;
        }

        public string ToJava()
        {
            return $"if({p1} {op} {p2}){{";
        }

        public string ToC()
        {
            return this.ToJava();
        }
    }
}
