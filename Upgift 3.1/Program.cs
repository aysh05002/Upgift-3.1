using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur gammal är du ?");
        int ålder = Convert.ToInt32(Console.ReadLine());

        if (ålder >= 16 && ålder <= 19)
        {
            Console.WriteLine("Du kan vara med tävlingen");
        }
        else
        {
            Console.WriteLine("Du kan tyvär inte vara med tävlingen");
        }
    }
}