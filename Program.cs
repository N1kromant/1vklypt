using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1vklypt
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Write a key");
            string text = Console.ReadLine();
            Tuple<int, int>[] array = new Tuple<int, int>[]
            {
      Tuple.Create<int, int>(0, 0),
      Tuple.Create<int, int>(48, 18),
      Tuple.Create<int, int>(63, 18),
      Tuple.Create<int, int>(0, 0),
      Tuple.Create<int, int>(10, 15),
      Tuple.Create<int, int>(18, 20),
      Tuple.Create<int, int>(0, 0),
      Tuple.Create<int, int>(20, 28),
      Tuple.Create<int, int>(8, 14),
      Tuple.Create(12, 45),
      Tuple.Create(23, 67),
      Tuple.Create(34, 89),
      Tuple.Create(56, 12),
      Tuple.Create(78, 34),
      Tuple.Create(90, 21),
      Tuple.Create(15, 76),
      Tuple.Create(43, 58),
      Tuple.Create(67, 35),
      Tuple.Create(24, 11),
      Tuple.Create(18, 99),
      Tuple.Create(31, 50),
      Tuple.Create(8, 80),
      Tuple.Create(12, 74),
      Tuple.Create(9, 39)
            };
            try
            {
                if (text.StartsWith("SibadiCTF{") && text.EndsWith("}") && Keycheck.Check(text, array))
                {
                    Console.WriteLine("Correct");
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    Console.Read();
                }
            }
            catch
            {
                Console.WriteLine("Incorrect");
                Console.Read();
            }
        }
    }

    internal static class Keycheck
    {
        public static bool Check(string key, Tuple<int, int>[] codedKey)
        {
            int num = 10;
            foreach (Tuple<int, int> tuple in codedKey)
            {
                String decode = Keycheck.DecoderElement(tuple.Item1, tuple.Item2).ToString();
                if (!(decode == key[num].ToString()))
                {
                    return false;
                }
                num++;
            }
            return true;
        }

        private static int DecoderElement(int a, int b)
        {
            while (b != 0)
            {
                int num = a % b;
                a = b;
                b = num;
            }
            return a;
        }
    }
}