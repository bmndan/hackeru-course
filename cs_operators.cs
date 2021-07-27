using System;
					
// Q1
public class CalcRemainder
{
	public static void Main()
	{
        int dividend, divisor, division, remainder;

		// enter dividend
        System.Console.Write("Enter dividend: ");
        dividend = int.Parse(Console.ReadLine());

        // enter divisor
        System.Console.Write("Enter divisor: ");
        divisor = int.Parse(Console.ReadLine());

        // calculate result
        division = dividend / divisor;
        remainder = dividend % divisor;

        // print result
        System.Console.WriteLine("Division: {0}, Remainder: {1}", division, remainder);
	}
}

//Q2
public class SumDigits
{
	public static void Main()
	{
        int n, sum;
        
        System.Console.Write("Enter number [100-999]:");
        int n = int.Parse(Console.ReadLine());

        bool isInRange = (n >= 100 && n <= 999);

        if (isInRange)
        {
            sum = n % 10;
            n /= 10;
            sum += n % 10;
            n /= 10;
            sum += n % 10;
            System.Console.WriteLine(sum);
        }
        else
        {
            System.Console.WriteLine("Error: number out of range");
        }
    }
}

public class CalcDays
{
	public static void Main()
	{
        System.Console.WriteLine("Enter days: ");
        int n = int.Parse(Console.ReadLine());
        int years = n / 360;
        int months = n / 30 % 12;
        int days = n % 30;
        System.Console.WriteLine("{0} years, {1} months, {2} days", years, months, days);
    }
}