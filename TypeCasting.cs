/* There Are two types of typecastings
    1. Implicit TypeCasting
        char to int
        int to long
        long to float 
        float to double
    Example:-
            int x = 11;
            double y = x;      This is valid Because of the Implicit typecasting properties.
    2. Explicit TypeCasting
*/

using System;

namespace Hello
{
    class Demo
    {   
        static void Main(string[] Google)
        {
        // Implicit Casting
        int i = 21;
        double j = i;
        float z = 'A';  // This Will Print the Ascii Value of "A" i.e 65
        Console.WriteLine(z); 
        float varr = Convert.ToInt32 (3.55);
        Console.WriteLine(varr);
        // Explicit Casring
        int k = (int) 45.66;
        Console.WriteLine(k);

        }
    }
}