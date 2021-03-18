using System;

namespace SelectionTask
{
    class Program
    {
	
        static void Main(string[] args) {
		
			int age;
			string gender;
			
			Console.WriteLine("Gday! Please enter your age.");
			age = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter your gender: ");
			gender = (Console.ReadLine());

	// true branch
			if (age >= 17)
			{
			if (gender == "M")
			
				Console.WriteLine("Nice! You're legally an adult Male.");
			} 
			else {
			if (age >= 17)
			{
			if (gender == "F")
				Console.WriteLine("Nice! You're legally an adult Female.");
			}

	// false branch
			else {
			if (age < 17) 
				{
				Console.WriteLine("Hmm. Looks like you're legally not an adult");
				}
			}
        }
	
