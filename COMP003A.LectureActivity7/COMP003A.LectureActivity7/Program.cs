using System.Collections.Generic;

namespace COMP003A.LectureActivity7
{
	internal class Program
	{ 
		static void Main(string[] args)
		{
			/* Invalid validation is generally preferred over try-catch because it prevents errors and handles expected conditions.
			 * This makes it more predictable, having it easier to debug and maintain.*/
			int[] scores = {9, 23, 36, 42, 59 };

			for (int i = 0; i < scores.Length; i++)
			{
				Console.WriteLine(scores[i]);
			}
			
			
			List<string> names = new List<string>();
			names.Add("Josh");
			names.Add("Steph");
			names.Add("Monish");

			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

			for (int i = 0; i < names.Count; i++)
			{
				Console.WriteLine(names[i]);
			}

			Console.Write("Please Enter a Number 1-3: ");
			/* Try-catch is still necessary in some cases because it handles the unexpected values when user input is asked.
			 * This command should be used to hold unvalidated outcomes in advance.*/
			try 
			{
				int changedNumber = int.Parse(Console.ReadLine());
				Console.WriteLine(changedNumber);
			}
			catch (FormatException)
			{ 
				Console.WriteLine("Invalid number entered.");
			}
		}
	} /* Debugging helped me understand these concepts of loop behavior because it showed me the precise excecution flow of loops.
	   * By stepping into the code, you can see and confirm when loop conditions are met or left, ensuring that the program works.*/
}
