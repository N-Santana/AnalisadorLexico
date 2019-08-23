// $ANTLR 2.7.6 (2005-12-22): "Isicomp.g" -> "IsicompParser.cs"$

    using System.Collections.Generic;

namespace Isicomp
{
	// Generate the header common to all output files.
	using System;
	
	using TokenBuffer              = antlr.TokenBuffer;
	using TokenStreamException     = antlr.TokenStreamException;
	using TokenStreamIOException   = antlr.TokenStreamIOException;
	using ANTLRException           = antlr.ANTLRException;
	using LLkParser = antlr.LLkParser;
	using Token                    = antlr.Token;
	using IToken                   = antlr.IToken;
	using TokenStream              = antlr.TokenStream;
	using RecognitionException     = antlr.RecognitionException;
	using NoViableAltException     = antlr.NoViableAltException;
	using MismatchedTokenException = antlr.MismatchedTokenException;
	using SemanticException        = antlr.SemanticException;
	using ParserSharedInputState   = antlr.ParserSharedInputState;
	using BitSet                   = antlr.collections.impl.BitSet;
	
	public 	class IsicompParser : antlr.LLkParser
	{
		public const int EOF = 1;
		public const int NULL_TREE_LOOKAHEAD = 3;
		public const int LITERAL_programa = 4;
		public const int LITERAL_declare = 5;
		public const int T_ID = 6;
		public const int T_COMMA = 7;
		public const int T_DOT = 8;
		public const int LITERAL_fimprog = 9;
		public const int T_APARENT = 10;
		public const int T_FPARENT = 11;
		public const int LITERAL_se = 12;
		public const int LITERAL_entao = 13;
		public const int T_ACHAVE = 14;
		public const int T_FCHAVE = 15;
		public const int LITERAL_senao = 16;
		public const int T_IGUAL = 17;
		public const int T_TEXT = 18;
		public const int LITERAL_escreva = 19;
		public const int LITERAL_leia = 20;
		public const int LITERAL_enquanto = 21;
		public const int LITERAL_faca = 22;
		public const int LITERAL_numeric = 23;
		public const int LITERAL_string = 24;
		public const int T_SOMA = 25;
		public const int T_SUBT = 26;
		public const int T_DIV = 27;
		public const int T_MULT = 28;
		public const int T_UNDERS = 29;
		public const int T_DIGIT = 30;
		public const int T_MAIOR = 31;
		public const int T_MENOR = 32;
		public const int T_MENOR_IGUAL = 33;
		public const int T_MAIOR_IGUAL = 34;
		public const int T_IGUAL_RELAC = 35;
		public const int T_DIF = 36;
		public const int T_ASPAS = 37;
		public const int T_COMMENT = 38;
		public const int ML_COMMENT = 39;
		public const int WS = 40;
		
		
        string id1OpRelacional = "";
        string opOpRelacional = "";
        string id2OpRelacional = "";

        Expression expression;
        AbstractOperand numb;
        BinaryOperand sumOrSubt;
        AbstractOperand parent;
        BinaryOperand multOrDiv;
        char op;
        public Programa ProgramaObj {get; set;}

        // para o mapVar: key = id; value = formato;
        public Dictionary<string, string> mapaVar = new Dictionary<string, string>();
		
		protected void initialize()
		{
			tokenNames = tokenNames_;
		}
		
		
		protected IsicompParser(TokenBuffer tokenBuf, int k) : base(tokenBuf, k)
		{
			initialize();
		}
		
		public IsicompParser(TokenBuffer tokenBuf) : this(tokenBuf,1)
		{
		}
		
		protected IsicompParser(TokenStream lexer, int k) : base(lexer,k)
		{
			initialize();
		}
		
		public IsicompParser(TokenStream lexer) : this(lexer,1)
		{
		}
		
		public IsicompParser(ParserSharedInputState state) : base(state,1)
		{
			initialize();
		}
		
