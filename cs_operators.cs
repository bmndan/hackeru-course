using System;
					
// Q1
public class CalcRemainder
{
	public static void Main()
	{
        string n; int dividend, divisor, remainder;

		// enter dividend
        System.Console.Write("Enter dividend: ");
        n = Console.ReadLine();
        dividend = int.Parse(n);

        // enter divisor
        System.Console.Write("Enter divisor: ");
        n = Console.ReadLine();
        divisor = int.Parse(n);

        division = dividend / divisor;
        remainder = dividend % divisor;

        System.Console.WriteLine("Division: {0}, Remainder: {1}", division, remainder);
	}
}