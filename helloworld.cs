using System;
public class Program
{
	public static string echoMe(string str)
	{
		return str;
	}
	
	
	public static void Main()
	{
		Console.WriteLine("Hello World");
		Console.WriteLine("" + echoMe("utty"));
	}
}