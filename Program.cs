using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sey somethink");
            string name = (Console.ReadLine());
            for (var  i = name.Length -1; i > -1; i--)
            {
                Console.WriteLine(name[i]);
            }
        }          
    }
}
