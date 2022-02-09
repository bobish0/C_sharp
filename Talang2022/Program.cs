using System;
using System.Collections.Generic;
using System.Linq;

namespace Talang2022
{
    class Program
    {

        // LABB 2
        private static int TestValueType(int i)
        {
            i++;
            return i;
        }

        private static string TestRefType(IList<int> numbers)
        {
            numbers[0]++;
            return $"[{string.Join(", ", numbers)}]";
        }


        static void Main(string[] args)
        {



            // LABB 1
            var obj = new object(); // Object Variable 
            var num = 1; // Integer Variable 
            var str = "abc"; // String Variable

            
            var program = new Program(); // ingerits from class Program?


            var numbers = new List<int> { 1, 2, 3 }; //int
            var range = Enumerable.Range(1, 3); // ints
            int[] arr = { 1, 2, 3 }; //ints
            var arr2 = range.ToArray();


            /* Public Static Void = 
             * 
             * "public" can be accessed by any other code. 
             * "static" means One method / field per instance. 
             * "void" means that nothing gets returned. 
             * 
             * Use string[args] when Main method needs to use props,
             * Main method can also in the terminal accept props when being runned
             */
            Console.WriteLine("Hello World!");


            //LABB 2.1
           

            Console.WriteLine(TestValueType(num));
            Console.WriteLine(TestRefType(arr));
            // use breakpoints to help with debugging code on particular lines
           


        }
    }
}
