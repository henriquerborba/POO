using System;
using POO.src.Entities;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight(name: "Arus", level: 2, heroType: "Knight");
    
            Wizard Wizard = new Wizard(name: "Jennica", level: 99, heroType: "White Wizard");


            Console.WriteLine(Arus.Attack());

            Console.WriteLine(Wizard.Attack(4));


        }
    }
}
