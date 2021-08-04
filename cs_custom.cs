using System;
			
// Q1
// print triangle pattern from user input height
// e.g. height 10
// *
// **
// ***
// ****
// *****
// ****
// ***
// **
// *
public class PrintTriangle
{
    static void Main1()
    {
        Console.WriteLine("Enter triangle height: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 0; i < height / 2 + 1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        for (int i = height / 2; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}



// Q2
// print int average of nbers in unknown size array
// e.g. 1,5,6,2,4
// avg = 3
public class PrintAverage
{
    public static void Main2()
    {
		/*user array length
		string input;
		int count;
		
		while (true)
		{
			input = console.readline();
			if (input = "exit")
				break;
			count++;
		}
		int[] arr = new int[count];
		*/
		
		// random array length
		Random rnd = new Random();
		int len = rnd.Next(1,10);
		int[] arr = new int[len];
		
		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] = rnd.Next(1,10);
		}
        Console.WriteLine(GetAverage(arr));
    }

    static int CalcAvg(int[] arr)
    {
        int avg = 0;
        foreach (int n in arr)
        {
            avg = avg + n;
        }
        avg = avg / arr.Length;
		return avg;
    }
}
