using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            string inFile = null, outFile = null;

            if (args.Count() >= 2)
            {
                inFile = args[0];
                outFile = args[1];

                try
                {
                    new Parser(inFile, outFile).BuildHTMLFile();
                    Console.Write("HTML report created.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.Write("Usage: ExtentNUnit \"NUnitResult.xml\" \"ExtentNUnit.html\"");
            }
        }
    }
}
