using System;
public class Program
{
	public static string echoMe(string str)
	{
		return str;
	}
	
	
	public static void Main()
	{
		Console.WriteLine("Hello World. I have made some changes.");
		Console.WriteLine("" + echoMe("utty"));
	}
}