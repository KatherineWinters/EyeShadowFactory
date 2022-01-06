using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ShimmeryEyeShadow : IPalette
    {
        public void Create()
        {
            Console.WriteLine("Creating a shimmery eyeshadow!");
        }
    }
}
