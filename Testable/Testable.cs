using System;

namespace TestableTests
{
    public class Testable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public string ConvertToString<T>(T typeToConvert)
        {
            if (typeToConvert == null)
            {
                return "";
            }

            return typeToConvert.ToString();
        }


        public virtual bool IsStringLongEnough(string text)
        {
            if (text.Length >= 5)
            {
                return true;
            }

            return false;
        }

        public abstract List<int> PurgeListOfInts(List<int> listOfInts)
        {
            return listOfInts.Clear();

        }
    }
}