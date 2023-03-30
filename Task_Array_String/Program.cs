using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml.Linq;

namespace Task_Array_String
{
    internal class Program
    {
        static void Main(string[] args)
        {   ////Task 1.1
            //Console.Write("Text input: ");
            //string text = Console.ReadLine();
            //string[] WordArray = text.Split(' ');
            //ArrayNumber(WordArray);


            ////Task 1.2
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8};
            //SumArray(numbers);


            ////Task 1.3
            //Console.Write("Input sentence:");
            //string sentence=Console.ReadLine();

            //Sentence(sentence);


            ////Task 1.4
            //Console.Write("Input number: ");
            //string num = Console.ReadLine();
            //DoubleInt(num);



            ////Task 1.6
            //string[] city = { "Ekvador","Ismayilli", "Kelbecer", "Zengilan", "Baku"};
            //Cities(city);


            ////Task 1.7
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //OddEven(number);



            ////Task 1.8
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            SentenceAdd(sentence);
        }
        static void ArrayNumber(string[] WordArray)
        {
            int sum = 0;
            for(int i = 0; i < WordArray.Length; i++)
            {
                sum++;
            }
            Console.WriteLine("Array Word number: "+sum);
        }
        static void SumArray(int [] numbers)
        {
            int SumofArray = 0;
            for(int i=0; i < numbers.Length; i++)
            {
                SumofArray += numbers[i];
            }
            Console.WriteLine("SumOfArray:"+SumofArray);
        }
        static void Sentence(string sentence)
        {

            string[] word = sentence.Split(' ');
            for(int i = 0; i < word.Length; i++)
            {
                word[i] = word[i][0].ToString().ToUpper() + word[i].Substring(1);
            }
            string Big=string.Join(" ", word);

            Console.WriteLine(Big);


        }
        static void DoubleInt(string num)
        {
            if (int.TryParse(num, out int number1))
            {
                Console.WriteLine("Number int: "+number1);
            }
            else if (double.TryParse(num, out double number2))
            {
                Console.WriteLine("Number double: "+number2);
            }

        }

        static void Cities(string[] city)
        {

            int step = 0;
            for (int i = 0; i < city.Length; i++)
            {
                if (city[i].Contains("e"))
                {
                    step++;
                }
            }

            Console.WriteLine(step);

            //char letter = 'e';
            //int step = 0;
            //for (int i = 0; i < city.Length; i++)
            //{
            //    //if (letter==city[i])
            //    {
            //        step++;
            //    }
            //}
        }

        static void OddEven(int number)
        {
            string result = (number % 2 == 0) ? "even" : "odd";
            Console.WriteLine(result);
        }

        static void SentenceAdd(string sentence)
        {
            char[] sait = { 'a', 'ı', 'o', 'u','e','ə','i','ö','ü' };
            int count = 0;
            for (int i=0;i<sentence.Length;i++)
            {
                if (sentence.Contains(sait[i]))
                {
                    count++;
                }
            }
            Console.WriteLine("Sait count: "+count);
        }
    }
}
