using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello there!");

       Random randomNumber  = new Random();
       int magicNumber = randomNumber.Next(1,99);
       int guessed;
       int guessCount = 0;
       string playAgain;
       
       do{

        do{
            Console.Write("Guess the magic number?");
            string guess= Console.ReadLine();
            guessed = int.Parse(guess);
            guessCount ++;

            if (magicNumber > guessed) {
                Console.WriteLine("Lower");
            }
            else if (magicNumber < guessed) {
                Console.WriteLine("Higher");
            }
        }
        while (guessed != magicNumber);
        
        Console.WriteLine($"You have correctly guessed the magic number. It took you {guessCount} guesses");

        Console.Write("Do you want to play again? (yes/no)");
        playAgain =Console.ReadLine().ToLower();
        guessCount =0;
       }
       while (playAgain == "yes");



}

}