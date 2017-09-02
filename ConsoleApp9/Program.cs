using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //If you expect an error you can use (try and catch).
            string msg = "Enter The Number:";
            try
            {
                Console.Write(msg);
                int x = Convert.ToInt32(Console.ReadLine());
                msg = "The number you have entered is ";
                Console.WriteLine(msg + x);





            }
            catch (Exception error)
            {
                Console.WriteLine("Error:" + error);






            }








            Console.ReadKey();
        }
    }
}
