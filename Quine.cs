class P
{
	static void Main()
	{
		var s = @"class P
{{
	static void Main()
	{{
		var s = @""{0}"";
		var q = '\u0022'.ToString();
        System.Console.WriteLine(s, s.Replace(q, q + q));
	}}
}}";
		var q = '\u0022'.ToString();
        System.Console.WriteLine(s, s.Replace(q, q + q));
	}
}
