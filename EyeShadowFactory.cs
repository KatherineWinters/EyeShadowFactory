using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class EyeShadowFactory
    {
        public static IPalette GetEyeShadow(string eyeShadow)
        {
            switch (eyeShadow.ToLower())
            {
                case "shimmery":
                    return new ShimmeryEyeShadow();

                case "neutral":
                    return new NeutralEyeShadow();

                case "bold":
                    return new BoldEyeShadow();

                    default: return null;
            }
        }
    }
}
