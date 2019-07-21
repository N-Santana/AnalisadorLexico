using System;
using System.IO;
using System.Text;

namespace AnalisadorLexico
{
    public class AnalisadorLexico
    {
        private String[] reservedWords = { "programa", "declare", "inicio", "fim", "escreva", "leia", "se", "entao", "fimse" };
        private char[] Content;
        private int Pos;

        public AnalisadorLexico(String path)
        {
            try
            {
                Pos = 0;
                byte[] bContent = File.ReadAllBytes(path);
                Content = Encoding.Unicode.GetChars(bContent);

            } catch (IOException ex)
            {
                Console.Error.WriteLine("Erro ao ler o arquivo:\n" + ex.Message);
            }

        }

        private Boolean isReservedWord(String text)
        {
            foreach (string rw in reservedWords)
            {
                if (text.Equals(rw)) return true;
            }
            return false;
        }

        private char nextChar()
        {
            return Content[Pos++];
        }

        private Boolean isLetter(char c)
        {
            if (c >= 'a' && c <= 'z') return true;
            return false;
        }

        private Boolean isDigit(char c)
        {
            if (c >= '0' && c <= '9') return true;
            return false;
        }

        private Boolean isComma(char c)
        {
            return c == ',';
        }

        private Boolean isBlank(char c)
        {
            return c == ' ' || c == '\n' || c == '\t' || c == '\r';
        }

        private Boolean isOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '>' || c == '<' || c == '=') return true;
            return false;
        }

        private Boolean isPontuation(char c)
        {
            if (c == ';' || c == '.') return true;
            return false;
        }

        private void rollback()
        {
            Pos--;
        }

        private Boolean EOF()
        {
            return Pos == Content.Length;
        }

        public Token nextToken()
        {
            int s = 0;
            String text = "";
            char c;
            //Token token;

            while (!EOF()){
                switch(s)
                {
                    case 0:
                        c = nextChar();
                        if (isBlank(c)) s = 0;
                        else if (isLetter(c))
                        {
                            s = 1;
                            text += c;
                        }
                        else if (isOperator(c))
                        {
                            text += c;
                            s = 2;
                        }
                        else if (isPontuation(c))
                        {
                            text += c;
                            s = 3;
                        }
                        else if (isComma(c))
                        {
                            text += c;
                            s = 4;
                        }
                        else return new Token(Token.EOF, " ");
                        break;
                    case 1:
                        c = nextChar();
                        if (isLetter(c) || isDigit(c))
                        {
                            s = 1;
                            text += c;
                        }
                        else if (isBlank(c))
                        {
                            if (isReservedWord(text)) return new Token(Token.RESERVED_WORD, text);
                            return new Token(Token.ID, text);
                        }
                        else if (isOperator(c))
                        {
                            rollback();
                            return new Token(Token.ID, text);
                        }
                        else return new Token(Token.EOF, " "); ;
                        break;
                    case 2:
                        return new Token(Token.OPERATOR, text);
                    case 3:
                        return new Token(Token.PONTUACTION, text);
                    case 4:
                        return new Token(Token.COMMA, text);
                }
            }
            return new Token(Token.EOF, " ");
        }

    }
}