	public void programa() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_programa);
			declare();
			blococomando();
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_0_);
		}
	}
	
	public void declare() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_declare);
			formato();
			match(T_ID);
			mapaVar.Add(LT(0).getText(), LT(-1).getText());
			{    // ( ... )*
				for (;;)
				{
					if ((LA(1)==T_COMMA))
					{
						match(T_COMMA);
						formato();
						match(T_ID);
						mapaVar.Add(LT(0).getText(), LT(-1).getText());
					}
					else
					{
						goto _loop4_breakloop;
					}
					
				}
_loop4_breakloop:				;
			}    // ( ... )*
			match(T_DOT);
			
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
			
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_1_);
		}
	}
	
	public void blococomando() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			{ // ( ... )+
				int _cnt7=0;
				for (;;)
				{
					if ((tokenSet_1_.member(LA(1))))
					{
						comando();
					}
					else
					{
						if (_cnt7 >= 1) { goto _loop7_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
					}
					
					_cnt7++;
				}
_loop7_breakloop:				;
			}    // ( ... )+
			match(LITERAL_fimprog);
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_0_);
		}
	}
	
	public void formato() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case LITERAL_numeric:
			{
				match(LITERAL_numeric);
				break;
			}
			case LITERAL_string:
			{
				match(LITERAL_string);
				break;
			}
			default:
			{
				throw new NoViableAltException(LT(1), getFilename());
			}
			 }
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_2_);
		}
	}
	
	public void comando() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case LITERAL_leia:
			{
				cmd_leia();
				match(T_DOT);
				break;
			}
			case LITERAL_escreva:
			{
				cmd_escreva();
				match(T_DOT);
				break;
			}
			case T_ID:
			{
				cmd_atribua();
				match(T_DOT);
				break;
			}
			case LITERAL_se:
			{
				cmd_se();
				break;
			}
			case LITERAL_enquanto:
			{
				cmd_enquanto();
				break;
			}
			case LITERAL_faca:
			{
				cmd_faca();
				break;
			}
			default:
			{
				throw new NoViableAltException(LT(1), getFilename());
			}
			 }
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_3_);
		}
	}
	
	public void cmd_leia() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_leia);
			match(T_APARENT);
			match(T_ID);
			if (!mapaVar.ContainsKey(LT(0).getText())){
			throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
			}
			ProgramaObj.AddCommand(new CmdLeitura(LT(0).getText()));
			
			match(T_FPARENT);
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_4_);
		}
	}
	
	public void cmd_escreva() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_escreva);
			match(T_APARENT);
			{
				switch ( LA(1) )
				{
				case T_ID:
				{
					match(T_ID);
					if (!mapaVar.ContainsKey(LT(0).getText())){
					throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
					}
					break;
				}
				case T_TEXT:
				{
					match(T_TEXT);
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
			ProgramaObj.AddCommand(new CmdEscrita(LT(0).getText()));
			match(T_FPARENT);
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_4_);
		}
	}
	
	public void cmd_atribua() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(T_ID);
			if (!mapaVar.ContainsKey(LT(0).getText())){
			throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
			}
			string ID = LT(0).getText();
			string tID = mapaVar[LT(0).getText()];
			
			match(T_IGUAL);
			{
				switch ( LA(1) )
				{
				case T_ID:
				case T_DIGIT:
				{
					exp_ter();
					if(!tID.Equals("numeric")) throw new ApplicationException(" MISMATCHED TYPES ATRIBUITION BETWEEN A STRING ID AN A NON STRING ATRIBUITION.");
					break;
				}
				case T_TEXT:
				{
					match(T_TEXT);
					if(!tID.Equals("string")) 
					throw new ApplicationException(" MISMATCHED TYPES ATRIBUITION BETWEEN A NUMERIC ID AN A NON NUMERIC ATRIBUITION."); 
					ProgramaObj.AddCommand(new CmdAtribuicao(ID, LT(0).getText()));
					
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_4_);
		}
	}
	
	public void cmd_se() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_se);
			match(T_APARENT);
			exp_relacional();
			match(T_FPARENT);
			ProgramaObj.AddCommand(new CmdSe(id1OpRelacional, opOpRelacional, id2OpRelacional));
			match(LITERAL_entao);
			match(T_ACHAVE);
			{ // ( ... )+
				int _cnt22=0;
				for (;;)
				{
					if ((tokenSet_1_.member(LA(1))))
					{
						comando();
					}
					else
					{
						if (_cnt22 >= 1) { goto _loop22_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
					}
					
					_cnt22++;
				}
_loop22_breakloop:				;
			}    // ( ... )+
			match(T_FCHAVE);
			ProgramaObj.AddCommand(new FChave());
			{
				switch ( LA(1) )
				{
				case LITERAL_senao:
				{
					match(LITERAL_senao);
					match(T_ACHAVE);
					ProgramaObj.AddCommand(new CmdSenao());
					{ // ( ... )+
						int _cnt25=0;
						for (;;)
						{
							if ((tokenSet_1_.member(LA(1))))
							{
								comando();
							}
							else
							{
								if (_cnt25 >= 1) { goto _loop25_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
							}
							
							_cnt25++;
						}
_loop25_breakloop:						;
					}    // ( ... )+
					match(T_FCHAVE);
					ProgramaObj.AddCommand(new FChave());
					break;
				}
				case T_ID:
				case LITERAL_fimprog:
				case LITERAL_se:
				case T_FCHAVE:
				case LITERAL_escreva:
				case LITERAL_leia:
				case LITERAL_enquanto:
				case LITERAL_faca:
				{
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_3_);
		}
	}
	
	public void cmd_enquanto() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_enquanto);
			match(T_APARENT);
			exp_relacional();
			match(T_FPARENT);
			ProgramaObj.AddCommand(new CmdEnqto(id1OpRelacional, opOpRelacional, id2OpRelacional, false));
			match(T_ACHAVE);
			{ // ( ... )+
				int _cnt33=0;
				for (;;)
				{
					if ((tokenSet_1_.member(LA(1))))
					{
						comando();
					}
					else
					{
						if (_cnt33 >= 1) { goto _loop33_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
					}
					
					_cnt33++;
				}
_loop33_breakloop:				;
			}    // ( ... )+
			match(T_FCHAVE);
			ProgramaObj.AddCommand(new FChave());
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_3_);
		}
	}
	
	public void cmd_faca() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_faca);
			match(T_ACHAVE);
			ProgramaObj.AddCommand(new CmdFaca());
			{ // ( ... )+
				int _cnt36=0;
				for (;;)
				{
					if ((tokenSet_1_.member(LA(1))))
					{
						comando();
					}
					else
					{
						if (_cnt36 >= 1) { goto _loop36_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
					}
					
					_cnt36++;
				}
_loop36_breakloop:				;
			}    // ( ... )+
			match(T_FCHAVE);
			ProgramaObj.AddCommand(new FChave());
			match(LITERAL_enquanto);
			match(T_APARENT);
			exp_relacional();
			match(T_FPARENT);
			ProgramaObj.AddCommand(new CmdEnqto(id1OpRelacional, opOpRelacional, id2OpRelacional, true));
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_3_);
		}
	}
	
	public void exp_ter() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			exp_fat();
			{    // ( ... )*
				for (;;)
				{
					if ((LA(1)==T_SOMA||LA(1)==T_SUBT))
					{
						oper_ter();
						exp_fat();
					}
					else
					{
						goto _loop11_breakloop;
					}
					
				}
_loop11_breakloop:				;
			}    // ( ... )*
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_5_);
		}
	}
	
	public void exp_fat() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			{
				switch ( LA(1) )
				{
				case T_DIGIT:
				{
					num();
					break;
				}
				case T_ID:
				{
					match(T_ID);
					
						  if (!mapaVar.ContainsKey(LT(0).getText())){
					throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
					}
					
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
			{    // ( ... )*
				for (;;)
				{
					if ((LA(1)==T_DIV||LA(1)==T_MULT))
					{
						oper_fat();
						termo();
					}
					else
					{
						goto _loop15_breakloop;
					}
					
				}
_loop15_breakloop:				;
			}    // ( ... )*
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_6_);
		}
	}
	
	public void oper_ter() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case T_SOMA:
			{
				match(T_SOMA);
				break;
			}
			case T_SUBT:
			{
				match(T_SUBT);
				break;
			}
			default:
			{
				throw new NoViableAltException(LT(1), getFilename());
			}
			 }
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_7_);
		}
	}
	
	public void num() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(T_DIGIT);
			{
				switch ( LA(1) )
				{
				case T_COMMA:
				{
					match(T_COMMA);
					match(T_DIGIT);
					break;
				}
				case T_DOT:
				case T_FPARENT:
				case T_IGUAL:
				case T_SOMA:
				case T_SUBT:
				case T_DIV:
				case T_MULT:
				case T_MAIOR:
				case T_MENOR:
				case T_MENOR_IGUAL:
				case T_MAIOR_IGUAL:
				case T_IGUAL_RELAC:
				case T_DIF:
				{
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_8_);
		}
	}
	
	public void oper_fat() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case T_DIV:
			{
				match(T_DIV);
				break;
			}
			case T_MULT:
			{
				match(T_MULT);
				break;
			}
			default:
			{
				throw new NoViableAltException(LT(1), getFilename());
			}
			 }
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_9_);
		}
	}
	
	public void termo() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case T_DIGIT:
			{
				num();
				break;
			}
			case T_ID:
			{
				match(T_ID);
				if (!mapaVar.ContainsKey(LT(0).getText())){
				throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
				}
				break;
			}
			case T_APARENT:
			{
				match(T_APARENT);
				exp_ter();
				match(T_FPARENT);
				break;
			}
			default:
			{
				throw new NoViableAltException(LT(1), getFilename());
			}
			 }
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_10_);
		}
	}
	
	public void exp_relacional() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			{
				switch ( LA(1) )
				{
				case T_ID:
				{
					match(T_ID);
					if (!mapaVar.ContainsKey(LT(0).getText())){
					throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
					}
					break;
				}
				case T_DIGIT:
				{
					num();
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
			id1OpRelacional = LT(0).getText();
			ope_relac();
			opOpRelacional = LT(0).getText();
			{
				switch ( LA(1) )
				{
				case T_ID:
				{
					match(T_ID);
					if (!mapaVar.ContainsKey(LT(0).getText())){
					throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
					}
					break;
				}
				case T_DIGIT:
				{
					num();
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
			id2OpRelacional = LT(0).getText();
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_11_);
		}
	}
	
	public void ope_relac() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case T_MAIOR:
			{
				match(T_MAIOR);
				break;
			}
			case T_MENOR:
			{
				match(T_MENOR);
				break;
			}
			case T_MENOR_IGUAL:
			{
				match(T_MENOR_IGUAL);
				break;
			}
			case T_MAIOR_IGUAL:
			{
				match(T_MAIOR_IGUAL);
				break;
			}
			case T_IGUAL_RELAC:
			{
				match(T_IGUAL_RELAC);
				break;
			}
			case T_DIF:
			{
				match(T_DIF);
				break;
			}
			case T_IGUAL:
			{
				match(T_IGUAL);
				break;
			}
			default:
			{
				throw new NoViableAltException(LT(1), getFilename());
			}
			 }
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_7_);
		}
	}
	
	public void pontuacao() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case T_COMMA:
			{
				match(T_COMMA);
				break;
			}
			case T_APARENT:
			{
				match(T_APARENT);
				break;
			}
			case T_FPARENT:
			{
				match(T_FPARENT);
				break;
			}
			case T_DOT:
			{
				match(T_DOT);
				break;
			}
			case T_UNDERS:
			{
				match(T_UNDERS);
				break;
			}
			default:
			{
				throw new NoViableAltException(LT(1), getFilename());
			}
			 }
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_0_);
		}
	}
	
	private void initializeFactory()
	{
	}
	
	public static readonly string[] tokenNames_ = new string[] {
		@"""<0>""",
		@"""EOF""",
		@"""<2>""",
		@"""NULL_TREE_LOOKAHEAD""",
		@"""programa""",
		@"""declare""",
		@"""T_ID""",
		@"""T_COMMA""",
		@"""T_DOT""",
		@"""fimprog""",
		@"""T_APARENT""",
		@"""T_FPARENT""",
		@"""se""",
		@"""entao""",
		@"""T_ACHAVE""",
		@"""T_FCHAVE""",
		@"""senao""",
		@"""T_IGUAL""",
		@"""T_TEXT""",
		@"""escreva""",
		@"""leia""",
		@"""enquanto""",
		@"""faca""",
		@"""numeric""",
		@"""string""",
		@"""T_SOMA""",
		@"""T_SUBT""",
		@"""T_DIV""",
		@"""T_MULT""",
		@"""T_UNDERS""",
		@"""T_DIGIT""",
		@"""T_MAIOR""",
		@"""T_MENOR""",
		@"""T_MENOR_IGUAL""",
		@"""T_MAIOR_IGUAL""",
		@"""T_IGUAL_RELAC""",
		@"""T_DIF""",
		@"""T_ASPAS""",
		@"""T_COMMENT""",
		@"""ML_COMMENT""",
		@"""WS"""
	};
	
	private static long[] mk_tokenSet_0_()
	{
		long[] data = { 2L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_0_ = new BitSet(mk_tokenSet_0_());
	private static long[] mk_tokenSet_1_()
	{
		long[] data = { 7868480L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_1_ = new BitSet(mk_tokenSet_1_());
	private static long[] mk_tokenSet_2_()
	{
		long[] data = { 64L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_2_ = new BitSet(mk_tokenSet_2_());
	private static long[] mk_tokenSet_3_()
	{
		long[] data = { 7901760L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_3_ = new BitSet(mk_tokenSet_3_());
	private static long[] mk_tokenSet_4_()
	{
		long[] data = { 256L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_4_ = new BitSet(mk_tokenSet_4_());
	private static long[] mk_tokenSet_5_()
	{
		long[] data = { 2304L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_5_ = new BitSet(mk_tokenSet_5_());
	private static long[] mk_tokenSet_6_()
	{
		long[] data = { 100665600L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_6_ = new BitSet(mk_tokenSet_6_());
	private static long[] mk_tokenSet_7_()
	{
		long[] data = { 1073741888L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_7_ = new BitSet(mk_tokenSet_7_());
	private static long[] mk_tokenSet_8_()
	{
		long[] data = { 135794919680L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_8_ = new BitSet(mk_tokenSet_8_());
	private static long[] mk_tokenSet_9_()
	{
		long[] data = { 1073742912L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_9_ = new BitSet(mk_tokenSet_9_());
	private static long[] mk_tokenSet_10_()
	{
		long[] data = { 503318784L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_10_ = new BitSet(mk_tokenSet_10_());
	private static long[] mk_tokenSet_11_()
	{
		long[] data = { 2048L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_11_ = new BitSet(mk_tokenSet_11_());
	
}
}
