using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintassiBase
{
    static class InputValidator
    {
        public static bool IsIntero(float input)
        {
            if (input > 0 && input == MathF.Floor(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
