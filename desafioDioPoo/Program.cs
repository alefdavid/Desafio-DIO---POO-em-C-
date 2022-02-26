using System;
using static desafioDioPoo.src.Entities.Wizard;

namespace desafioDioPoo.src.Entities;
    class Program
    {
        static void Main(String[] args)
        {
        Knight arus = new Knight("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 25, "White Wizard");
        Ninja wedge = new Ninja("Wedge", 42, "Ninja");
        Wizard Tupapa = new Wizard("Tupapa", 45, "Black Wizard");
       
        Console.WriteLine(arus.Attack());
        Console.WriteLine(wizard.AttackWhiteWizard(11));
        Console.WriteLine(wedge.AttackNinja(10));
        Console.WriteLine(Tupapa.AttackBlackWizard(12));       
        }
    }
