using System;
					
public class GetBirthDate
{
	public static void Main()
	{
		int iYear, iMonth, iDay;
		
		Console.WriteLine("Enter year: ");
		iYear = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter month: ");
		iMonth = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter day: ");
		iDay = int.Parse(Console.ReadLine());
		
		Console.WriteLine(iDay + "." + iMonth + "." + iYear);
		Console.WriteLine(iDay + "-" + iMonth + "-" + iYear);
		Console.WriteLine(iDay + "/" + iMonth + "/" + iYear);
		
	}
}

public class LikePizza
{
	public static void Main()
	{

	}
}