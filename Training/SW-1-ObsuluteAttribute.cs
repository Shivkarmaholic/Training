using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    // Obsulute Attribute Example

namespace Training
{
    class SW_1_ObsuluteAttribute
    {

        [Obsolete("Don't use OldMethod, use AgainNewMethod instead", true)]

        static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }
        static void AgainNewMethod()
        {
            Console.WriteLine("Again New Method Code");
        }
        public static void Main()
        {
            AgainNewMethod();
        }
    }
}
