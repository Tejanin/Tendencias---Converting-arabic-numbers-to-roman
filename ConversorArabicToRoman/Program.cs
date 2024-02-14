using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorArabicToRoman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            TestConverter testConverter = new TestConverter();
            Console.WriteLine("To run the converter use 1., to test it use 2");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("This is a converter to roman number\n");
                    Console.Write("Enter your number here: ");
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    ConverterArabicToRoman converter = new ConverterArabicToRoman();

                    string output = converter.ConvertToRoman(input);

                    Console.WriteLine(output);
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Press 1,2 or 3 depending which test you want to run");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:

                            testConverter.TestConverter1();
                            break;
                        case 2:
                            testConverter.TestConverter2();
                            break;


                        case 3:
                            testConverter.TestConverter3();
                            break;
                    }
                    break;
            }

            Console.ReadLine();

        }

    }
}
