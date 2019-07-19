using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    public class AnalisadorLexico
    {
        public int ID { get; set; }
        public int OPER { get; set; }
        public int ERROR { get; set; }
        public int NUM { get; set; }
        public int Pos { get; set; }
        public char[] Content { get; set; }

        public AnalisadorLexico(char[] content)
        {
            Pos = 0;
            ID = 1;
            NUM = 2;
            OPER = 3;
            ERROR = -1;

            this.Content = content;
        }

        private char NextChar()
        {
            return Content[Pos++];
        }

        private Boolean IsLetter(char c)
        {
            if (c >= 'a' && c <= 'z') return true;
            return false;
        }

        private Boolean IsNumber(char c)
        {
            if (c >= '0' && c <= '9') return true;
            return false;
        }

        private Boolean IsOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^') return true;
            return false;
        }

        private Boolean IsPontuation(char c)
        {
            if (c == ' ' || c == ';' || c == '.' || c == '\n' || c == '\t' || c == '\r') return true;
            return false;
        }

        private void Rollback()
        {
            Pos--;
        }

        private Boolean EOF()
        {
            return Pos == Content.Length;
        }


    }
}
