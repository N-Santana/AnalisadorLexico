grammar Isicomp;

//--------------- SINTAXE CODIGO -------------------

programa : 'programa' declare blococomando 'fimprog' T_DOT;

declare : 'declare' ID (T_COMMA ID)* T_DOT;

blococomando : (comando)+;

comando : leia | escreva | atribua | se | enquanto | faca ;

//--------------------- REGRAS ----------------------

exp_ter : exp_fat (OPER_TER exp_fat)*;

exp_fat : NUM (OPER_FAT termo)*;

exp_relacional : (ID | NUM) OPE_RELAC (ID | NUM);

termo : NUM | ID | T_APARENT exp_ter T_FPARENT ; 

se : 'se' T_APARENT exp_relacional T_FPARENT 'entao' blococomando  ('senao' 'entao' blococomando )?;

atribua : ID T_IGUAL exp_ter T_DOT; 

escreva : 'escreva' T_APARENT (ID | string) T_FPARENT T_DOT;

leia : 'leia' T_APARENT ID T_FPARENT T_DOT;

enquanto : 'enquanto' T_APARENT exp_relacional T_FPARENT T_ACHAVE blococomando T_FCHAVE;

faca : 'faca' T_ACHAVE blococomando T_FCHAVE 'enquanto' T_APARENT exp_relacional T_FPARENT T_DOT;

string : T_ASPAS (LETTER | NUM | WS)+ T_ASPAS;

//-------------------- DEFINIÇÕES -------------------

FORMAT : T_STRING | T_CHAR | T_BYTE | T_INT | T_FLOAT | T_DOUBLE;

ID : (LETTER)+ (DIGIT | LETTER)*;

OPER_TER : T_SOMA | T_SUBT ;

OPER_FAT : T_DIV | T_MULT;

PONTUACAO : T_COMMA | T_APARENT | T_FPARENT | T_DOT | T_UNDERS;

NUM : (DIGIT)+ (T_COMMA (DIGIT)+)?;

OPE_RELAC : T_MAIOR | T_MENOR | T_MENOR_IGUAL | T_MAIOR_IGUAL | T_IGUAL_RELAC | T_DIF | T_IGUAL;

DIGIT : ([0-9])+;

LETTER : ([a-z ]| [A-Z])+;

//------------------------ TOKENS ------------------

T_NULL : 'nulo';

T_STRING : 'string';

T_CHAR : 'char';

T_BYTE : 'byte';

T_INT : 'int';

T_FLOAT : 'float';

T_DOUBLE : 'double';

T_SOMA : '+';

T_SUBT : '-';

T_DIV : '/';

T_MULT : '*';

T_MAIOR : '>';

T_MENOR : '<';

T_IGUAL : ':=';

T_COMMA : ',';

T_APARENT : '(';

T_FPARENT : ')';

T_ASPAS : '"';

T_DOT : '.';

T_UNDERS : '_';

T_ACHAVE : '{';

T_FCHAVE : '}';

T_MAIOR_IGUAL : '>=';

T_MENOR_IGUAL : '<=';

T_IGUAL_RELAC : '==';

T_DIF : '!=';

//--------------------- TABULAÇÃO -------------------

WS : [\t\r\n]+ -> skip; // pula espaços, tabs, novas linhas

