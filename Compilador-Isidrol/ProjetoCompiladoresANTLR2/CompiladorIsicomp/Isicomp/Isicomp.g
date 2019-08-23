header {
    using System.Collections.Generic;
}

options {
    language  = "CSharp";
    namespace = "Isicomp";
}

class IsicompParser extends Parser;   
{
        string id1OpRelacional = "";
        string opOpRelacional = "";
        string id2OpRelacional = "";

        List<string> exprTokens = new List<string>();

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
                 tipo = kv.Value == "numeric" ? Variavel.NUMERICO : kv.Value == "string" ? Variavel.STRING : throw new ApplicationException("Unexpected type in Line: " + LT(0).getLine() + ", Column: " + LT(0).getColumn());
                 vars.Add(new Variavel(nome, tipo));
             }
             ProgramaObj.Variaveis = vars;
         };

blococomando : (comando)+ "fimprog" ;

comando : cmd_leia T_DOT | cmd_escreva T_DOT | cmd_atribua T_DOT |  cmd_se | cmd_enquanto | cmd_faca ;

//--------------------- REGRAS ----------------------

exp_ter : exp_fat 
            ((T_SOMA | T_SUBT) {exprTokens.Add(LT(0).getText());} exp_fat)*;

exp_fat : (T_num | T_ID            {
           	  if (!mapaVar.ContainsKey(LT(0).getText())){
                 throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
             }
           }  

        ) {exprTokens.Add(LT(0).getText());} ((T_DIV | T_MULT) {exprTokens.Add(LT(0).getText());} termo)*;

termo : T_num{exprTokens.Add(LT(0).getText());} | T_ID {exprTokens.Add(LT(0).getText());}
            	  {if (!mapaVar.ContainsKey(LT(0).getText())){
                 throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
             }}
             | T_APARENT {exprTokens.Add(LT(0).getText());} exp_ter T_FPARENT {exprTokens.Add(LT(0).getText());} ; 

exp_relacional : (T_ID  {if (!mapaVar.ContainsKey(LT(0).getText())){
                            throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
                        }}
             | T_num) {id1OpRelacional = LT(0).getText();}
             ope_relac{opOpRelacional = LT(0).getText();} (T_ID     {if (!mapaVar.ContainsKey(LT(0).getText())){
                                            throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
                                        }}
             | T_num) {id2OpRelacional = LT(0).getText();};

cmd_se : "se" T_APARENT exp_relacional T_FPARENT {ProgramaObj.AddCommand(new CmdSe(id1OpRelacional, opOpRelacional, id2OpRelacional));} "entao" T_ACHAVE (comando)+ T_FCHAVE {ProgramaObj.AddCommand(new FChave());}
 ("senao" T_ACHAVE {ProgramaObj.AddCommand(new CmdSenao());} (comando)+ T_FCHAVE {ProgramaObj.AddCommand(new FChave());} )?;

cmd_atribua : T_ID  {   if (!mapaVar.ContainsKey(LT(0).getText())){
                            throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
                        }
                        string ID = LT(0).getText();
                        string tID = mapaVar[LT(0).getText()];
                    }
              T_IGUAL (exp_ter { if(!tID.Equals("numeric")) throw new ApplicationException("Type mismatch in Line: " + LT(0).getLine() + ", column " + LT(0).getColumn() + "\r\n Expecting string got numeric."); }
                        {ProgramaObj.AddCommand(new CmdAtribuicao(ID, string.Join(" ", exprTokens.ToArray()).Replace(",",".")));
                        exprTokens.Clear();}
              | T_TEXT {    if(!tID.Equals("string")) 
                                throw new ApplicationException("Type mismatch in Line: " + LT(0).getLine() + ", column " + LT(0).getColumn() + "\r\n Expecting numeric got string."); 
                                ProgramaObj.AddCommand(new CmdAtribuicao(ID, LT(0).getText()));
                            }
              );     

cmd_escreva : "escreva" T_APARENT (T_ID    {if (!mapaVar.ContainsKey(LT(0).getText())){
                                                throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
                                            }}
             | T_TEXT) {ProgramaObj.AddCommand(new CmdEscrita(LT(0).getText()));} T_FPARENT ;

cmd_leia : "leia" T_APARENT T_ID    {if (!mapaVar.ContainsKey(LT(0).getText())){
                                        throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
                                    }
                                    ProgramaObj.AddCommand(new CmdLeitura(LT(0).getText()));
                                    }
             T_FPARENT ;

cmd_enquanto : "enquanto" T_APARENT exp_relacional T_FPARENT
{ProgramaObj.AddCommand(new CmdEnqto(id1OpRelacional, opOpRelacional, id2OpRelacional, false));}
 T_ACHAVE (comando)+ T_FCHAVE {ProgramaObj.AddCommand(new FChave());};

cmd_faca : "faca" T_ACHAVE {ProgramaObj.AddCommand(new CmdFaca());}(comando)+ 
T_FCHAVE {ProgramaObj.AddCommand(new FChave());}
"enquanto" T_APARENT exp_relacional T_FPARENT {ProgramaObj.AddCommand(new CmdEnqto(id1OpRelacional, opOpRelacional, id2OpRelacional, true));};

//-------------------- DEFINICOES -------------------

formato : "numeric" | "string" ;

//oper_ter : T_SOMA | T_SUBT ;

//oper_fat : T_DIV | T_MULT;

pontuacao : T_COMMA | T_APARENT | T_FPARENT | T_DOT | T_UNDERS;

//num : T_DIGIT (T_COMMA T_DIGIT)?;

ope_relac : T_MAIOR | T_MENOR | T_MENOR_IGUAL | T_MAIOR_IGUAL | T_IGUAL_RELAC | T_DIF | T_IGUAL;

class IsicompLexer extends Lexer ;
    options
    {
        caseSensitive = true;
	    k=2;
    }

//------------------------ TOKENS ------------------

T_ID : ('a'..'z' | 'A'..'Z') ('a'..'z'| 'A'..'Z'| '0'..'9')* ;

//T_DIGIT : ('0'..'9')+;

T_num 	: ('0'..'9')+ ((',') ('0'..'9')+)?
		;

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