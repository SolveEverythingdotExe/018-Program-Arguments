using System;
using System.IO;
using System.Linq;
using System.Text;

namespace SortContent
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENHANCEMENT ============> added a validation if no parameter is supplied
            if (args.Count() == 0)
            {
                Console.WriteLine("No argument/parameter was supplied.");
                return;
            }
            
            //lets read the parameter
            string FileName = args[0];

            //the parameter will only be 1, the filename which will gonna sort
            //lets check if the file exists first
            if (File.Exists(FileName))
            { 
                //now lets write the output
                File.WriteAllLines("output.txt", SortInput(File.ReadAllLines(FileName)), Encoding.Default);
            }
            else
                Console.WriteLine("File does not exist!");
        }

        //now lets create a sorting method
        private static string[] SortInput(string[] inputList)
        {
            Array.Sort(inputList);

            return inputList;
        }
        //now lets build and test
    }
}
