using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    public class Token
    {
        public static readonly int ID            = 0;
        public static readonly int INT_NUMBER    = 1;
        public static readonly int FLOAT_NUMBER  = 2;
        public static readonly int OPERATOR      = 3;
        public static readonly int RESERVED_WORD = 4;
        public static readonly int PONTUACTION   = 5;
        public static readonly int COMMA         = 6;
        public static readonly int EOF           = -1;

        private int id;
        private String text;

        public Token()
        {
            id = 0;
            text = "";
        }

        public Token(int id, String text)
        {
            this.id = id;
            this.text = text;
        }

       
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setText(String str)
        {
            this.text = str;
        }

        public String getText()
        {
            return this.text;
        }

        public String toString()
        {
            return "<" + id + ", " + text + ">";
        }

    }
}
