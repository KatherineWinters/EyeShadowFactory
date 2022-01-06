using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class BoldEyeShadow : IPalette
    {
        public void Create()
        {
            Console.WriteLine("Creating a bold eyeshadow!");
        }
    }
}
