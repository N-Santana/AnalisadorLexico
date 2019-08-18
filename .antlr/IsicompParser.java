// Generated from /home/natx/Documentos/DEV/Compiladores/AnalisadorLexico/Isicomp.g4 by ANTLR 4.7.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class IsicompParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, FORMAT=11, ID=12, OPER_TER=13, OPER_FAT=14, PONTUACAO=15, NUM=16, 
		OPE_RELAC=17, DIGIT=18, LETTER=19, T_NULL=20, T_STRING=21, T_CHAR=22, 
		T_BYTE=23, T_INT=24, T_FLOAT=25, T_DOUBLE=26, T_SOMA=27, T_SUBT=28, T_DIV=29, 
		T_MULT=30, T_MAIOR=31, T_MENOR=32, T_IGUAL=33, T_COMMA=34, T_APARENT=35, 
		T_FPARENT=36, T_ASPAS=37, T_DOT=38, T_UNDERS=39, T_ACHAVE=40, T_FCHAVE=41, 
		T_MAIOR_IGUAL=42, T_MENOR_IGUAL=43, T_IGUAL_RELAC=44, T_DIF=45, WS=46;
	public static final int
		RULE_programa = 0, RULE_declare = 1, RULE_blococomando = 2, RULE_comando = 3, 
		RULE_exp_ter = 4, RULE_exp_fat = 5, RULE_exp_relacional = 6, RULE_termo = 7, 
		RULE_se = 8, RULE_atribua = 9, RULE_escreva = 10, RULE_leia = 11, RULE_enquanto = 12, 
		RULE_faca = 13, RULE_string = 14;
	public static final String[] ruleNames = {
		"programa", "declare", "blococomando", "comando", "exp_ter", "exp_fat", 
		"exp_relacional", "termo", "se", "atribua", "escreva", "leia", "enquanto", 
		"faca", "string"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'programa'", "'fimprog'", "'declare'", "'se'", "'entao'", "'senao'", 
		"'escreva'", "'leia'", "'enquanto'", "'faca'", null, null, null, null, 
		null, null, null, null, null, "'nulo'", "'string'", "'char'", "'byte'", 
		"'int'", "'float'", "'double'", "'+'", "'-'", "'/'", "'*'", "'>'", "'<'", 
		"':='", "','", "'('", "')'", "'\"'", "'.'", "'_'", "'{'", "'}'", "'>='", 
		"'<='", "'=='", "'!='"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, null, null, null, null, null, null, null, null, "FORMAT", 
		"ID", "OPER_TER", "OPER_FAT", "PONTUACAO", "NUM", "OPE_RELAC", "DIGIT", 
		"LETTER", "T_NULL", "T_STRING", "T_CHAR", "T_BYTE", "T_INT", "T_FLOAT", 
		"T_DOUBLE", "T_SOMA", "T_SUBT", "T_DIV", "T_MULT", "T_MAIOR", "T_MENOR", 
		"T_IGUAL", "T_COMMA", "T_APARENT", "T_FPARENT", "T_ASPAS", "T_DOT", "T_UNDERS", 
		"T_ACHAVE", "T_FCHAVE", "T_MAIOR_IGUAL", "T_MENOR_IGUAL", "T_IGUAL_RELAC", 
		"T_DIF", "WS"
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "Isicomp.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public IsicompParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class ProgramaContext extends ParserRuleContext {
		public DeclareContext declare() {
			return getRuleContext(DeclareContext.class,0);
		}
		public BlococomandoContext blococomando() {
			return getRuleContext(BlococomandoContext.class,0);
		}
		public TerminalNode T_DOT() { return getToken(IsicompParser.T_DOT, 0); }
		public ProgramaContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_programa; }
	}

	public final ProgramaContext programa() throws RecognitionException {
		ProgramaContext _localctx = new ProgramaContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_programa);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(30);
			match(T__0);
			setState(31);
			declare();
			setState(32);
			blococomando();
			setState(33);
			match(T__1);
			setState(34);
			match(T_DOT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class DeclareContext extends ParserRuleContext {
		public List<TerminalNode> ID() { return getTokens(IsicompParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(IsicompParser.ID, i);
		}
		public TerminalNode T_DOT() { return getToken(IsicompParser.T_DOT, 0); }
		public List<TerminalNode> T_COMMA() { return getTokens(IsicompParser.T_COMMA); }
		public TerminalNode T_COMMA(int i) {
			return getToken(IsicompParser.T_COMMA, i);
		}
		public DeclareContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_declare; }
	}

	public final DeclareContext declare() throws RecognitionException {
		DeclareContext _localctx = new DeclareContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_declare);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(36);
			match(T__2);
			setState(37);
			match(ID);
			setState(42);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==T_COMMA) {
				{
				{
				setState(38);
				match(T_COMMA);
				setState(39);
				match(ID);
				}
				}
				setState(44);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(45);
			match(T_DOT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class BlococomandoContext extends ParserRuleContext {
		public List<ComandoContext> comando() {
			return getRuleContexts(ComandoContext.class);
		}
		public ComandoContext comando(int i) {
			return getRuleContext(ComandoContext.class,i);
		}
		public BlococomandoContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_blococomando; }
	}

	public final BlococomandoContext blococomando() throws RecognitionException {
		BlococomandoContext _localctx = new BlococomandoContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_blococomando);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(48); 
			_errHandler.sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					setState(47);
					comando();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(50); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,1,_ctx);
			} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ComandoContext extends ParserRuleContext {
		public LeiaContext leia() {
			return getRuleContext(LeiaContext.class,0);
		}
		public EscrevaContext escreva() {
			return getRuleContext(EscrevaContext.class,0);
		}
		public AtribuaContext atribua() {
			return getRuleContext(AtribuaContext.class,0);
		}
		public SeContext se() {
			return getRuleContext(SeContext.class,0);
		}
		public EnquantoContext enquanto() {
			return getRuleContext(EnquantoContext.class,0);
		}
		public FacaContext faca() {
			return getRuleContext(FacaContext.class,0);
		}
		public ComandoContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_comando; }
	}

	public final ComandoContext comando() throws RecognitionException {
		ComandoContext _localctx = new ComandoContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_comando);
		try {
			setState(58);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__7:
				enterOuterAlt(_localctx, 1);
				{
				setState(52);
				leia();
				}
				break;
			case T__6:
				enterOuterAlt(_localctx, 2);
				{
				setState(53);
				escreva();
				}
				break;
			case ID:
				enterOuterAlt(_localctx, 3);
				{
				setState(54);
				atribua();
				}
				break;
			case T__3:
				enterOuterAlt(_localctx, 4);
				{
				setState(55);
				se();
				}
				break;
			case T__8:
				enterOuterAlt(_localctx, 5);
				{
				setState(56);
				enquanto();
				}
				break;
			case T__9:
				enterOuterAlt(_localctx, 6);
				{
				setState(57);
				faca();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Exp_terContext extends ParserRuleContext {
		public List<Exp_fatContext> exp_fat() {
			return getRuleContexts(Exp_fatContext.class);
		}
		public Exp_fatContext exp_fat(int i) {
			return getRuleContext(Exp_fatContext.class,i);
		}
		public List<TerminalNode> OPER_TER() { return getTokens(IsicompParser.OPER_TER); }
		public TerminalNode OPER_TER(int i) {
			return getToken(IsicompParser.OPER_TER, i);
		}
		public Exp_terContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exp_ter; }
	}

	public final Exp_terContext exp_ter() throws RecognitionException {
		Exp_terContext _localctx = new Exp_terContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_exp_ter);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(60);
			exp_fat();
			setState(65);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==OPER_TER) {
				{
				{
				setState(61);
				match(OPER_TER);
				setState(62);
				exp_fat();
				}
				}
				setState(67);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Exp_fatContext extends ParserRuleContext {
		public TerminalNode NUM() { return getToken(IsicompParser.NUM, 0); }
		public List<TerminalNode> OPER_FAT() { return getTokens(IsicompParser.OPER_FAT); }
		public TerminalNode OPER_FAT(int i) {
			return getToken(IsicompParser.OPER_FAT, i);
		}
		public List<TermoContext> termo() {
			return getRuleContexts(TermoContext.class);
		}
		public TermoContext termo(int i) {
			return getRuleContext(TermoContext.class,i);
		}
		public Exp_fatContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exp_fat; }
	}

	public final Exp_fatContext exp_fat() throws RecognitionException {
		Exp_fatContext _localctx = new Exp_fatContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_exp_fat);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(68);
			match(NUM);
			setState(73);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==OPER_FAT) {
				{
				{
				setState(69);
				match(OPER_FAT);
				setState(70);
				termo();
				}
				}
				setState(75);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Exp_relacionalContext extends ParserRuleContext {
		public TerminalNode OPE_RELAC() { return getToken(IsicompParser.OPE_RELAC, 0); }
		public List<TerminalNode> ID() { return getTokens(IsicompParser.ID); }
		public TerminalNode ID(int i) {
			return getToken(IsicompParser.ID, i);
		}
		public List<TerminalNode> NUM() { return getTokens(IsicompParser.NUM); }
		public TerminalNode NUM(int i) {
			return getToken(IsicompParser.NUM, i);
		}
		public Exp_relacionalContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exp_relacional; }
	}

	public final Exp_relacionalContext exp_relacional() throws RecognitionException {
		Exp_relacionalContext _localctx = new Exp_relacionalContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_exp_relacional);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(76);
			_la = _input.LA(1);
			if ( !(_la==ID || _la==NUM) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			setState(77);
			match(OPE_RELAC);
			setState(78);
			_la = _input.LA(1);
			if ( !(_la==ID || _la==NUM) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class TermoContext extends ParserRuleContext {
		public TerminalNode NUM() { return getToken(IsicompParser.NUM, 0); }
		public TerminalNode ID() { return getToken(IsicompParser.ID, 0); }
		public TerminalNode T_APARENT() { return getToken(IsicompParser.T_APARENT, 0); }
		public Exp_terContext exp_ter() {
			return getRuleContext(Exp_terContext.class,0);
		}
		public TerminalNode T_FPARENT() { return getToken(IsicompParser.T_FPARENT, 0); }
		public TermoContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_termo; }
	}

	public final TermoContext termo() throws RecognitionException {
		TermoContext _localctx = new TermoContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_termo);
		try {
			setState(86);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case NUM:
				enterOuterAlt(_localctx, 1);
				{
				setState(80);
				match(NUM);
				}
				break;
			case ID:
				enterOuterAlt(_localctx, 2);
				{
				setState(81);
				match(ID);
				}
				break;
			case T_APARENT:
				enterOuterAlt(_localctx, 3);
				{
				setState(82);
				match(T_APARENT);
				setState(83);
				exp_ter();
				setState(84);
				match(T_FPARENT);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class SeContext extends ParserRuleContext {
		public TerminalNode T_APARENT() { return getToken(IsicompParser.T_APARENT, 0); }
		public Exp_relacionalContext exp_relacional() {
			return getRuleContext(Exp_relacionalContext.class,0);
		}
		public TerminalNode T_FPARENT() { return getToken(IsicompParser.T_FPARENT, 0); }
		public List<BlococomandoContext> blococomando() {
			return getRuleContexts(BlococomandoContext.class);
		}
		public BlococomandoContext blococomando(int i) {
			return getRuleContext(BlococomandoContext.class,i);
		}
		public SeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_se; }
	}

	public final SeContext se() throws RecognitionException {
		SeContext _localctx = new SeContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_se);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(88);
			match(T__3);
			setState(89);
			match(T_APARENT);
			setState(90);
			exp_relacional();
			setState(91);
			match(T_FPARENT);
			setState(92);
			match(T__4);
			setState(93);
			blococomando();
			setState(97);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				{
				setState(94);
				match(T__5);
				setState(95);
				match(T__4);
				setState(96);
				blococomando();
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class AtribuaContext extends ParserRuleContext {
		public TerminalNode ID() { return getToken(IsicompParser.ID, 0); }
		public TerminalNode T_IGUAL() { return getToken(IsicompParser.T_IGUAL, 0); }
		public Exp_terContext exp_ter() {
			return getRuleContext(Exp_terContext.class,0);
		}
		public TerminalNode T_DOT() { return getToken(IsicompParser.T_DOT, 0); }
		public AtribuaContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_atribua; }
	}

	public final AtribuaContext atribua() throws RecognitionException {
		AtribuaContext _localctx = new AtribuaContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_atribua);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(99);
			match(ID);
			setState(100);
			match(T_IGUAL);
			setState(101);
			exp_ter();
			setState(102);
			match(T_DOT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EscrevaContext extends ParserRuleContext {
		public TerminalNode T_APARENT() { return getToken(IsicompParser.T_APARENT, 0); }
		public TerminalNode T_FPARENT() { return getToken(IsicompParser.T_FPARENT, 0); }
		public TerminalNode T_DOT() { return getToken(IsicompParser.T_DOT, 0); }
		public TerminalNode ID() { return getToken(IsicompParser.ID, 0); }
		public StringContext string() {
			return getRuleContext(StringContext.class,0);
		}
		public EscrevaContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_escreva; }
	}

	public final EscrevaContext escreva() throws RecognitionException {
		EscrevaContext _localctx = new EscrevaContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_escreva);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(104);
			match(T__6);
			setState(105);
			match(T_APARENT);
			setState(108);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case ID:
				{
				setState(106);
				match(ID);
				}
				break;
			case T_ASPAS:
				{
				setState(107);
				string();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(110);
			match(T_FPARENT);
			setState(111);
			match(T_DOT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class LeiaContext extends ParserRuleContext {
		public TerminalNode T_APARENT() { return getToken(IsicompParser.T_APARENT, 0); }
		public TerminalNode ID() { return getToken(IsicompParser.ID, 0); }
		public TerminalNode T_FPARENT() { return getToken(IsicompParser.T_FPARENT, 0); }
		public TerminalNode T_DOT() { return getToken(IsicompParser.T_DOT, 0); }
		public LeiaContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_leia; }
	}

	public final LeiaContext leia() throws RecognitionException {
		LeiaContext _localctx = new LeiaContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_leia);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(113);
			match(T__7);
			setState(114);
			match(T_APARENT);
			setState(115);
			match(ID);
			setState(116);
			match(T_FPARENT);
			setState(117);
			match(T_DOT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EnquantoContext extends ParserRuleContext {
		public TerminalNode T_APARENT() { return getToken(IsicompParser.T_APARENT, 0); }
		public Exp_relacionalContext exp_relacional() {
			return getRuleContext(Exp_relacionalContext.class,0);
		}
		public TerminalNode T_FPARENT() { return getToken(IsicompParser.T_FPARENT, 0); }
		public TerminalNode T_ACHAVE() { return getToken(IsicompParser.T_ACHAVE, 0); }
		public BlococomandoContext blococomando() {
			return getRuleContext(BlococomandoContext.class,0);
		}
		public TerminalNode T_FCHAVE() { return getToken(IsicompParser.T_FCHAVE, 0); }
		public EnquantoContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enquanto; }
	}

	public final EnquantoContext enquanto() throws RecognitionException {
		EnquantoContext _localctx = new EnquantoContext(_ctx, getState());
		enterRule(_localctx, 24, RULE_enquanto);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(119);
			match(T__8);
			setState(120);
			match(T_APARENT);
			setState(121);
			exp_relacional();
			setState(122);
			match(T_FPARENT);
			setState(123);
			match(T_ACHAVE);
			setState(124);
			blococomando();
			setState(125);
			match(T_FCHAVE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class FacaContext extends ParserRuleContext {
		public TerminalNode T_ACHAVE() { return getToken(IsicompParser.T_ACHAVE, 0); }
		public BlococomandoContext blococomando() {
			return getRuleContext(BlococomandoContext.class,0);
		}
		public TerminalNode T_FCHAVE() { return getToken(IsicompParser.T_FCHAVE, 0); }
		public TerminalNode T_APARENT() { return getToken(IsicompParser.T_APARENT, 0); }
		public Exp_relacionalContext exp_relacional() {
			return getRuleContext(Exp_relacionalContext.class,0);
		}
		public TerminalNode T_FPARENT() { return getToken(IsicompParser.T_FPARENT, 0); }
		public TerminalNode T_DOT() { return getToken(IsicompParser.T_DOT, 0); }
		public FacaContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_faca; }
	}

	public final FacaContext faca() throws RecognitionException {
		FacaContext _localctx = new FacaContext(_ctx, getState());
		enterRule(_localctx, 26, RULE_faca);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(127);
			match(T__9);
			setState(128);
			match(T_ACHAVE);
			setState(129);
			blococomando();
			setState(130);
			match(T_FCHAVE);
			setState(131);
			match(T__8);
			setState(132);
			match(T_APARENT);
			setState(133);
			exp_relacional();
			setState(134);
			match(T_FPARENT);
			setState(135);
			match(T_DOT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StringContext extends ParserRuleContext {
		public List<TerminalNode> T_ASPAS() { return getTokens(IsicompParser.T_ASPAS); }
		public TerminalNode T_ASPAS(int i) {
			return getToken(IsicompParser.T_ASPAS, i);
		}
		public List<TerminalNode> LETTER() { return getTokens(IsicompParser.LETTER); }
		public TerminalNode LETTER(int i) {
			return getToken(IsicompParser.LETTER, i);
		}
		public List<TerminalNode> NUM() { return getTokens(IsicompParser.NUM); }
		public TerminalNode NUM(int i) {
			return getToken(IsicompParser.NUM, i);
		}
		public List<TerminalNode> WS() { return getTokens(IsicompParser.WS); }
		public TerminalNode WS(int i) {
			return getToken(IsicompParser.WS, i);
		}
		public StringContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_string; }
	}

	public final StringContext string() throws RecognitionException {
		StringContext _localctx = new StringContext(_ctx, getState());
		enterRule(_localctx, 28, RULE_string);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(137);
			match(T_ASPAS);
			setState(139); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(138);
				_la = _input.LA(1);
				if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NUM) | (1L << LETTER) | (1L << WS))) != 0)) ) {
				_errHandler.recoverInline(this);
				}
				else {
					if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
					_errHandler.reportMatch(this);
					consume();
				}
				}
				}
				setState(141); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( (((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << NUM) | (1L << LETTER) | (1L << WS))) != 0) );
			setState(143);
			match(T_ASPAS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\60\u0094\4\2\t\2"+
		"\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13"+
		"\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\3\2\3\2\3\2\3\2\3"+
		"\2\3\2\3\3\3\3\3\3\3\3\7\3+\n\3\f\3\16\3.\13\3\3\3\3\3\3\4\6\4\63\n\4"+
		"\r\4\16\4\64\3\5\3\5\3\5\3\5\3\5\3\5\5\5=\n\5\3\6\3\6\3\6\7\6B\n\6\f\6"+
		"\16\6E\13\6\3\7\3\7\3\7\7\7J\n\7\f\7\16\7M\13\7\3\b\3\b\3\b\3\b\3\t\3"+
		"\t\3\t\3\t\3\t\3\t\5\tY\n\t\3\n\3\n\3\n\3\n\3\n\3\n\3\n\3\n\3\n\5\nd\n"+
		"\n\3\13\3\13\3\13\3\13\3\13\3\f\3\f\3\f\3\f\5\fo\n\f\3\f\3\f\3\f\3\r\3"+
		"\r\3\r\3\r\3\r\3\r\3\16\3\16\3\16\3\16\3\16\3\16\3\16\3\16\3\17\3\17\3"+
		"\17\3\17\3\17\3\17\3\17\3\17\3\17\3\17\3\20\3\20\6\20\u008e\n\20\r\20"+
		"\16\20\u008f\3\20\3\20\3\20\2\2\21\2\4\6\b\n\f\16\20\22\24\26\30\32\34"+
		"\36\2\4\4\2\16\16\22\22\5\2\22\22\25\25\60\60\2\u0092\2 \3\2\2\2\4&\3"+
		"\2\2\2\6\62\3\2\2\2\b<\3\2\2\2\n>\3\2\2\2\fF\3\2\2\2\16N\3\2\2\2\20X\3"+
		"\2\2\2\22Z\3\2\2\2\24e\3\2\2\2\26j\3\2\2\2\30s\3\2\2\2\32y\3\2\2\2\34"+
		"\u0081\3\2\2\2\36\u008b\3\2\2\2 !\7\3\2\2!\"\5\4\3\2\"#\5\6\4\2#$\7\4"+
		"\2\2$%\7(\2\2%\3\3\2\2\2&\'\7\5\2\2\',\7\16\2\2()\7$\2\2)+\7\16\2\2*("+
		"\3\2\2\2+.\3\2\2\2,*\3\2\2\2,-\3\2\2\2-/\3\2\2\2.,\3\2\2\2/\60\7(\2\2"+
		"\60\5\3\2\2\2\61\63\5\b\5\2\62\61\3\2\2\2\63\64\3\2\2\2\64\62\3\2\2\2"+
		"\64\65\3\2\2\2\65\7\3\2\2\2\66=\5\30\r\2\67=\5\26\f\28=\5\24\13\29=\5"+
		"\22\n\2:=\5\32\16\2;=\5\34\17\2<\66\3\2\2\2<\67\3\2\2\2<8\3\2\2\2<9\3"+
		"\2\2\2<:\3\2\2\2<;\3\2\2\2=\t\3\2\2\2>C\5\f\7\2?@\7\17\2\2@B\5\f\7\2A"+
		"?\3\2\2\2BE\3\2\2\2CA\3\2\2\2CD\3\2\2\2D\13\3\2\2\2EC\3\2\2\2FK\7\22\2"+
		"\2GH\7\20\2\2HJ\5\20\t\2IG\3\2\2\2JM\3\2\2\2KI\3\2\2\2KL\3\2\2\2L\r\3"+
		"\2\2\2MK\3\2\2\2NO\t\2\2\2OP\7\23\2\2PQ\t\2\2\2Q\17\3\2\2\2RY\7\22\2\2"+
		"SY\7\16\2\2TU\7%\2\2UV\5\n\6\2VW\7&\2\2WY\3\2\2\2XR\3\2\2\2XS\3\2\2\2"+
		"XT\3\2\2\2Y\21\3\2\2\2Z[\7\6\2\2[\\\7%\2\2\\]\5\16\b\2]^\7&\2\2^_\7\7"+
		"\2\2_c\5\6\4\2`a\7\b\2\2ab\7\7\2\2bd\5\6\4\2c`\3\2\2\2cd\3\2\2\2d\23\3"+
		"\2\2\2ef\7\16\2\2fg\7#\2\2gh\5\n\6\2hi\7(\2\2i\25\3\2\2\2jk\7\t\2\2kn"+
		"\7%\2\2lo\7\16\2\2mo\5\36\20\2nl\3\2\2\2nm\3\2\2\2op\3\2\2\2pq\7&\2\2"+
		"qr\7(\2\2r\27\3\2\2\2st\7\n\2\2tu\7%\2\2uv\7\16\2\2vw\7&\2\2wx\7(\2\2"+
		"x\31\3\2\2\2yz\7\13\2\2z{\7%\2\2{|\5\16\b\2|}\7&\2\2}~\7*\2\2~\177\5\6"+
		"\4\2\177\u0080\7+\2\2\u0080\33\3\2\2\2\u0081\u0082\7\f\2\2\u0082\u0083"+
		"\7*\2\2\u0083\u0084\5\6\4\2\u0084\u0085\7+\2\2\u0085\u0086\7\13\2\2\u0086"+
		"\u0087\7%\2\2\u0087\u0088\5\16\b\2\u0088\u0089\7&\2\2\u0089\u008a\7(\2"+
		"\2\u008a\35\3\2\2\2\u008b\u008d\7\'\2\2\u008c\u008e\t\3\2\2\u008d\u008c"+
		"\3\2\2\2\u008e\u008f\3\2\2\2\u008f\u008d\3\2\2\2\u008f\u0090\3\2\2\2\u0090"+
		"\u0091\3\2\2\2\u0091\u0092\7\'\2\2\u0092\37\3\2\2\2\13,\64<CKXcn\u008f";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}