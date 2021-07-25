using System;
					
// Q1
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

// Q2
public class LikePizza
{
	public static void Main()
	{
		string myName = "Daniel";
		int myAge = 29;
		bool likePizza = true;
		double piNumber = 3.14;
		Console.WriteLine("My program is running");
	}
}

// Q3
public class GetOrder
{
	public static void Main()
	{
		string product;
		Console.WriteLine("# HackerU Shop #");
		Console.WriteLine("Which products would you like to buy?");
		Console.WriteLine("Milk");
		Console.WriteLine("Chocolate");
		Console.WriteLine("Apple");
		product = Console.ReadLine();
		System.Console.WriteLine("Thank you for buying {0}", product);
	}

	//test

}