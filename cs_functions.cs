using System;
				
// Q1
public class ScientificCalculator
{
	private static void Main()
	{
		string exp; string[] param; char op; double x, y, result;

		Console.WriteLine("Enter expression: ");
		exp = Console.ReadLine();
		param  = exp.Split(" ");
		x = double.Parse(param[0]);
		y = double.Parse(param[2]);
		op = char.Parse(param[1]);
		result = GetResult(x, y, op);
		Console.WriteLine("{0} {1} {2} = {3}", x, op, y, result);
		;
    }
	static double GetResult(double x, double y, char op)
	{
		double result = 0;

		switch (op) {
            case '+':
                result = x + y;
                break;
            case '-':
                result = x - y;
                break;
            case '/':
                result = x / y;
                break;
            case '*':
                result = x * y;
                break;
            case '%':
                result = x % y;
                break;
    	}
		result = Math.Round(result*100)/100; // round 2 decimals
		return result;
	}
}