using System;
using static Job;


class Program
{
    static void Main(string[] args)
    {

         Job job1 = new Job();
         job1._company = "Goldman Sachs";
         job1._jobTitle ="Data Analyst";
         job1._startYear = 2025;
         job1._endYear = 2035;

         

         Job job2 = new Job();
         job2._company = "JP Morgan";
         job2._jobTitle ="Vice President";
         job2._startYear = 2036;
         job2._endYear = 2050;

         

         Resume myResume = new Resume();
         myResume.name = "Nana Kwame Dickson";
         myResume._jobs.Add(job1);
         myResume._jobs.Add(job2);

    myResume.Display();



    }
    
}