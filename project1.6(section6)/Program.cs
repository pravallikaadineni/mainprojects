using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project1._6
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myfile = @"D:\repos\pratice projects\StudentsDetails.txt";
            if (File.Exists(myfile))
            {
                string r = File.ReadAllText(myfile);
                Console.WriteLine(r);
                Console.ReadLine();
                

            }

        }
    }
}
