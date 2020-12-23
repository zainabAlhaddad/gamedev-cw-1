using System;

namespace CW1_2
{
    class Program
    {
        static double playerSpeed;
        static void Main(string[] args)
        {

             
            String characterName = "Ahmad", SuperPower1 = "Steel Sheild", SuperPower2 = "night vision";
            int age = 15;

            String HeroName = "Zoey", heroSuperPower1 = "Disappear", heroSuperPower2 = " night vision";
            int heroHigh = 171, heroAge = 27;


            float speed = 1.65f;
            Console.WriteLine("My Name is " + characterName + " and my powers are  " + SuperPower1 + " and " + SuperPower2 + " I am " + age + " years old and my speed is " + speed);

            int diff = heroAge - age;
            Console.WriteLine("The age difference between two hero are " + heroAge + " - " + age + " = " + diff);

            


            int[] charactersPowerValues = { 0,6,4,11,7,8,10 };
              SetSpeed(2.5);
              Console.WriteLine("The current palayer speed is "+ GetSpeed());

            if (charactersPowerValues[0] > charactersPowerValues[2])
                Console.WriteLine("First Power is much stronger than the third one : "+ charactersPowerValues[0]+"> "+ charactersPowerValues[2]);
            else
                Console.WriteLine("THird Power is stronger than the first : " + charactersPowerValues[2] + " > " + charactersPowerValues[0]);


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
