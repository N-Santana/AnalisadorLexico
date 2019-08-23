using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isicomp
{
    public class BinaryOperand : AbstractOperand
    {
        private char op;
        private AbstractOperand left;
        private AbstractOperand right;

        public BinaryOperand(char op, AbstractOperand l, AbstractOperand r)
        {
            this.op = op;
            this.left = l;
            this.right = r;
        }
        public BinaryOperand()
        {
            this.left = null;
            this.right = null;
        }
        public BinaryOperand(char op)
        {
            this.op = op;
        }

        public override string toXml()
        {
            return "<operation = " + op + ">\n"
                    + "  <op_left> " + left.toXml() + "\n"
                    + "  <op_right>" + right.toXml() + "\n"
                    + "</operation>";
        }



        /**
         * @return the op
         */
        public char getOp()
        {
            return op;
        }

        /**
         * @param op the op to set
         */
        public void setOp(char op)
        {
            this.op = op;
        }

        /**
         * @return the left
         */
        public AbstractOperand getLeft()
        {
            return left;
        }

        /**
         * @param left the left to set
         */
        public void setLeft(AbstractOperand left)
        {
            this.left = left;
        }

        /**
         * @return the right
         */
        public AbstractOperand getRight()
        {
            return right;
        }

        /**
         * @param right the right to set
         */
        public void setRight(AbstractOperand right)
        {
            this.right = right;
        }

        public override float getValue()
        {
            if (this.op == '+')
            {
                return left.getValue() + right.getValue();
            }
            else if (this.op == '-')
            {
                return left.getValue() - right.getValue();
            }
            else if (this.op == '*')
            {
                return left.getValue() * right.getValue();
            }
            else if (this.op == '/')
            {
                if (right.getValue() != 0)
                {
                    return left.getValue() / right.getValue();
                }
                else
                {
                    throw new ApplicationException("DIVISION BY ZERO!!!");
                }
            }
            else
            {
                throw new ApplicationException("Unsupported Operation");
            }
        }
    }

}
