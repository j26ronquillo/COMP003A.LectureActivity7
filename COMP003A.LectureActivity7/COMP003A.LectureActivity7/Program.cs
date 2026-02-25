using System.Collections.Generic;

namespace COMP003A.LectureActivity7
{
	internal class Program
	{ 
		static void Main(string[] args)
		{
			
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
			string chosenNumber = Console.ReadLine();

			if (chosenNumber == "1" || chosenNumber == "2" || chosenNumber == "3")
			{
				Console.WriteLine("Success");
			}
			else 
			{
				Console.WriteLine("Error");
			}
		}
	}
}
