using System;

namespace Constructor
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }
        ~Cat()
        {
            Console.WriteLine($"{Name} : bye");
        }
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
        class Program
    {
        
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {kitty.Color}");
        }
    }
}
