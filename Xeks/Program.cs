using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("давай выберай нахуй: ");
            a = Convert.ToInt32(Console.ReadLine());
            if ( a == 1 )
            {
                Console.WriteLine("Введите текст для шифровки");
                string text = Console.ReadLine();
                string hex = "";
                foreach (char c in text)
                {
                    int tmp = c;
                    hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
                }
                Console.WriteLine("Шифровка: " + hex);
                Console.ReadKey();
            } else if ( a == 2 )
            {
                string hex = Console.ReadLine();
                string str = "";
                for (int i = 0; i < hex.Length; i += 2)
                {
                    string hs = "";
                    hs = hex.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    str += character;
                }
                Console.WriteLine("Дешифровка: " + str);
                Console.ReadKey();
            }

        }
    }
}