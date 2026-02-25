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
		}
	}
}
