using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.Utils
{
    public class Validator
    {
        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
