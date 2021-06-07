using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        static int BinaryGap(int number)
        {
            int tymczas = 0;
            int wynik = 0;
            string b = Convert.ToString(number, 2);

            for (int i = 0; i < b.Length; i++)
            {           
                             if (b[i] == '0')
                {
                    tymczas++;
                }
                else
                {
                    
                    if (wynik <= tymczas)
                    {
                        wynik = tymczas;
                     
                    }

                    tymczas = 0;
                }               
            }
            return wynik;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Dla liczby 1054 binarnie: " +Convert.ToString(1054,2) +" max sekwencja zer: " +  BinaryGap(1054) );
            Console.WriteLine("Dla liczby 100 binarnie: " + Convert.ToString(100, 2) + " max sekwencja zer: " + BinaryGap(100));
            Console.WriteLine("Dla liczby 64 binarnie: " + Convert.ToString(64, 2) + " max sekwencja zer:" + BinaryGap(64));

            Console.ReadKey();
        }
    }
}
