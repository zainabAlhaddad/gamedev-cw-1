using System;

namespace CW1_2
{
    class Program
    {
        static double playerSpeed;
        static void Main(string[] args)
        {
           
            SetSpeed(2.5);
            Console.WriteLine("The current palayer speed is "+ GetSpeed());

         }

        static void SetSpeed(double newSpeed)
        {
           playerSpeed = newSpeed ;
        }

        static double GetSpeed()
        {
            return playerSpeed;

        }
    }
}
