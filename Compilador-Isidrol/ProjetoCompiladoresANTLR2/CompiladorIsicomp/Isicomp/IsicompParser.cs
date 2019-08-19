// $ANTLR 2.7.6 (2005-12-22): "Isicomp.g" -> "IsicompParser.cs"$

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
		public const int WS = 5;
		public const int LITERAL_fimprog = 6;
		public const int T_DOT = 7;
		public const int LITERAL_declare = 8;
		public const int T_ID = 9;
		public const int T_COMMA = 10;
		public const int T_APARENT = 11;
		public const int T_FPARENT = 12;
		public const int LITERAL_se = 13;
		public const int LITERAL_entao = 14;
		public const int LITERAL_senao = 15;
		public const int T_IGUAL = 16;
		public const int LITERAL_escreva = 17;
		public const int T_TEXT = 18;
		public const int LITERAL_leia = 19;
		public const int LITERAL_enquanto = 20;
		public const int T_ACHAVE = 21;
		public const int T_FCHAVE = 22;
		public const int LITERAL_faca = 23;
		public const int T_SOMA = 24;
		public const int T_SUBT = 25;
		public const int T_DIV = 26;
		public const int T_MULT = 27;
		public const int T_UNDERS = 28;
		public const int T_DIGIT = 29;
		public const int T_MAIOR = 30;
		public const int T_MENOR = 31;
		public const int T_MENOR_IGUAL = 32;
		public const int T_MAIOR_IGUAL = 33;
		public const int T_IGUAL_RELAC = 34;
		public const int T_DIF = 35;
		public const int T_ASPAS = 36;
		
		
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
			{
				switch ( LA(1) )
				{
				case WS:
				{
					match(WS);
					break;
				}
				case LITERAL_declare:
				{
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
			declare();
			{
				switch ( LA(1) )
				{
				case WS:
				{
					match(WS);
					break;
				}
				case T_ID:
				case LITERAL_se:
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
			blococomando();
			{
				switch ( LA(1) )
				{
				case WS:
				{
					match(WS);
					break;
				}
				case LITERAL_fimprog:
				{
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
			match(LITERAL_fimprog);
			match(T_DOT);
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
			{
				switch ( LA(1) )
				{
				case WS:
				{
					match(WS);
					break;
				}
				case T_ID:
				{
					break;
				}
				default:
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				 }
			}
			match(T_ID);
			{    // ( ... )*
				for (;;)
				{
					if ((LA(1)==T_COMMA))
					{
						match(T_COMMA);
						match(T_ID);
					}
					else
					{
						goto _loop8_breakloop;
					}
					
				}
_loop8_breakloop:				;
			}    // ( ... )*
			match(T_DOT);
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
				int _cnt11=0;
				for (;;)
				{
					if ((tokenSet_2_.member(LA(1))))
					{
						comando();
					}
					else
					{
						if (_cnt11 >= 1) { goto _loop11_breakloop; } else { throw new NoViableAltException(LT(1), getFilename());; }
					}
					
					_cnt11++;
				}
_loop11_breakloop:				;
			}    // ( ... )+
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_3_);
		}
	}
	
	public void comando() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			switch ( LA(1) )
			{
			case LITERAL_leia:
			{
				leia();
				match(T_DOT);
				break;
			}
			case LITERAL_escreva:
			{
				escreva();
				match(T_DOT);
				break;
			}
			case T_ID:
			{
				atribua();
				match(T_DOT);
				break;
			}
			case LITERAL_se:
			{
				se();
				break;
			}
			case LITERAL_enquanto:
			{
				enquanto();
				break;
			}
			case LITERAL_faca:
			{
				faca();
				match(T_DOT);
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
	
	public void leia() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_leia);
			match(T_APARENT);
			match(T_ID);
			match(T_FPARENT);
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_4_);
		}
	}
	
	public void escreva() //throws RecognitionException, TokenStreamException
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
			match(T_FPARENT);
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_4_);
		}
	}
	
	public void atribua() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(T_ID);
			match(T_IGUAL);
			{
				if ((LA(1)==T_ID||LA(1)==T_DIGIT))
				{
					exp_ter();
				}
				else if ((LA(1)==T_ID)) {
					match(T_ID);
				}
				else
				{
					throw new NoViableAltException(LT(1), getFilename());
				}
				
			}
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_4_);
		}
	}
	
	public void se() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_se);
			match(T_APARENT);
			exp_relacional();
			match(T_FPARENT);
			match(LITERAL_entao);
			blococomando();
			{
				if ((LA(1)==LITERAL_senao))
				{
					match(LITERAL_senao);
					match(LITERAL_entao);
					blococomando();
				}
				else if ((tokenSet_3_.member(LA(1)))) {
				}
				else
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
	
	public void enquanto() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_enquanto);
			match(T_APARENT);
			exp_relacional();
			match(T_FPARENT);
			match(T_ACHAVE);
			blococomando();
			match(T_FCHAVE);
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_3_);
		}
	}
	
	public void faca() //throws RecognitionException, TokenStreamException
{
		
		
		try {      // for error handling
			match(LITERAL_faca);
			match(T_ACHAVE);
			blococomando();
			match(T_FCHAVE);
			match(LITERAL_enquanto);
			match(T_APARENT);
			exp_relacional();
			match(T_FPARENT);
		}
		catch (RecognitionException ex)
		{
			reportError(ex);
			recover(ex,tokenSet_4_);
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
						goto _loop15_breakloop;
					}
					
				}
