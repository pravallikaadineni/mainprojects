using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Project1._6
{
    public class Search
    {
        static void Main(string[] args)
        {
            string myfile = @"D:\repos\pratice projects\searchproject.txt";
            List<string> lines = new List<string>(File.ReadAllLines(myfile));
            lines.Sort();
            foreach (var line in lines)
            {
                Console.WriteLine(line);

            }
            FileStream inFile = new FileStream(@"D:\repos\pratice projects\searchproject.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string record;
            string input;
            bool found = false; 

            Console.Write("Enter student name >> ");
            input = Console.ReadLine();
            try
            {
                
                record = reader.ReadLine();
                while (record != null)
                {


                    if (record.Contains(input))
                    {
                        Console.WriteLine(record);
                        found = true;

                    }


                    record = reader.ReadLine();

                }
                if(!found)
                {
                    Console.WriteLine("student details not found");
                }
                
            }
            finally
            {
                
                inFile.Close();
            }
            Console.ReadLine();
        }
    }
}


