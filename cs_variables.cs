using System;
					
// Q1
public class GetBirthDate
{
	public static void Main1()
	{
		int iYear, iMonth, iDay;
		
		Console.WriteLine("Enter year: ");
		iYear = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter month: ");
		iMonth = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter day: ");
		iDay = int.Parse(Console.ReadLine());
		
		Console.WriteLine("{0}.{1}.{2}", iDay, iMonth, iYear);
		Console.WriteLine("{0}-{1}-{2}", iDay, iMonth, iYear);
		Console.WriteLine("{0}/{1}/{2}", iDay, iMonth, iYear);
	}
}

// Q2
public class LikePizza
{
	public static void Main2()
	{
		string myName = "Daniel";
		int myAge = 29;
		bool likePizza = true;
		double piNumber = 3.14;
		Console.WriteLine("My program is running");
	}
}

public class GetOrder
{
	public static void Main3()
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

}