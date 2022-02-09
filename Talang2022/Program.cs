using System;
using System.Collections.Generic;
using System.Linq;

namespace Talang2022
{
    class Program
    {
        static void Main(string[] args)
        {

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
           
        }
    }
}
