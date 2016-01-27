// Generated from SEDefenseLang.g4 by ANTLR 4.4
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class SEDefenseLangLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.4", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__10=1, T__9=2, T__8=3, T__7=4, T__6=5, T__5=6, T__4=7, T__3=8, T__2=9, 
		T__1=10, T__0=11, Int=12, Float=13, LineBreak=14, String=15;
	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	public static final String[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'", "'\t'", "'\n'", "'\\u000B'", "'\f'", 
		"'\r'", "'\\u000E'", "'\\u000F'"
	};
	public static final String[] ruleNames = {
		"T__10", "T__9", "T__8", "T__7", "T__6", "T__5", "T__4", "T__3", "T__2", 
		"T__1", "T__0", "Int", "Float", "LineBreak", "String"
	};


	public SEDefenseLangLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "SEDefenseLang.g4"; }

	@Override
	public String[] getTokenNames() { return tokenNames; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u0430\ud6d1\u8206\uad2d\u4417\uaef1\u8d80\uaadd\2\21\u0086\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\3\2\3\2\3\2\3\2"+
		"\3\2\3\2\3\2\3\2\3\2\3\2\3\3\3\3\3\3\3\4\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3"+
		"\5\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\7"+
		"\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\b\3\t\3\t\3\t\3\t\3\t\3\t\3\t\3"+
		"\t\3\t\3\t\3\n\3\n\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\f\3\r\6\rh\n\r\r\r"+
		"\16\ri\3\16\7\16m\n\16\f\16\16\16p\13\16\3\16\3\16\6\16t\n\16\r\16\16"+
		"\16u\3\17\5\17y\n\17\3\17\3\17\5\17}\n\17\3\20\3\20\6\20\u0081\n\20\r"+
		"\20\16\20\u0082\3\20\3\20\2\2\21\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23"+
		"\13\25\f\27\r\31\16\33\17\35\20\37\21\3\2\3\6\2\62;C\\aac|\u008b\2\3\3"+
		"\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2\2\2\2"+
		"\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3"+
		"\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\3!\3\2\2\2\5+\3\2\2\2\7"+
		".\3\2\2\2\t\61\3\2\2\2\13;\3\2\2\2\rB\3\2\2\2\17J\3\2\2\2\21R\3\2\2\2"+
		"\23\\\3\2\2\2\25^\3\2\2\2\27`\3\2\2\2\31g\3\2\2\2\33n\3\2\2\2\35|\3\2"+
		"\2\2\37~\3\2\2\2!\"\7R\2\2\"#\7c\2\2#$\7v\2\2$%\7v\2\2%&\7g\2\2&\'\7t"+
		"\2\2\'(\7p\2\2()\7<\2\2)*\7\"\2\2*\4\3\2\2\2+,\7.\2\2,-\7\"\2\2-\6\3\2"+
		"\2\2./\7+\2\2/\60\7\"\2\2\60\b\3\2\2\2\61\62\7G\2\2\62\63\7p\2\2\63\64"+
		"\7g\2\2\64\65\7o\2\2\65\66\7k\2\2\66\67\7g\2\2\678\7u\2\289\7<\2\29:\7"+
		"\"\2\2:\n\3\2\2\2;<\7N\2\2<=\7g\2\2=>\7x\2\2>?\7g\2\2?@\7n\2\2@A\7\"\2"+
		"\2A\f\3\2\2\2BC\7F\2\2CD\7g\2\2DE\7n\2\2EF\7c\2\2FG\7{\2\2GH\7<\2\2HI"+
		"\7\"\2\2I\16\3\2\2\2JK\7\"\2\2KL\7U\2\2LM\7r\2\2MN\7c\2\2NO\7y\2\2OP\7"+
		"p\2\2PQ\7*\2\2Q\20\3\2\2\2RS\7\"\2\2ST\7C\2\2TU\7o\2\2UV\7q\2\2VW\7w\2"+
		"\2WX\7p\2\2XY\7v\2\2YZ\7<\2\2Z[\7\"\2\2[\22\3\2\2\2\\]\7<\2\2]\24\3\2"+
		"\2\2^_\7.\2\2_\26\3\2\2\2`a\7Y\2\2ab\7c\2\2bc\7x\2\2cd\7g\2\2de\7\"\2"+
		"\2e\30\3\2\2\2fh\4\62;\2gf\3\2\2\2hi\3\2\2\2ig\3\2\2\2ij\3\2\2\2j\32\3"+
		"\2\2\2km\4\62;\2lk\3\2\2\2mp\3\2\2\2nl\3\2\2\2no\3\2\2\2oq\3\2\2\2pn\3"+
		"\2\2\2qs\7\60\2\2rt\4\62;\2sr\3\2\2\2tu\3\2\2\2us\3\2\2\2uv\3\2\2\2v\34"+
		"\3\2\2\2wy\7\17\2\2xw\3\2\2\2xy\3\2\2\2yz\3\2\2\2z}\7\f\2\2{}\7\17\2\2"+
		"|x\3\2\2\2|{\3\2\2\2}\36\3\2\2\2~\u0080\7$\2\2\177\u0081\t\2\2\2\u0080"+
		"\177\3\2\2\2\u0081\u0082\3\2\2\2\u0082\u0080\3\2\2\2\u0082\u0083\3\2\2"+
		"\2\u0083\u0084\3\2\2\2\u0084\u0085\7$\2\2\u0085 \3\2\2\2\n\2inux|\u0080"+
		"\u0082\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}