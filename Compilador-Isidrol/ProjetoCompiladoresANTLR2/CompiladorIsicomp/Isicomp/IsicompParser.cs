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
		public const int T_SOMA = 10;
		public const int T_SUBT = 11;
		public const int T_num = 12;
		public const int T_DIV = 13;
		public const int T_MULT = 14;
		public const int T_APARENT = 15;
		public const int T_FPARENT = 16;
		public const int LITERAL_se = 17;
		public const int LITERAL_entao = 18;
		public const int T_ACHAVE = 19;
		public const int T_FCHAVE = 20;
		public const int LITERAL_senao = 21;
		public const int T_IGUAL = 22;
		public const int T_TEXT = 23;
		public const int LITERAL_escreva = 24;
		public const int LITERAL_leia = 25;
		public const int LITERAL_enquanto = 26;
		public const int LITERAL_faca = 27;
		public const int LITERAL_numeric = 28;
		public const int LITERAL_string = 29;
		public const int T_UNDERS = 30;
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
			tipo = kv.Value == "numeric" ? Variavel.NUMERICO : kv.Value == "string" ? Variavel.STRING : throw new ApplicationException("Unexpected type in Line: " + LT(0).getLine() + ", Column: " + LT(0).getColumn());
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
			throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
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
					throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
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
			throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
			}
			string ID = LT(0).getText();
			string tID = mapaVar[LT(0).getText()];
			
			match(T_IGUAL);
			{
				switch ( LA(1) )
				{
				case T_ID:
				case T_num:
				{
					exp_ter();
					if(!tID.Equals("numeric")) throw new ApplicationException("Type mismatch in Line: " + LT(0).getLine() + ", column " + LT(0).getColumn() + "\r\n Expecting string got numeric.");
					ProgramaObj.AddCommand(new CmdAtribuicao(ID, string.Join(" ", exprTokens.ToArray()).Replace(",",".")));
					exprTokens.Clear();
					break;
				}
				case T_TEXT:
				{
					match(T_TEXT);
					if(!tID.Equals("string")) 
					throw new ApplicationException("Type mismatch in Line: " + LT(0).getLine() + ", column " + LT(0).getColumn() + "\r\n Expecting numeric got string."); 
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
				int _cnt24=0;
				for (;;)
				{
					if ((tokenSet_1_.member(LA(1))))
					{
						comando();
					}
					else
					{
						if (_cnt24 >= 1) { goto _loop24_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
					}
					
					_cnt24++;
				}
_loop24_breakloop:				;
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
						int _cnt27=0;
						for (;;)
						{
							if ((tokenSet_1_.member(LA(1))))
							{
								comando();
							}
							else
							{
								if (_cnt27 >= 1) { goto _loop27_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
							}
							
							_cnt27++;
						}
_loop27_breakloop:						;
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
				int _cnt35=0;
				for (;;)
				{
					if ((tokenSet_1_.member(LA(1))))
					{
						comando();
					}
					else
					{
						if (_cnt35 >= 1) { goto _loop35_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
					}
					
					_cnt35++;
				}
_loop35_breakloop:				;
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
				int _cnt38=0;
				for (;;)
				{
					if ((tokenSet_1_.member(LA(1))))
					{
						comando();
					}
					else
					{
						if (_cnt38 >= 1) { goto _loop38_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
					}
					
					_cnt38++;
				}
_loop38_breakloop:				;
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
						{
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
						exprTokens.Add(LT(0).getText());
						exp_fat();
					}
					else
					{
						goto _loop12_breakloop;
					}
					
				}
_loop12_breakloop:				;
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
				case T_num:
				{
					match(T_num);
					break;
				}
				case T_ID:
				{
					match(T_ID);
					
						  if (!mapaVar.ContainsKey(LT(0).getText())){
					throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
					}
					
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
			exprTokens.Add(LT(0).getText());
			{    // ( ... )*
				for (;;)
				{
					if ((LA(1)==T_DIV||LA(1)==T_MULT))
					{
						{
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
						exprTokens.Add(LT(0).getText());
						termo();
					}
					else
					{
						goto _loop17_breakloop;
					}
					
				}
_loop17_breakloop:				;
			}    // ( ... )*
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_6_);
		}
	}
	
	public void termo() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case T_num:
			{
				match(T_num);
				exprTokens.Add(LT(0).getText());
				break;
			}
			case T_ID:
			{
				match(T_ID);
				exprTokens.Add(LT(0).getText());
				if (!mapaVar.ContainsKey(LT(0).getText())){
				throw new ApplicationException("ERROR ID "+LT(0).getText()+" not declared!");
				}
				break;
			}
			case T_APARENT:
			{
				match(T_APARENT);
				exprTokens.Add(LT(0).getText());
				exp_ter();
				match(T_FPARENT);
				exprTokens.Add(LT(0).getText());
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
					throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
					}
					break;
				}
				case T_num:
				{
					match(T_num);
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
					throw new ApplicationException("Not declared ID "+LT(0).getText()+" in line: " + LT(0).getLine() + " column: " + LT(0).getColumn());
					}
					break;
				}
				case T_num:
				{
					match(T_num);
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
			recover(ex,tokenSet_8_);
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
			recover(ex,tokenSet_9_);
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
		@"""T_SOMA""",
		@"""T_SUBT""",
		@"""T_num""",
		@"""T_DIV""",
		@"""T_MULT""",
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
		@"""T_UNDERS""",
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
		long[] data = { 251789376L, 0L};
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
		long[] data = { 252838464L, 0L};
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
		long[] data = { 65792L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_5_ = new BitSet(mk_tokenSet_5_());
	private static long[] mk_tokenSet_6_()
	{
		long[] data = { 68864L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_6_ = new BitSet(mk_tokenSet_6_());
	private static long[] mk_tokenSet_7_()
	{
		long[] data = { 93440L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_7_ = new BitSet(mk_tokenSet_7_());
	private static long[] mk_tokenSet_8_()
	{
		long[] data = { 65536L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_8_ = new BitSet(mk_tokenSet_8_());
	private static long[] mk_tokenSet_9_()
	{
		long[] data = { 4160L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_9_ = new BitSet(mk_tokenSet_9_());
	
}
}
