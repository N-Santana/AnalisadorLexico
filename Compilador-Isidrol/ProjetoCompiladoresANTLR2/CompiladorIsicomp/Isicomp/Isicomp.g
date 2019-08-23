header {
    using System.Collections.Generic;
}

options {
    language  = "CSharp";
    namespace = "Isicomp";
}

class IsicompParser extends Parser;   
{
        Expression expression;
        AbstractOperand numb;
        BinaryOperand sumOrSubt;
        AbstractOperand parent;
        BinaryOperand multOrDiv;
        char op;
        public Programa ProgramaObj {get; set;}

        // para o mapVar: key = id; value = formato;
        public Dictionary<string, string> mapaVar = new Dictionary<string, string>();
}
//--------------- SINTAXE CODIGO -------------------

programa :  "programa" declare blococomando ;

declare : "declare"  formato T_ID {mapaVar.Add(LT(0).getText(), LT(-1).getText());}
         (T_COMMA formato T_ID {mapaVar.Add(LT(0).getText(), LT(-1).getText());})* T_DOT
         {
             List<Variavel> vars = new List<Variavel>();
             string nome;
             string tipo;
             foreach(KeyValuePair<string, string> kv in mapaVar)
             {
                 nome = kv.Key;
                 tipo = kv.Value == "numeric" ? Variavel.NUMERICO : kv.Value == "string" ? Variavel.STRING : throw new ApplicationException("Unexpected type");
                 vars.Add(new Variavel(nome, tipo));
             }
             ProgramaObj.Variaveis = vars;
         };

blococomando : (comando)+ "fimprog" ;

comando : cmd_leia T_DOT | cmd_escreva T_DOT | cmd_atribua T_DOT |  cmd_se | cmd_enquanto | cmd_faca ;

//--------------------- REGRAS ----------------------

exp_ter : exp_fat (oper_ter exp_fat)*;

exp_fat : (num | T_ID            {
           	  if (!mapaVar.ContainsKey(LT(0).getText())){
                 throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
             }
           }  

        ) (oper_fat termo)*;

exp_relacional : (T_ID  {if (!mapaVar.ContainsKey(LT(0).getText())){
                            throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
                        }}
             | num) ope_relac (T_ID     {if (!mapaVar.ContainsKey(LT(0).getText())){
                                            throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
                                        }}
             | num);

termo : num | T_ID            	  {if (!mapaVar.ContainsKey(LT(0).getText())){
                 throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
             }}
             | T_APARENT exp_ter T_FPARENT ; 

cmd_se : "se" T_APARENT exp_relacional T_FPARENT "entao" T_ACHAVE (comando)+ T_FCHAVE ("senao" T_ACHAVE (comando)+ T_FCHAVE )?;

cmd_atribua : T_ID  {   if (!mapaVar.ContainsKey(LT(0).getText())){
                            throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
                        }
                        string ID = LT(0).getText();
                        string tID = mapaVar[LT(0).getText()];
                    }
              T_IGUAL (exp_ter { if(!tID.Equals("numeric")) throw new ApplicationException(" MISMATCHED TYPES ATRIBUITION BETWEEN A STRING ID AN A NON STRING ATRIBUITION."); }
              | T_TEXT {    if(!tID.Equals("string")) 
                                throw new ApplicationException(" MISMATCHED TYPES ATRIBUITION BETWEEN A NUMERIC ID AN A NON NUMERIC ATRIBUITION."); 
                            ProgramaObj.AddCommand(new CmdAtribuicao(ID, LT(0).getText()));
                            }
              );     

cmd_escreva : "escreva" T_APARENT (T_ID    {if (!mapaVar.ContainsKey(LT(0).getText())){
                                                throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
                                            }}
             | T_TEXT) {ProgramaObj.AddCommand(new CmdEscrita(LT(0).getText()));} T_FPARENT ;

cmd_leia : "leia" T_APARENT T_ID    {if (!mapaVar.ContainsKey(LT(0).getText())){
                                        throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
                                    }
                                    ProgramaObj.AddCommand(new CmdLeitura(LT(0).getText()));
                                    }
             T_FPARENT ;

cmd_enquanto : "enquanto" T_APARENT exp_relacional T_FPARENT T_ACHAVE (comando)+ T_FCHAVE;

cmd_faca : "faca" T_ACHAVE (comando)+ T_FCHAVE "enquanto" T_APARENT exp_relacional T_FPARENT ;

//-------------------- DEFINICOES -------------------

formato : "numeric" | "string" ;

oper_ter : T_SOMA | T_SUBT ;

oper_fat : T_DIV | T_MULT;

pontuacao : T_COMMA | T_APARENT | T_FPARENT | T_DOT | T_UNDERS;

num : T_DIGIT (T_COMMA T_DIGIT)?;

ope_relac : T_MAIOR | T_MENOR | T_MENOR_IGUAL | T_MAIOR_IGUAL | T_IGUAL_RELAC | T_DIF | T_IGUAL;

class IsicompLexer extends Lexer ;
    options
    {
        caseSensitive = true;
	    k=2;
    }

//------------------------ TOKENS ------------------

T_ID : ('a'..'z' | 'A'..'Z') ('a'..'z'| 'A'..'Z'| '0'..'9')* ;

T_DIGIT : ('0'..'9')+;

T_TEXT : T_ASPAS ('a'..'z' | 'A'..'Z' | ' ' | '0'..'9' | ':')+ T_ASPAS;

T_SOMA : '+';

T_SUBT : '-';

T_DIV : '/';

T_MULT : '*';

T_MAIOR : '>';

T_MENOR : '<';

T_IGUAL : ":=";

T_COMMA : ',';

T_APARENT : '(';

T_FPARENT : ')';

T_ASPAS : '"';

T_DOT : '.';

T_UNDERS : '_';

T_ACHAVE : '{';

T_FCHAVE : '}';

T_MAIOR_IGUAL : ">=";

T_MENOR_IGUAL : "<=";

T_IGUAL_RELAC : "==";

T_DIF : "!=";

T_COMMENT : "//" (~('\n' | '\r'))* {$setType(Token.SKIP);};
ML_COMMENT
    :   "/*"
        (
            options {
                generateAmbigWarnings=false;
            }
            :   { LA(2)!='/' }? '*'
            |   '\r' '\n' {newline();}
            |   '\r' {newline();}
            |   '\n' {newline();}
            |   ~('*'|'\n'|'\r')
        )*
        "*/"

        {$setType(Token.SKIP);}
    ;

//--------------------- TABULACAO -------------------

WS : (' ' | '\t' | '\r' | '\n'{newline();}) {_ttype=Token.SKIP;} ;  