_loop15_breakloop:				;
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
						goto _loop19_breakloop;
					}
					
				}
_loop19_breakloop:				;
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
			ope_relac();
			{
				switch ( LA(1) )
				{
				case T_ID:
				{
					match(T_ID);
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
		@"""WS""",
		@"""fimprog""",
		@"""T_DOT""",
		@"""declare""",
		@"""T_ID""",
		@"""T_COMMA""",
		@"""T_APARENT""",
		@"""T_FPARENT""",
		@"""se""",
		@"""entao""",
		@"""senao""",
		@"""T_IGUAL""",
		@"""escreva""",
		@"""T_TEXT""",
		@"""leia""",
		@"""enquanto""",
		@"""T_ACHAVE""",
		@"""T_FCHAVE""",
		@"""faca""",
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
		@"""T_ASPAS"""
	};
	
	private static long[] mk_tokenSet_0_()
	{
		long[] data = { 2L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_0_ = new BitSet(mk_tokenSet_0_());
	private static long[] mk_tokenSet_1_()
	{
		long[] data = { 10101280L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_1_ = new BitSet(mk_tokenSet_1_());
	private static long[] mk_tokenSet_2_()
	{
		long[] data = { 10101248L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_2_ = new BitSet(mk_tokenSet_2_());
	private static long[] mk_tokenSet_3_()
	{
		long[] data = { 14328416L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_3_ = new BitSet(mk_tokenSet_3_());
	private static long[] mk_tokenSet_4_()
	{
		long[] data = { 128L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_4_ = new BitSet(mk_tokenSet_4_());
	private static long[] mk_tokenSet_5_()
	{
		long[] data = { 4224L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_5_ = new BitSet(mk_tokenSet_5_());
	private static long[] mk_tokenSet_6_()
	{
		long[] data = { 50335872L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_6_ = new BitSet(mk_tokenSet_6_());
	private static long[] mk_tokenSet_7_()
	{
		long[] data = { 536871424L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_7_ = new BitSet(mk_tokenSet_7_());
	private static long[] mk_tokenSet_8_()
	{
		long[] data = { 67897462912L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_8_ = new BitSet(mk_tokenSet_8_());
	private static long[] mk_tokenSet_9_()
	{
		long[] data = { 536873472L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_9_ = new BitSet(mk_tokenSet_9_());
	private static long[] mk_tokenSet_10_()
	{
		long[] data = { 251662464L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_10_ = new BitSet(mk_tokenSet_10_());
	private static long[] mk_tokenSet_11_()
	{
		long[] data = { 4096L, 0L};
		return data;
	}
	public static readonly BitSet tokenSet_11_ = new BitSet(mk_tokenSet_11_());
	
}
}
