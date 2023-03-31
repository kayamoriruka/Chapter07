using System;

namespace Overriding
{
    class Program
    {
        class ArmorSuite
        {
            public virtual void Initialize()
            {
                Console.WriteLine("Armored");
            }
        }

        class IronMan : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Repulsor Rays Armed");
            }
        }

        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Double-Barrel Cannons Armed");
                Console.WriteLine("Micro-Rocket Launcher Armed");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironMan = new IronMan();
            ironMan.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warMachine = new WarMachine();
            warMachine.Initialize();
        }
    }
}
