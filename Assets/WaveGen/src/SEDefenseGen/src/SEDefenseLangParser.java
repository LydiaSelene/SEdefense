// Generated from SEDefenseLang.g4 by ANTLR 4.4
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class SEDefenseLangParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.4", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__10=1, T__9=2, T__8=3, T__7=4, T__6=5, T__5=6, T__4=7, T__3=8, T__2=9, 
		T__1=10, T__0=11, Int=12, Float=13, LineBreak=14, String=15;
	public static final String[] tokenNames = {
		"<INVALID>", "'Pattern: '", "', '", "') '", "'Enemies: '", "'Level '", 
		"'Delay: '", "' Spawn('", "' Amount: '", "':'", "','", "'Wave '", "Int", 
		"Float", "LineBreak", "String"
	};
	public static final int
		RULE_file = 0, RULE_level = 1, RULE_wave = 2, RULE_enemies = 3, RULE_pattern = 4, 
		RULE_levelnr = 5, RULE_wavenr = 6, RULE_enemy = 7, RULE_enemyspawn = 8, 
		RULE_spawnPattern = 9, RULE_delay = 10, RULE_amount = 11;
	public static final String[] ruleNames = {
		"file", "level", "wave", "enemies", "pattern", "levelnr", "wavenr", "enemy", 
		"enemyspawn", "spawnPattern", "delay", "amount"
	};

	@Override
	public String getGrammarFileName() { return "SEDefenseLang.g4"; }

	@Override
	public String[] getTokenNames() { return tokenNames; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public SEDefenseLangParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class FileContext extends ParserRuleContext {
		public List<TerminalNode> LineBreak() { return getTokens(SEDefenseLangParser.LineBreak); }
		public TerminalNode EOF() { return getToken(SEDefenseLangParser.EOF, 0); }
		public LevelContext level(int i) {
			return getRuleContext(LevelContext.class,i);
		}
		public List<LevelContext> level() {
			return getRuleContexts(LevelContext.class);
		}
		public TerminalNode LineBreak(int i) {
			return getToken(SEDefenseLangParser.LineBreak, i);
		}
		public FileContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_file; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterFile(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitFile(this);
		}
	}

	public final FileContext file() throws RecognitionException {
		FileContext _localctx = new FileContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_file);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(31); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(24); level();
				setState(28);
				_errHandler.sync(this);
				_la = _input.LA(1);
				while (_la==LineBreak) {
					{
					{
					setState(25); match(LineBreak);
					}
					}
					setState(30);
					_errHandler.sync(this);
					_la = _input.LA(1);
				}
				}
				}
				setState(33); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==T__6 );
			setState(35); match(EOF);
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

	public static class LevelContext extends ParserRuleContext {
		public List<TerminalNode> LineBreak() { return getTokens(SEDefenseLangParser.LineBreak); }
		public LevelnrContext levelnr() {
			return getRuleContext(LevelnrContext.class,0);
		}
		public WaveContext wave(int i) {
			return getRuleContext(WaveContext.class,i);
		}
		public List<WaveContext> wave() {
			return getRuleContexts(WaveContext.class);
		}
		public TerminalNode LineBreak(int i) {
			return getToken(SEDefenseLangParser.LineBreak, i);
		}
		public LevelContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_level; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterLevel(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitLevel(this);
		}
	}

	public final LevelContext level() throws RecognitionException {
		LevelContext _localctx = new LevelContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_level);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(37); match(T__6);
			setState(38); levelnr();
			setState(39); match(T__2);
			setState(40); match(LineBreak);
			setState(48); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(41); wave();
				setState(45);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
				while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
					if ( _alt==1 ) {
						{
						{
						setState(42); match(LineBreak);
						}
						} 
					}
					setState(47);
					_errHandler.sync(this);
					_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
				}
				}
				}
				setState(50); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==T__0 );
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

	public static class WaveContext extends ParserRuleContext {
		public PatternContext pattern() {
			return getRuleContext(PatternContext.class,0);
		}
		public EnemiesContext enemies() {
			return getRuleContext(EnemiesContext.class,0);
		}
		public List<TerminalNode> LineBreak() { return getTokens(SEDefenseLangParser.LineBreak); }
		public WavenrContext wavenr() {
			return getRuleContext(WavenrContext.class,0);
		}
		public TerminalNode LineBreak(int i) {
			return getToken(SEDefenseLangParser.LineBreak, i);
		}
		public WaveContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_wave; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterWave(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitWave(this);
		}
	}

	public final WaveContext wave() throws RecognitionException {
		WaveContext _localctx = new WaveContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_wave);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(52); match(T__0);
			setState(53); wavenr();
			setState(54); match(T__2);
			setState(55); match(LineBreak);
			setState(56); enemies();
			setState(60);
			_errHandler.sync(this);
			_la = _input.LA(1);
			while (_la==LineBreak) {
				{
				{
				setState(57); match(LineBreak);
				}
				}
				setState(62);
				_errHandler.sync(this);
				_la = _input.LA(1);
			}
			setState(63); pattern();
			setState(67);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,5,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					setState(64); match(LineBreak);
					}
					} 
				}
				setState(69);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,5,_ctx);
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

	public static class EnemiesContext extends ParserRuleContext {
		public EnemyContext enemy(int i) {
			return getRuleContext(EnemyContext.class,i);
		}
		public AmountContext amount() {
			return getRuleContext(AmountContext.class,0);
		}
		public List<EnemyContext> enemy() {
			return getRuleContexts(EnemyContext.class);
		}
		public EnemiesContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enemies; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterEnemies(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitEnemies(this);
		}
	}

	public final EnemiesContext enemies() throws RecognitionException {
		EnemiesContext _localctx = new EnemiesContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_enemies);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(70); match(T__7);
			setState(75); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(71); enemy();
				setState(73);
				_la = _input.LA(1);
				if (_la==T__9) {
					{
					setState(72); match(T__9);
					}
				}

				}
				}
				setState(77); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==String );
			setState(79); match(T__3);
			setState(80); amount();
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

	public static class PatternContext extends ParserRuleContext {
		public List<SpawnPatternContext> spawnPattern() {
			return getRuleContexts(SpawnPatternContext.class);
		}
		public EnemyspawnContext enemyspawn(int i) {
			return getRuleContext(EnemyspawnContext.class,i);
		}
		public DelayContext delay() {
			return getRuleContext(DelayContext.class,0);
		}
		public SpawnPatternContext spawnPattern(int i) {
			return getRuleContext(SpawnPatternContext.class,i);
		}
		public List<EnemyspawnContext> enemyspawn() {
			return getRuleContexts(EnemyspawnContext.class);
		}
		public PatternContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_pattern; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterPattern(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitPattern(this);
		}
	}

	public final PatternContext pattern() throws RecognitionException {
		PatternContext _localctx = new PatternContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_pattern);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(82); match(T__10);
			setState(88); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(83); enemyspawn();
				setState(84); match(T__4);
				setState(85); spawnPattern();
				setState(86); match(T__8);
				}
				}
				setState(90); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==String );
			setState(92); match(T__5);
			setState(93); delay();
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

	public static class LevelnrContext extends ParserRuleContext {
		public TerminalNode Int() { return getToken(SEDefenseLangParser.Int, 0); }
		public LevelnrContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_levelnr; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterLevelnr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitLevelnr(this);
		}
	}

	public final LevelnrContext levelnr() throws RecognitionException {
		LevelnrContext _localctx = new LevelnrContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_levelnr);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(95); match(Int);
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

	public static class WavenrContext extends ParserRuleContext {
		public TerminalNode Int() { return getToken(SEDefenseLangParser.Int, 0); }
		public WavenrContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_wavenr; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterWavenr(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitWavenr(this);
		}
	}

	public final WavenrContext wavenr() throws RecognitionException {
		WavenrContext _localctx = new WavenrContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_wavenr);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(97); match(Int);
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

	public static class EnemyContext extends ParserRuleContext {
		public TerminalNode String() { return getToken(SEDefenseLangParser.String, 0); }
		public EnemyContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enemy; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterEnemy(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitEnemy(this);
		}
	}

	public final EnemyContext enemy() throws RecognitionException {
		EnemyContext _localctx = new EnemyContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_enemy);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(99); match(String);
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

	public static class EnemyspawnContext extends ParserRuleContext {
		public TerminalNode String() { return getToken(SEDefenseLangParser.String, 0); }
		public EnemyspawnContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_enemyspawn; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterEnemyspawn(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitEnemyspawn(this);
		}
	}

	public final EnemyspawnContext enemyspawn() throws RecognitionException {
		EnemyspawnContext _localctx = new EnemyspawnContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_enemyspawn);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(101); match(String);
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

	public static class SpawnPatternContext extends ParserRuleContext {
		public TerminalNode Float(int i) {
			return getToken(SEDefenseLangParser.Float, i);
		}
		public List<TerminalNode> Float() { return getTokens(SEDefenseLangParser.Float); }
		public SpawnPatternContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_spawnPattern; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterSpawnPattern(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitSpawnPattern(this);
		}
	}

	public final SpawnPatternContext spawnPattern() throws RecognitionException {
		SpawnPatternContext _localctx = new SpawnPatternContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_spawnPattern);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(103); match(Float);
			setState(104); match(T__1);
			setState(105); match(Float);
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

	public static class DelayContext extends ParserRuleContext {
		public TerminalNode Float() { return getToken(SEDefenseLangParser.Float, 0); }
		public DelayContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_delay; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterDelay(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitDelay(this);
		}
	}

	public final DelayContext delay() throws RecognitionException {
		DelayContext _localctx = new DelayContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_delay);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(107); match(Float);
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

	public static class AmountContext extends ParserRuleContext {
		public TerminalNode Int() { return getToken(SEDefenseLangParser.Int, 0); }
		public AmountContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_amount; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).enterAmount(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof SEDefenseLangListener ) ((SEDefenseLangListener)listener).exitAmount(this);
		}
	}

	public final AmountContext amount() throws RecognitionException {
		AmountContext _localctx = new AmountContext(_ctx, getState());
		enterRule(_localctx, 22, RULE_amount);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(109); match(Int);
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
		"\3\u0430\ud6d1\u8206\uad2d\u4417\uaef1\u8d80\uaadd\3\21r\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t\13\4"+
		"\f\t\f\4\r\t\r\3\2\3\2\7\2\35\n\2\f\2\16\2 \13\2\6\2\"\n\2\r\2\16\2#\3"+
		"\2\3\2\3\3\3\3\3\3\3\3\3\3\3\3\7\3.\n\3\f\3\16\3\61\13\3\6\3\63\n\3\r"+
		"\3\16\3\64\3\4\3\4\3\4\3\4\3\4\3\4\7\4=\n\4\f\4\16\4@\13\4\3\4\3\4\7\4"+
		"D\n\4\f\4\16\4G\13\4\3\5\3\5\3\5\5\5L\n\5\6\5N\n\5\r\5\16\5O\3\5\3\5\3"+
		"\5\3\6\3\6\3\6\3\6\3\6\3\6\6\6[\n\6\r\6\16\6\\\3\6\3\6\3\6\3\7\3\7\3\b"+
		"\3\b\3\t\3\t\3\n\3\n\3\13\3\13\3\13\3\13\3\f\3\f\3\r\3\r\3\r\2\2\16\2"+
		"\4\6\b\n\f\16\20\22\24\26\30\2\2n\2!\3\2\2\2\4\'\3\2\2\2\6\66\3\2\2\2"+
		"\bH\3\2\2\2\nT\3\2\2\2\fa\3\2\2\2\16c\3\2\2\2\20e\3\2\2\2\22g\3\2\2\2"+
		"\24i\3\2\2\2\26m\3\2\2\2\30o\3\2\2\2\32\36\5\4\3\2\33\35\7\20\2\2\34\33"+
		"\3\2\2\2\35 \3\2\2\2\36\34\3\2\2\2\36\37\3\2\2\2\37\"\3\2\2\2 \36\3\2"+
		"\2\2!\32\3\2\2\2\"#\3\2\2\2#!\3\2\2\2#$\3\2\2\2$%\3\2\2\2%&\7\2\2\3&\3"+
		"\3\2\2\2\'(\7\7\2\2()\5\f\7\2)*\7\13\2\2*\62\7\20\2\2+/\5\6\4\2,.\7\20"+
		"\2\2-,\3\2\2\2.\61\3\2\2\2/-\3\2\2\2/\60\3\2\2\2\60\63\3\2\2\2\61/\3\2"+
		"\2\2\62+\3\2\2\2\63\64\3\2\2\2\64\62\3\2\2\2\64\65\3\2\2\2\65\5\3\2\2"+
		"\2\66\67\7\r\2\2\678\5\16\b\289\7\13\2\29:\7\20\2\2:>\5\b\5\2;=\7\20\2"+
		"\2<;\3\2\2\2=@\3\2\2\2><\3\2\2\2>?\3\2\2\2?A\3\2\2\2@>\3\2\2\2AE\5\n\6"+
		"\2BD\7\20\2\2CB\3\2\2\2DG\3\2\2\2EC\3\2\2\2EF\3\2\2\2F\7\3\2\2\2GE\3\2"+
		"\2\2HM\7\6\2\2IK\5\20\t\2JL\7\4\2\2KJ\3\2\2\2KL\3\2\2\2LN\3\2\2\2MI\3"+
		"\2\2\2NO\3\2\2\2OM\3\2\2\2OP\3\2\2\2PQ\3\2\2\2QR\7\n\2\2RS\5\30\r\2S\t"+
		"\3\2\2\2TZ\7\3\2\2UV\5\22\n\2VW\7\t\2\2WX\5\24\13\2XY\7\5\2\2Y[\3\2\2"+
		"\2ZU\3\2\2\2[\\\3\2\2\2\\Z\3\2\2\2\\]\3\2\2\2]^\3\2\2\2^_\7\b\2\2_`\5"+
		"\26\f\2`\13\3\2\2\2ab\7\16\2\2b\r\3\2\2\2cd\7\16\2\2d\17\3\2\2\2ef\7\21"+
		"\2\2f\21\3\2\2\2gh\7\21\2\2h\23\3\2\2\2ij\7\17\2\2jk\7\f\2\2kl\7\17\2"+
		"\2l\25\3\2\2\2mn\7\17\2\2n\27\3\2\2\2op\7\16\2\2p\31\3\2\2\2\13\36#/\64"+
		">EKO\\";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}