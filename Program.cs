using System;

namespace SelectionTask
{
    class Program 
	{
	
        static void Main(string[] args) 
		{
		
			int age;
			string gender;
			
			Console.WriteLine("Gday! Please enter your age.");
			age = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter your gender.");
			gender = (Console.ReadLine());

			// true branch
			if (age >= 17)
			{
				if (gender == "M")
				{
					Console.WriteLine("Nice! You're legally an adult Male.");
				}
			
				else {
					if (age >= 17)
					{
						if (gender == "F") {
							Console.WriteLine("Nice! You're legally an adult Female.");
						}
					}
				}
			}
			else {
				if (age < 17) 
				{
					Console.WriteLine("Hmm. Looks like you're legally not an adult");
				}
			}


			Console.WriteLine("Please enter a number.");
			string input1 = Console.ReadLine();
			int num1 = int.Parse(input1);

			Console.WriteLine("Please enter another number.");
			string input2 = Console.ReadLine();
			int num2 = int.Parse(input2);

			Console.WriteLine(num1+num2 + "" + "is the total number");
		


		



		}
	}
}
			