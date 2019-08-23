using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class UnaryOperand : AbstractOperand
    {
        private float fValue;

        public UnaryOperand(float value)
        {
            this.fValue = value;
        }

        public override float getValue()
        {
            return this.fValue;
        }

        public override string toXml()
        {
            return "<number> " + this.fValue + "</number>";
        }
    }
}
