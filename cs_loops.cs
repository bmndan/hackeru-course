using System;
				
// Q1
public class ValidateAge
{
	private static void Main1()
	{
		int age; bool isValid;
		Console.Write("Enter age: ");
		do {
			age = int.Parse(Console.ReadLine());
			isValid = age > 0 && age < 120;
			if (isValid)
				break;
			Console.Write("Try again: ");
		}
		while (!isValid);
		System.Console.WriteLine("You are {0} years old!", age);
    }
}
			
//Q2
public class FindMaxNum
{
	private static void Main2()
	{
        int[] nums = {8,16,32,64,128,256,1024,2048,4096};
		int maxIndex = 0;
		for (int i = 0; i < nums.Length; i++) {
			if (nums[i] > nums[maxIndex]) {
				maxIndex = i;
			}
		}
		System.Console.WriteLine("Max number: {0}", nums[maxIndex]);
    }
}

// Q3
public class Q3
{
	private static void Main()
	{
		int x = int.Parse(Console.ReadLine()); // enter x
		int y = int.Parse(Console.ReadLine()); // enter y
		char o = char.Parse(Console.ReadLine()); // enter operator
		int r = 0;

        switch (o) {
            case '+':
                r = x + y;
                break;
            case '-':
                r = x - y;
                break;
            case '/':
                r = x / y;
                break;
            case '*':
                r = x * y;
                break;
            case '%':
                r = x % y;
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
    	}
		System.Console.WriteLine("{0}{1}{2}={3}",x,o,y,r);
	}
}