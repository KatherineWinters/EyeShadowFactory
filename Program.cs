using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of eye shadow is your preference?");
            string userPreference = Console.ReadLine();

            IPalette eyeShadow = EyeShadowFactory.GetEyeShadow (userPreference);

            eyeShadow.Create();
            Console.ReadLine();
        }
    }
}
