using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String characterName ="Ahmad" , SuperPower1= "Steel Sheild" , SuperPower2="night vision";
            int age = 15;

            String HeroName = "Zoey" ,heroSuperPower1 = "Disappear", heroSuperPower2= " night vision" ;
            int heroHigh = 171, heroAge = 27 ;


            float speed= 1.65f;
            Console.WriteLine("My Name is "+characterName+" and my powers are  "+SuperPower1 +" and "+SuperPower2+" I am "+age+" years old and my speed is "+speed);

            int diff = heroAge - age;
            Console.WriteLine("The age difference between two hero are " + heroAge + " - " + age + " = " + diff);

            Console.WriteLine(SuperPower1 = heroSuperPower1);

        }
    }
}
/* ١. أكمل على ملف التمرين السابق
٢. أنشئ متغيرات بداخلها معلومات بطل آخر .2 heroName, heroHeight, heroAge, heroSuperPower1, heroSuperPower2
٣. أنشئ متغير اسمه. ageDifference و احسب الفرق بين البطل اللذي أنشأته في التمرين السابق و بين البطل هذا
٤. قم بطباعة فارق العمر بال Console */

