using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorArabicToRoman
{
    [TestFixture]
    public class TestConverter
    {
        [Test]
        public void TestConverter1()
        {
            int testInput = 569;
            ConverterArabicToRoman converter = new ConverterArabicToRoman();


            ClassicAssert.AreEqual("DLXIX", converter.ConvertToRoman(testInput));

            

        }
        [Test]
        public void TestConverter2()
        {
            int testInput = 7940;
            ConverterArabicToRoman converter = new ConverterArabicToRoman();


           ClassicAssert.AreEqual("MMMMMMMCMXL", converter.ConvertToRoman(testInput));

            

        }

        [Test]
        public void TestConverter3()
        {
            int testInput = 10000;
            ConverterArabicToRoman converter = new ConverterArabicToRoman();


            ClassicAssert.AreEqual("We just accept numbers between 1 - 9999", converter.ConvertToRoman(testInput));

            

        }

    }
}
