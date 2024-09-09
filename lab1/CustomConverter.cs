using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class CustomConverter
    {
        internal void Convert(string input, out int result)
        {
            Int32.TryParse(input, out result);
        }
        internal void Convert(string input, out double result)
        {
            Double.TryParse(input, out result);
        }
        internal void Convert(string input, out float result)
        {
            Single.TryParse(input, out result);
        }
        internal void Convert(string input, out bool result)
        {
            Boolean.TryParse(input, out result);
        }
    }
}
