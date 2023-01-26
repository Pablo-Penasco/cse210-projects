using System;

class Program
{
    static void Main(string[] args)
    {
       Tutor tutor1 = new Tutor();

       tutor1._age = 25;

       Console.WriteLine(tutor1._age);

       string intro = tutor1.Introduction();

       Console.WriteLine(intro);

       
    }


}