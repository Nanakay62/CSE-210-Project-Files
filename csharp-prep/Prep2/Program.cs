using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        

        Console.Write("What was your score?");
        string grade = Console.ReadLine();
        int grades = int.Parse(grade);
        string positive = "+";
        string negative = "-";

        

        if ( grades >= 90 && grades <=100){
            string letter ="A";
             if (grades >= 90 && grades <= 93 )
            {
                Console.WriteLine(letter + negative);
            }

            else if (grades >= 94 && grades <= 100) 
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine($"Congratulations! You have passed your exam with distinction!!.");        
        }
        else if (grades>= 80 && grades <= 89 ){
            string letter ="B";           
            
            if (grades >=80 && grades <=83)
                {
                Console.WriteLine(letter + negative);
            }

            if (grades >=84 && grades <=86)
                {
                Console.WriteLine(letter);
            }

            if (grades >=87 && grades <=89)
               {
                Console.WriteLine(letter + positive);

            }
            Console.WriteLine("You have obtained excellent result. Well Done!");
            
        }
    
        else if (grades>= 70 && grades <= 79 ){
            string letter ="C";

            if (grades >= 70 && grades <= 73 )
            {
                Console.WriteLine(letter + negative);
            }

            else if (grades >= 74 && grades >= 76) 
            {
                Console.WriteLine(letter);
            }
            else if (grades >= 77 && grades <= 79)
            {
                Console.WriteLine(letter + positive);
            }
            Console.WriteLine("Your have obtained a pass, you can improve.");
            
        }
        else if (grades>= 60 && grades <= 69 ){
            string letter ="D";

             if (grades >= 60 && grades <= 63 )
            {
                Console.WriteLine(letter + negative);
            }

            else if (grades >= 64 && grades >= 66) 
            {
                Console.WriteLine(letter);
            }
            else if (grades >= 67 && grades <= 69)
            {
                Console.WriteLine(letter + positive);
            }
            Console.WriteLine(letter);
            Console.WriteLine("You can do better.");
            
            
        }
        else if (grades>= 0 && grades <= 59 ){
            string letter ="F";
            Console.WriteLine(letter);
            Console.WriteLine("You have obtained really poor results. Study well to do better next time.");
        }
        else{
            Console.WriteLine("You have not entered a score or you did not participate in the exam.");
        }



       



    }
}