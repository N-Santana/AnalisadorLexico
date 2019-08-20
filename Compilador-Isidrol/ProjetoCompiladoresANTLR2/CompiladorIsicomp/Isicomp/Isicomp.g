options {
    language  = "CSharp";
    namespace = "Isicomp";
}

class IsicompParser extends Parser;   

//--------------- SINTAXE CODIGO -------------------

programa : "programa" declare corpoprograma ;

declare : "declare"  formato T_ID (T_COMMA formato T_ID)* T_DOT;

corpoprograma : blococomando "fimprog" T_DOT;

blococomando : (comando)+;

comando : cmd_leia T_DOT | cmd_escreva T_DOT | cmd_atribua T_DOT | cmd_se | cmd_enquanto | cmd_faca ;

//--------------------- REGRAS ----------------------

formato : "int" | "string" ;

exp_ter : exp_fat (oper_ter exp_fat)*;

exp_fat : (num | T_ID) (oper_fat termo)*;

exp_relacional : (T_ID | num) ope_relac (T_ID | num);

termo : num | T_ID | T_APARENT exp_ter T_FPARENT ; 

cmd_se : "se" T_APARENT exp_relacional T_FPARENT "entao" blococomando ("senao" "entao" blococomando )?;

cmd_atribua : T_ID T_IGUAL (exp_ter | T_ID) ; 

cmd_escreva : "escreva" T_APARENT (T_ID | T_TEXT) T_FPARENT ;

cmd_leia : "leia" T_APARENT T_ID T_FPARENT ;

cmd_enquanto : "enquanto" T_APARENT exp_relacional T_FPARENT T_ACHAVE blococomando T_FCHAVE;

cmd_faca : "faca" T_ACHAVE blococomando T_FCHAVE "enquanto" T_APARENT exp_relacional T_FPARENT ;

//-------------------- DEFINICOES -------------------

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

T_TEXT : T_ASPAS ('a'..'z' | 'A'..'Z' | ' ')+ T_ASPAS;

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

//--------------------- TABULACAO -------------------

WS : (' ' | '\t' | '\r' | '\n'{newline();}) {_ttype=Token.SKIP;} ;  