/*
 * Created by SharpDevelop.
 * User: 0239294
 * Date: 4/5/2018
 * Time: 11:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hangman_Console
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Welcome to Russian Hangman!");
			string[] russians = new string[3];
			russians[0] = "da";
			russians[1] = "stalin"
			russians[2] = "gogo"
			
			Random rand = new Random();
			var wordChoice = rand.Next(0, 3)
			string mysteryWord = russians[wordChoice];
			char[] guess = new char[mysteryWord.Length];
			Console.Write("Enter your guess: ");
			
			for (int x = 0; x < mysteryWord.Length; x++) {
				guess[x] = '*';
			}
			
			while (true) {
				char playerGuess = char.Parse(Console.ReadLine());
				for (int j = 0; j < mysteryWord.Length; j++) {
					if (playerGuess == mysteryWord[j]) {
						guess[j] = playerGuess;
					}
					
					
				}
				
				Console.WriteLine(guess);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}