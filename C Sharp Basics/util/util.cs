using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.util

{
    public class Util
    {
        public static int getAge(DateOnly dob)
        {
            return DateTime.Now.Year - dob.Year;
        }
    }
}
