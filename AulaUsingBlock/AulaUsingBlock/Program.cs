using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AulaUsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\file1.txt";


            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }



        }
    }
}
