using System;
using System.Collections.Generic;
class Sphinx
	{
	public static Dictionary<string, string> riddleMeThis = new Dictionary<string, string>() { {"footsteps", "The more you take, the more you leave behind. What am I?"}, {"An Egg", "What has to be broken before it can be used?"}, {"Jimmy", "Jimmy’s mother had three children. The first was called April, the second was called May. What was the name of the third?"}, {"An Electric Toothbrush", "What's at least 6 inches long, goes in your mouth, and is more fun if it vibrates?"}, {"1", "As I was going to St. Ives, I met a man with seven wives. Each wife had seven sacks, every sack had seven cats, every cat had seven kittens. Kittens, cats, sacks, wives. How many were going to St. Ives?"}};

	
	static void Main()
		{
		Console.WriteLine("To continue, answer the Sphinx's Riddle!");
		Console.WriteLine(riddleMeThis["1"]);
		string riddleAnswer = Console.ReadLine();
		if (riddleAnswer == "1")
		{
			Console.WriteLine("Good job! You got it right! Want to try another one?)['Y' for yes, 'Enter' for no]");
			string nextRiddle = Console.ReadLine();
			if (nextRiddle == "Y" || nextRiddle == "y")
			{
				Console.WriteLine(riddleMeThis["Jimmy"]);
				string riddleAnswer2 = Console.ReadLine();
				if (riddleAnswer2 == "Jimmy" || riddleAnswer2 == "jimmy")
				{
					Console.WriteLine("Good job! You got it right!");
				}
				else {
					Console.WriteLine("You got it wrong, dummy!");
				}
			}
		}
		else {
			Console.WriteLine("You got it wrong, dummy!");
		}
	}
}