//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Hello.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class HelloLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, Stereotype=44, LOWERCASE=45, 
		UPPERCASE=46, DIGITS=47, WS=48;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "Stereotype", "LOWERCASE", "UPPERCASE", "DIGITS", "WS"
	};


	public HelloLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public HelloLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'package'", "'endpackage'", "'@'", "':'", "'context'", "'::'", 
		"'('", "')'", "'='", "'+'", "'-'", "'<'", "'<='", "'>='", "'>'", "'/'", 
		"'*'", "'<>'", "'implies'", "'not'", "'xor'", "'and'", "','", "'let'", 
		"';'", "'if'", "'then'", "'else'", "'endif'", "'.'", "'->'", "'{'", "'}'", 
		"'..'", "'['", "']'", "'|'", "'pre'", "'Set'", "'Bag'", "'Sequence'", 
		"'Collection'", "'_'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, "Stereotype", "LOWERCASE", 
		"UPPERCASE", "DIGITS", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Hello.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static HelloLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x32', '\x11C', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', 
		'\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', 
		'\x3', '!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', '#', 
		'\x3', '#', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', '&', 
		'\x3', '&', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\x3', 
		'(', '\x3', '(', '\x3', '(', '\x3', '(', '\x3', ')', '\x3', ')', '\x3', 
		')', '\x3', ')', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', 
		'*', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', '+', '\x3', 
		'+', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', 
		'+', '\x3', '+', '\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', '\x3', 
		'-', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', '-', '\x3', 
		'-', '\x3', '-', '\x3', '-', '\x3', '-', '\x5', '-', '\x10E', '\n', '-', 
		'\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', '\x3', '\x30', '\x3', 
		'\x30', '\x3', '\x31', '\x6', '\x31', '\x117', '\n', '\x31', '\r', '\x31', 
		'\xE', '\x31', '\x118', '\x3', '\x31', '\x3', '\x31', '\x2', '\x2', '\x32', 
		'\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', 
		'\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', 
		'\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', 
		'#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', 
		'\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', 
		'\x1D', '\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', 
		'\x43', '#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', 
		')', 'Q', '*', 'S', '+', 'U', ',', 'W', '-', 'Y', '.', '[', '/', ']', 
		'\x30', '_', '\x31', '\x61', '\x32', '\x3', '\x2', '\x3', '\x5', '\x2', 
		'\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x11E', '\x2', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '#', '\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x43', '\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'Q', '\x3', '\x2', '\x2', '\x2', '\x2', 'S', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'U', '\x3', '\x2', '\x2', '\x2', '\x2', 'W', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'Y', '\x3', '\x2', '\x2', '\x2', '\x2', '[', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ']', '\x3', '\x2', '\x2', '\x2', '\x2', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x61', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'\x63', '\x3', '\x2', '\x2', '\x2', '\x5', 'k', '\x3', '\x2', '\x2', '\x2', 
		'\a', 'v', '\x3', '\x2', '\x2', '\x2', '\t', 'x', '\x3', '\x2', '\x2', 
		'\x2', '\v', 'z', '\x3', '\x2', '\x2', '\x2', '\r', '\x82', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\x85', '\x3', '\x2', '\x2', '\x2', '\x11', '\x87', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '\x89', '\x3', '\x2', '\x2', '\x2', 
		'\x15', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x17', '\x8D', '\x3', '\x2', 
		'\x2', '\x2', '\x19', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x91', 
		'\x3', '\x2', '\x2', '\x2', '\x1D', '\x94', '\x3', '\x2', '\x2', '\x2', 
		'\x1F', '\x97', '\x3', '\x2', '\x2', '\x2', '!', '\x99', '\x3', '\x2', 
		'\x2', '\x2', '#', '\x9B', '\x3', '\x2', '\x2', '\x2', '%', '\x9D', '\x3', 
		'\x2', '\x2', '\x2', '\'', '\xA0', '\x3', '\x2', '\x2', '\x2', ')', '\xA8', 
		'\x3', '\x2', '\x2', '\x2', '+', '\xAC', '\x3', '\x2', '\x2', '\x2', '-', 
		'\xB0', '\x3', '\x2', '\x2', '\x2', '/', '\xB4', '\x3', '\x2', '\x2', 
		'\x2', '\x31', '\xB6', '\x3', '\x2', '\x2', '\x2', '\x33', '\xBA', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\xBC', '\x3', '\x2', '\x2', '\x2', '\x37', 
		'\xBF', '\x3', '\x2', '\x2', '\x2', '\x39', '\xC4', '\x3', '\x2', '\x2', 
		'\x2', ';', '\xC9', '\x3', '\x2', '\x2', '\x2', '=', '\xCF', '\x3', '\x2', 
		'\x2', '\x2', '?', '\xD1', '\x3', '\x2', '\x2', '\x2', '\x41', '\xD4', 
		'\x3', '\x2', '\x2', '\x2', '\x43', '\xD6', '\x3', '\x2', '\x2', '\x2', 
		'\x45', '\xD8', '\x3', '\x2', '\x2', '\x2', 'G', '\xDB', '\x3', '\x2', 
		'\x2', '\x2', 'I', '\xDD', '\x3', '\x2', '\x2', '\x2', 'K', '\xDF', '\x3', 
		'\x2', '\x2', '\x2', 'M', '\xE1', '\x3', '\x2', '\x2', '\x2', 'O', '\xE5', 
		'\x3', '\x2', '\x2', '\x2', 'Q', '\xE9', '\x3', '\x2', '\x2', '\x2', 'S', 
		'\xED', '\x3', '\x2', '\x2', '\x2', 'U', '\xF6', '\x3', '\x2', '\x2', 
		'\x2', 'W', '\x101', '\x3', '\x2', '\x2', '\x2', 'Y', '\x10D', '\x3', 
		'\x2', '\x2', '\x2', '[', '\x10F', '\x3', '\x2', '\x2', '\x2', ']', '\x111', 
		'\x3', '\x2', '\x2', '\x2', '_', '\x113', '\x3', '\x2', '\x2', '\x2', 
		'\x61', '\x116', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\a', 'r', 
		'\x2', '\x2', '\x64', '\x65', '\a', '\x63', '\x2', '\x2', '\x65', '\x66', 
		'\a', '\x65', '\x2', '\x2', '\x66', 'g', '\a', 'm', '\x2', '\x2', 'g', 
		'h', '\a', '\x63', '\x2', '\x2', 'h', 'i', '\a', 'i', '\x2', '\x2', 'i', 
		'j', '\a', 'g', '\x2', '\x2', 'j', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'k', 'l', '\a', 'g', '\x2', '\x2', 'l', 'm', '\a', 'p', '\x2', '\x2', 
		'm', 'n', '\a', '\x66', '\x2', '\x2', 'n', 'o', '\a', 'r', '\x2', '\x2', 
		'o', 'p', '\a', '\x63', '\x2', '\x2', 'p', 'q', '\a', '\x65', '\x2', '\x2', 
		'q', 'r', '\a', 'm', '\x2', '\x2', 'r', 's', '\a', '\x63', '\x2', '\x2', 
		's', 't', '\a', 'i', '\x2', '\x2', 't', 'u', '\a', 'g', '\x2', '\x2', 
		'u', '\x6', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', '\x42', '\x2', 
		'\x2', 'w', '\b', '\x3', '\x2', '\x2', '\x2', 'x', 'y', '\a', '<', '\x2', 
		'\x2', 'y', '\n', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\a', '\x65', 
		'\x2', '\x2', '{', '|', '\a', 'q', '\x2', '\x2', '|', '}', '\a', 'p', 
		'\x2', '\x2', '}', '~', '\a', 'v', '\x2', '\x2', '~', '\x7F', '\a', 'g', 
		'\x2', '\x2', '\x7F', '\x80', '\a', 'z', '\x2', '\x2', '\x80', '\x81', 
		'\a', 'v', '\x2', '\x2', '\x81', '\f', '\x3', '\x2', '\x2', '\x2', '\x82', 
		'\x83', '\a', '<', '\x2', '\x2', '\x83', '\x84', '\a', '<', '\x2', '\x2', 
		'\x84', '\xE', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', '*', 
		'\x2', '\x2', '\x86', '\x10', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', 
		'\a', '+', '\x2', '\x2', '\x88', '\x12', '\x3', '\x2', '\x2', '\x2', '\x89', 
		'\x8A', '\a', '?', '\x2', '\x2', '\x8A', '\x14', '\x3', '\x2', '\x2', 
		'\x2', '\x8B', '\x8C', '\a', '-', '\x2', '\x2', '\x8C', '\x16', '\x3', 
		'\x2', '\x2', '\x2', '\x8D', '\x8E', '\a', '/', '\x2', '\x2', '\x8E', 
		'\x18', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\a', '>', '\x2', 
		'\x2', '\x90', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x91', '\x92', '\a', 
		'>', '\x2', '\x2', '\x92', '\x93', '\a', '?', '\x2', '\x2', '\x93', '\x1C', 
		'\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\a', '@', '\x2', '\x2', '\x95', 
		'\x96', '\a', '?', '\x2', '\x2', '\x96', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '\x97', '\x98', '\a', '@', '\x2', '\x2', '\x98', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\x99', '\x9A', '\a', '\x31', '\x2', '\x2', '\x9A', '\"', 
		'\x3', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\a', ',', '\x2', '\x2', '\x9C', 
		'$', '\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\a', '>', '\x2', '\x2', 
		'\x9E', '\x9F', '\a', '@', '\x2', '\x2', '\x9F', '&', '\x3', '\x2', '\x2', 
		'\x2', '\xA0', '\xA1', '\a', 'k', '\x2', '\x2', '\xA1', '\xA2', '\a', 
		'o', '\x2', '\x2', '\xA2', '\xA3', '\a', 'r', '\x2', '\x2', '\xA3', '\xA4', 
		'\a', 'n', '\x2', '\x2', '\xA4', '\xA5', '\a', 'k', '\x2', '\x2', '\xA5', 
		'\xA6', '\a', 'g', '\x2', '\x2', '\xA6', '\xA7', '\a', 'u', '\x2', '\x2', 
		'\xA7', '(', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\a', 'p', '\x2', 
		'\x2', '\xA9', '\xAA', '\a', 'q', '\x2', '\x2', '\xAA', '\xAB', '\a', 
		'v', '\x2', '\x2', '\xAB', '*', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xAD', 
		'\a', 'z', '\x2', '\x2', '\xAD', '\xAE', '\a', 'q', '\x2', '\x2', '\xAE', 
		'\xAF', '\a', 't', '\x2', '\x2', '\xAF', ',', '\x3', '\x2', '\x2', '\x2', 
		'\xB0', '\xB1', '\a', '\x63', '\x2', '\x2', '\xB1', '\xB2', '\a', 'p', 
		'\x2', '\x2', '\xB2', '\xB3', '\a', '\x66', '\x2', '\x2', '\xB3', '.', 
		'\x3', '\x2', '\x2', '\x2', '\xB4', '\xB5', '\a', '.', '\x2', '\x2', '\xB5', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xB7', '\a', 'n', '\x2', 
		'\x2', '\xB7', '\xB8', '\a', 'g', '\x2', '\x2', '\xB8', '\xB9', '\a', 
		'v', '\x2', '\x2', '\xB9', '\x32', '\x3', '\x2', '\x2', '\x2', '\xBA', 
		'\xBB', '\a', '=', '\x2', '\x2', '\xBB', '\x34', '\x3', '\x2', '\x2', 
		'\x2', '\xBC', '\xBD', '\a', 'k', '\x2', '\x2', '\xBD', '\xBE', '\a', 
		'h', '\x2', '\x2', '\xBE', '\x36', '\x3', '\x2', '\x2', '\x2', '\xBF', 
		'\xC0', '\a', 'v', '\x2', '\x2', '\xC0', '\xC1', '\a', 'j', '\x2', '\x2', 
		'\xC1', '\xC2', '\a', 'g', '\x2', '\x2', '\xC2', '\xC3', '\a', 'p', '\x2', 
		'\x2', '\xC3', '\x38', '\x3', '\x2', '\x2', '\x2', '\xC4', '\xC5', '\a', 
		'g', '\x2', '\x2', '\xC5', '\xC6', '\a', 'n', '\x2', '\x2', '\xC6', '\xC7', 
		'\a', 'u', '\x2', '\x2', '\xC7', '\xC8', '\a', 'g', '\x2', '\x2', '\xC8', 
		':', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCA', '\a', 'g', '\x2', '\x2', 
		'\xCA', '\xCB', '\a', 'p', '\x2', '\x2', '\xCB', '\xCC', '\a', '\x66', 
		'\x2', '\x2', '\xCC', '\xCD', '\a', 'k', '\x2', '\x2', '\xCD', '\xCE', 
		'\a', 'h', '\x2', '\x2', '\xCE', '<', '\x3', '\x2', '\x2', '\x2', '\xCF', 
		'\xD0', '\a', '\x30', '\x2', '\x2', '\xD0', '>', '\x3', '\x2', '\x2', 
		'\x2', '\xD1', '\xD2', '\a', '/', '\x2', '\x2', '\xD2', '\xD3', '\a', 
		'@', '\x2', '\x2', '\xD3', '@', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD5', 
		'\a', '}', '\x2', '\x2', '\xD5', '\x42', '\x3', '\x2', '\x2', '\x2', '\xD6', 
		'\xD7', '\a', '\x7F', '\x2', '\x2', '\xD7', '\x44', '\x3', '\x2', '\x2', 
		'\x2', '\xD8', '\xD9', '\a', '\x30', '\x2', '\x2', '\xD9', '\xDA', '\a', 
		'\x30', '\x2', '\x2', '\xDA', '\x46', '\x3', '\x2', '\x2', '\x2', '\xDB', 
		'\xDC', '\a', ']', '\x2', '\x2', '\xDC', 'H', '\x3', '\x2', '\x2', '\x2', 
		'\xDD', '\xDE', '\a', '_', '\x2', '\x2', '\xDE', 'J', '\x3', '\x2', '\x2', 
		'\x2', '\xDF', '\xE0', '\a', '~', '\x2', '\x2', '\xE0', 'L', '\x3', '\x2', 
		'\x2', '\x2', '\xE1', '\xE2', '\a', 'r', '\x2', '\x2', '\xE2', '\xE3', 
		'\a', 't', '\x2', '\x2', '\xE3', '\xE4', '\a', 'g', '\x2', '\x2', '\xE4', 
		'N', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE6', '\a', 'U', '\x2', '\x2', 
		'\xE6', '\xE7', '\a', 'g', '\x2', '\x2', '\xE7', '\xE8', '\a', 'v', '\x2', 
		'\x2', '\xE8', 'P', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\a', 
		'\x44', '\x2', '\x2', '\xEA', '\xEB', '\a', '\x63', '\x2', '\x2', '\xEB', 
		'\xEC', '\a', 'i', '\x2', '\x2', '\xEC', 'R', '\x3', '\x2', '\x2', '\x2', 
		'\xED', '\xEE', '\a', 'U', '\x2', '\x2', '\xEE', '\xEF', '\a', 'g', '\x2', 
		'\x2', '\xEF', '\xF0', '\a', 's', '\x2', '\x2', '\xF0', '\xF1', '\a', 
		'w', '\x2', '\x2', '\xF1', '\xF2', '\a', 'g', '\x2', '\x2', '\xF2', '\xF3', 
		'\a', 'p', '\x2', '\x2', '\xF3', '\xF4', '\a', '\x65', '\x2', '\x2', '\xF4', 
		'\xF5', '\a', 'g', '\x2', '\x2', '\xF5', 'T', '\x3', '\x2', '\x2', '\x2', 
		'\xF6', '\xF7', '\a', '\x45', '\x2', '\x2', '\xF7', '\xF8', '\a', 'q', 
		'\x2', '\x2', '\xF8', '\xF9', '\a', 'n', '\x2', '\x2', '\xF9', '\xFA', 
		'\a', 'n', '\x2', '\x2', '\xFA', '\xFB', '\a', 'g', '\x2', '\x2', '\xFB', 
		'\xFC', '\a', '\x65', '\x2', '\x2', '\xFC', '\xFD', '\a', 'v', '\x2', 
		'\x2', '\xFD', '\xFE', '\a', 'k', '\x2', '\x2', '\xFE', '\xFF', '\a', 
		'q', '\x2', '\x2', '\xFF', '\x100', '\a', 'p', '\x2', '\x2', '\x100', 
		'V', '\x3', '\x2', '\x2', '\x2', '\x101', '\x102', '\a', '\x61', '\x2', 
		'\x2', '\x102', 'X', '\x3', '\x2', '\x2', '\x2', '\x103', '\x104', '\a', 
		'r', '\x2', '\x2', '\x104', '\x105', '\a', 't', '\x2', '\x2', '\x105', 
		'\x10E', '\a', 'g', '\x2', '\x2', '\x106', '\x107', '\a', 'r', '\x2', 
		'\x2', '\x107', '\x108', '\a', 'q', '\x2', '\x2', '\x108', '\x109', '\a', 
		'u', '\x2', '\x2', '\x109', '\x10E', '\a', 'v', '\x2', '\x2', '\x10A', 
		'\x10B', '\a', 'k', '\x2', '\x2', '\x10B', '\x10C', '\a', 'p', '\x2', 
		'\x2', '\x10C', '\x10E', '\a', 'x', '\x2', '\x2', '\x10D', '\x103', '\x3', 
		'\x2', '\x2', '\x2', '\x10D', '\x106', '\x3', '\x2', '\x2', '\x2', '\x10D', 
		'\x10A', '\x3', '\x2', '\x2', '\x2', '\x10E', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\x10F', '\x110', '\x4', '\x63', '|', '\x2', '\x110', '\\', '\x3', 
		'\x2', '\x2', '\x2', '\x111', '\x112', '\x4', '\x43', '\\', '\x2', '\x112', 
		'^', '\x3', '\x2', '\x2', '\x2', '\x113', '\x114', '\x4', '\x32', ';', 
		'\x2', '\x114', '`', '\x3', '\x2', '\x2', '\x2', '\x115', '\x117', '\t', 
		'\x2', '\x2', '\x2', '\x116', '\x115', '\x3', '\x2', '\x2', '\x2', '\x117', 
		'\x118', '\x3', '\x2', '\x2', '\x2', '\x118', '\x116', '\x3', '\x2', '\x2', 
		'\x2', '\x118', '\x119', '\x3', '\x2', '\x2', '\x2', '\x119', '\x11A', 
		'\x3', '\x2', '\x2', '\x2', '\x11A', '\x11B', '\b', '\x31', '\x2', '\x2', 
		'\x11B', '\x62', '\x3', '\x2', '\x2', '\x2', '\x5', '\x2', '\x10D', '\x118', 
		'\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}