// Generated from c:\Users\ramon\Desktop\Projeto Compiladores\AnalisadorLexico\Compilador-Isidrol\ProjetoCompiladores\Isicomp.g4 by ANTLR 4.7.1
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class IsicompLexer extends Lexer {
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
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	public static final String[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "FORMAT", "ID", "OPER_TER", "OPER_FAT", "PONTUACAO", "NUM", "OPE_RELAC", 
		"DIGIT", "LETTER", "T_NULL", "T_STRING", "T_CHAR", "T_BYTE", "T_INT", 
		"T_FLOAT", "T_DOUBLE", "T_SOMA", "T_SUBT", "T_DIV", "T_MULT", "T_MAIOR", 
		"T_MENOR", "T_IGUAL", "T_COMMA", "T_APARENT", "T_FPARENT", "T_ASPAS", 
		"T_DOT", "T_UNDERS", "T_ACHAVE", "T_FCHAVE", "T_MAIOR_IGUAL", "T_MENOR_IGUAL", 
		"T_IGUAL_RELAC", "T_DIF", "WS"
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


	public IsicompLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Isicomp.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\60\u013e\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31"+
		"\t\31\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t"+
		" \4!\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\4*\t*\4+\t"+
		"+\4,\t,\4-\t-\4.\t.\4/\t/\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\2\3\3\3\3"+
		"\3\3\3\3\3\3\3\3\3\3\3\3\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\4\3\5\3\5\3\5\3"+
		"\6\3\6\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\b"+
		"\3\b\3\b\3\t\3\t\3\t\3\t\3\t\3\n\3\n\3\n\3\n\3\n\3\n\3\n\3\n\3\n\3\13"+
		"\3\13\3\13\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\f\5\f\u00a9\n\f\3\r\6\r\u00ac"+
		"\n\r\r\r\16\r\u00ad\3\r\3\r\7\r\u00b2\n\r\f\r\16\r\u00b5\13\r\3\16\3\16"+
		"\5\16\u00b9\n\16\3\17\3\17\5\17\u00bd\n\17\3\20\3\20\3\20\3\20\3\20\5"+
		"\20\u00c4\n\20\3\21\6\21\u00c7\n\21\r\21\16\21\u00c8\3\21\3\21\6\21\u00cd"+
		"\n\21\r\21\16\21\u00ce\5\21\u00d1\n\21\3\22\3\22\3\22\3\22\3\22\3\22\3"+
		"\22\5\22\u00da\n\22\3\23\6\23\u00dd\n\23\r\23\16\23\u00de\3\24\6\24\u00e2"+
		"\n\24\r\24\16\24\u00e3\3\25\3\25\3\25\3\25\3\25\3\26\3\26\3\26\3\26\3"+
		"\26\3\26\3\26\3\27\3\27\3\27\3\27\3\27\3\30\3\30\3\30\3\30\3\30\3\31\3"+
		"\31\3\31\3\31\3\32\3\32\3\32\3\32\3\32\3\32\3\33\3\33\3\33\3\33\3\33\3"+
		"\33\3\33\3\34\3\34\3\35\3\35\3\36\3\36\3\37\3\37\3 \3 \3!\3!\3\"\3\"\3"+
		"\"\3#\3#\3$\3$\3%\3%\3&\3&\3\'\3\'\3(\3(\3)\3)\3*\3*\3+\3+\3+\3,\3,\3"+
		",\3-\3-\3-\3.\3.\3.\3/\6/\u0139\n/\r/\16/\u013a\3/\3/\2\2\60\3\3\5\4\7"+
		"\5\t\6\13\7\r\b\17\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22"+
		"#\23%\24\'\25)\26+\27-\30/\31\61\32\63\33\65\34\67\359\36;\37= ?!A\"C"+
		"#E$G%I&K\'M(O)Q*S+U,W-Y.[/]\60\3\2\5\3\2\62;\5\2\"\"C\\c|\5\2\13\f\17"+
		"\17\"\"\2\u0157\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3"+
		"\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2"+
		"\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3"+
		"\2\2\2\2#\3\2\2\2\2%\3\2\2\2\2\'\3\2\2\2\2)\3\2\2\2\2+\3\2\2\2\2-\3\2"+
		"\2\2\2/\3\2\2\2\2\61\3\2\2\2\2\63\3\2\2\2\2\65\3\2\2\2\2\67\3\2\2\2\2"+
		"9\3\2\2\2\2;\3\2\2\2\2=\3\2\2\2\2?\3\2\2\2\2A\3\2\2\2\2C\3\2\2\2\2E\3"+
		"\2\2\2\2G\3\2\2\2\2I\3\2\2\2\2K\3\2\2\2\2M\3\2\2\2\2O\3\2\2\2\2Q\3\2\2"+
		"\2\2S\3\2\2\2\2U\3\2\2\2\2W\3\2\2\2\2Y\3\2\2\2\2[\3\2\2\2\2]\3\2\2\2\3"+
		"_\3\2\2\2\5h\3\2\2\2\7p\3\2\2\2\tx\3\2\2\2\13{\3\2\2\2\r\u0081\3\2\2\2"+
		"\17\u0087\3\2\2\2\21\u008f\3\2\2\2\23\u0094\3\2\2\2\25\u009d\3\2\2\2\27"+
		"\u00a8\3\2\2\2\31\u00ab\3\2\2\2\33\u00b8\3\2\2\2\35\u00bc\3\2\2\2\37\u00c3"+
		"\3\2\2\2!\u00c6\3\2\2\2#\u00d9\3\2\2\2%\u00dc\3\2\2\2\'\u00e1\3\2\2\2"+
		")\u00e5\3\2\2\2+\u00ea\3\2\2\2-\u00f1\3\2\2\2/\u00f6\3\2\2\2\61\u00fb"+
		"\3\2\2\2\63\u00ff\3\2\2\2\65\u0105\3\2\2\2\67\u010c\3\2\2\29\u010e\3\2"+
		"\2\2;\u0110\3\2\2\2=\u0112\3\2\2\2?\u0114\3\2\2\2A\u0116\3\2\2\2C\u0118"+
		"\3\2\2\2E\u011b\3\2\2\2G\u011d\3\2\2\2I\u011f\3\2\2\2K\u0121\3\2\2\2M"+
		"\u0123\3\2\2\2O\u0125\3\2\2\2Q\u0127\3\2\2\2S\u0129\3\2\2\2U\u012b\3\2"+
		"\2\2W\u012e\3\2\2\2Y\u0131\3\2\2\2[\u0134\3\2\2\2]\u0138\3\2\2\2_`\7r"+
		"\2\2`a\7t\2\2ab\7q\2\2bc\7i\2\2cd\7t\2\2de\7c\2\2ef\7o\2\2fg\7c\2\2g\4"+
		"\3\2\2\2hi\7h\2\2ij\7k\2\2jk\7o\2\2kl\7r\2\2lm\7t\2\2mn\7q\2\2no\7i\2"+
		"\2o\6\3\2\2\2pq\7f\2\2qr\7g\2\2rs\7e\2\2st\7n\2\2tu\7c\2\2uv\7t\2\2vw"+
		"\7g\2\2w\b\3\2\2\2xy\7u\2\2yz\7g\2\2z\n\3\2\2\2{|\7g\2\2|}\7p\2\2}~\7"+
		"v\2\2~\177\7c\2\2\177\u0080\7q\2\2\u0080\f\3\2\2\2\u0081\u0082\7u\2\2"+
		"\u0082\u0083\7g\2\2\u0083\u0084\7p\2\2\u0084\u0085\7c\2\2\u0085\u0086"+
		"\7q\2\2\u0086\16\3\2\2\2\u0087\u0088\7g\2\2\u0088\u0089\7u\2\2\u0089\u008a"+
		"\7e\2\2\u008a\u008b\7t\2\2\u008b\u008c\7g\2\2\u008c\u008d\7x\2\2\u008d"+
		"\u008e\7c\2\2\u008e\20\3\2\2\2\u008f\u0090\7n\2\2\u0090\u0091\7g\2\2\u0091"+
		"\u0092\7k\2\2\u0092\u0093\7c\2\2\u0093\22\3\2\2\2\u0094\u0095\7g\2\2\u0095"+
		"\u0096\7p\2\2\u0096\u0097\7s\2\2\u0097\u0098\7w\2\2\u0098\u0099\7c\2\2"+
		"\u0099\u009a\7p\2\2\u009a\u009b\7v\2\2\u009b\u009c\7q\2\2\u009c\24\3\2"+
		"\2\2\u009d\u009e\7h\2\2\u009e\u009f\7c\2\2\u009f\u00a0\7e\2\2\u00a0\u00a1"+
		"\7c\2\2\u00a1\26\3\2\2\2\u00a2\u00a9\5+\26\2\u00a3\u00a9\5-\27\2\u00a4"+
		"\u00a9\5/\30\2\u00a5\u00a9\5\61\31\2\u00a6\u00a9\5\63\32\2\u00a7\u00a9"+
		"\5\65\33\2\u00a8\u00a2\3\2\2\2\u00a8\u00a3\3\2\2\2\u00a8\u00a4\3\2\2\2"+
		"\u00a8\u00a5\3\2\2\2\u00a8\u00a6\3\2\2\2\u00a8\u00a7\3\2\2\2\u00a9\30"+
		"\3\2\2\2\u00aa\u00ac\5\'\24\2\u00ab\u00aa\3\2\2\2\u00ac\u00ad\3\2\2\2"+
		"\u00ad\u00ab\3\2\2\2\u00ad\u00ae\3\2\2\2\u00ae\u00b3\3\2\2\2\u00af\u00b2"+
		"\5%\23\2\u00b0\u00b2\5\'\24\2\u00b1\u00af\3\2\2\2\u00b1\u00b0\3\2\2\2"+
		"\u00b2\u00b5\3\2\2\2\u00b3\u00b1\3\2\2\2\u00b3\u00b4\3\2\2\2\u00b4\32"+
		"\3\2\2\2\u00b5\u00b3\3\2\2\2\u00b6\u00b9\5\67\34\2\u00b7\u00b9\59\35\2"+
		"\u00b8\u00b6\3\2\2\2\u00b8\u00b7\3\2\2\2\u00b9\34\3\2\2\2\u00ba\u00bd"+
		"\5;\36\2\u00bb\u00bd\5=\37\2\u00bc\u00ba\3\2\2\2\u00bc\u00bb\3\2\2\2\u00bd"+
		"\36\3\2\2\2\u00be\u00c4\5E#\2\u00bf\u00c4\5G$\2\u00c0\u00c4\5I%\2\u00c1"+
		"\u00c4\5M\'\2\u00c2\u00c4\5O(\2\u00c3\u00be\3\2\2\2\u00c3\u00bf\3\2\2"+
		"\2\u00c3\u00c0\3\2\2\2\u00c3\u00c1\3\2\2\2\u00c3\u00c2\3\2\2\2\u00c4 "+
		"\3\2\2\2\u00c5\u00c7\5%\23\2\u00c6\u00c5\3\2\2\2\u00c7\u00c8\3\2\2\2\u00c8"+
		"\u00c6\3\2\2\2\u00c8\u00c9\3\2\2\2\u00c9\u00d0\3\2\2\2\u00ca\u00cc\5E"+
		"#\2\u00cb\u00cd\5%\23\2\u00cc\u00cb\3\2\2\2\u00cd\u00ce\3\2\2\2\u00ce"+
		"\u00cc\3\2\2\2\u00ce\u00cf\3\2\2\2\u00cf\u00d1\3\2\2\2\u00d0\u00ca\3\2"+
		"\2\2\u00d0\u00d1\3\2\2\2\u00d1\"\3\2\2\2\u00d2\u00da\5? \2\u00d3\u00da"+
		"\5A!\2\u00d4\u00da\5W,\2\u00d5\u00da\5U+\2\u00d6\u00da\5Y-\2\u00d7\u00da"+
		"\5[.\2\u00d8\u00da\5C\"\2\u00d9\u00d2\3\2\2\2\u00d9\u00d3\3\2\2\2\u00d9"+
		"\u00d4\3\2\2\2\u00d9\u00d5\3\2\2\2\u00d9\u00d6\3\2\2\2\u00d9\u00d7\3\2"+
		"\2\2\u00d9\u00d8\3\2\2\2\u00da$\3\2\2\2\u00db\u00dd\t\2\2\2\u00dc\u00db"+
		"\3\2\2\2\u00dd\u00de\3\2\2\2\u00de\u00dc\3\2\2\2\u00de\u00df\3\2\2\2\u00df"+
		"&\3\2\2\2\u00e0\u00e2\t\3\2\2\u00e1\u00e0\3\2\2\2\u00e2\u00e3\3\2\2\2"+
		"\u00e3\u00e1\3\2\2\2\u00e3\u00e4\3\2\2\2\u00e4(\3\2\2\2\u00e5\u00e6\7"+
		"p\2\2\u00e6\u00e7\7w\2\2\u00e7\u00e8\7n\2\2\u00e8\u00e9\7q\2\2\u00e9*"+
		"\3\2\2\2\u00ea\u00eb\7u\2\2\u00eb\u00ec\7v\2\2\u00ec\u00ed\7t\2\2\u00ed"+
		"\u00ee\7k\2\2\u00ee\u00ef\7p\2\2\u00ef\u00f0\7i\2\2\u00f0,\3\2\2\2\u00f1"+
		"\u00f2\7e\2\2\u00f2\u00f3\7j\2\2\u00f3\u00f4\7c\2\2\u00f4\u00f5\7t\2\2"+
		"\u00f5.\3\2\2\2\u00f6\u00f7\7d\2\2\u00f7\u00f8\7{\2\2\u00f8\u00f9\7v\2"+
		"\2\u00f9\u00fa\7g\2\2\u00fa\60\3\2\2\2\u00fb\u00fc\7k\2\2\u00fc\u00fd"+
		"\7p\2\2\u00fd\u00fe\7v\2\2\u00fe\62\3\2\2\2\u00ff\u0100\7h\2\2\u0100\u0101"+
		"\7n\2\2\u0101\u0102\7q\2\2\u0102\u0103\7c\2\2\u0103\u0104\7v\2\2\u0104"+
		"\64\3\2\2\2\u0105\u0106\7f\2\2\u0106\u0107\7q\2\2\u0107\u0108\7w\2\2\u0108"+
		"\u0109\7d\2\2\u0109\u010a\7n\2\2\u010a\u010b\7g\2\2\u010b\66\3\2\2\2\u010c"+
		"\u010d\7-\2\2\u010d8\3\2\2\2\u010e\u010f\7/\2\2\u010f:\3\2\2\2\u0110\u0111"+
		"\7\61\2\2\u0111<\3\2\2\2\u0112\u0113\7,\2\2\u0113>\3\2\2\2\u0114\u0115"+
		"\7@\2\2\u0115@\3\2\2\2\u0116\u0117\7>\2\2\u0117B\3\2\2\2\u0118\u0119\7"+
		"<\2\2\u0119\u011a\7?\2\2\u011aD\3\2\2\2\u011b\u011c\7.\2\2\u011cF\3\2"+
		"\2\2\u011d\u011e\7*\2\2\u011eH\3\2\2\2\u011f\u0120\7+\2\2\u0120J\3\2\2"+
		"\2\u0121\u0122\7$\2\2\u0122L\3\2\2\2\u0123\u0124\7\60\2\2\u0124N\3\2\2"+
		"\2\u0125\u0126\7a\2\2\u0126P\3\2\2\2\u0127\u0128\7}\2\2\u0128R\3\2\2\2"+
		"\u0129\u012a\7\177\2\2\u012aT\3\2\2\2\u012b\u012c\7@\2\2\u012c\u012d\7"+
		"?\2\2\u012dV\3\2\2\2\u012e\u012f\7>\2\2\u012f\u0130\7?\2\2\u0130X\3\2"+
		"\2\2\u0131\u0132\7?\2\2\u0132\u0133\7?\2\2\u0133Z\3\2\2\2\u0134\u0135"+
		"\7#\2\2\u0135\u0136\7?\2\2\u0136\\\3\2\2\2\u0137\u0139\t\4\2\2\u0138\u0137"+
		"\3\2\2\2\u0139\u013a\3\2\2\2\u013a\u0138\3\2\2\2\u013a\u013b\3\2\2\2\u013b"+
		"\u013c\3\2\2\2\u013c\u013d\b/\2\2\u013d^\3\2\2\2\22\2\u00a8\u00ad\u00b1"+
		"\u00b3\u00b8\u00bc\u00c3\u00c8\u00ce\u00d0\u00d9\u00de\u00e1\u00e3\u013a"+
		"\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}