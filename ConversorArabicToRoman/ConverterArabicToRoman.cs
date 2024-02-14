using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorArabicToRoman
{
    public class ConverterArabicToRoman
    {
        public string ConvertToRoman(int input)
        {
            string romanNumber = "";
            int[] arabics = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] romans = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            int i = romans.Length - 1;


            

            if (!(input is int))
            {
                return "Incorrect data type. Just intergers valid.";
            }
            if (input > 9999 || input < 0)
            {
                return "We just accept numbers between 1 - 9999";
            }

            do
            {
                if (input >= arabics[i])
                {
                    input -= arabics[i];
                    romanNumber += romans[i];
                }
                else
                {
                    i--;
                }


            }while (input > 0);

            return romanNumber;

        }

        
    }
}
