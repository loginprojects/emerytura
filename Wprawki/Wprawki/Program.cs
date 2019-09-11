using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wprawki
{
    class Program
    {
        static void Main1(string[] args)
        {
            int x = int.MaxValue;
            int y = 2;
            int z = x + y;
            Console.WriteLine(z);

            checked
            {
                z = x + y; //overflow
            }
        }

        static void Main2(string[] args)
        {
            double x = 0.1; // nieskończone rozwinięcie bitowe
            double y = 0.2;
            double z = 0.3;
            Console.WriteLine(x + y == z); //false
        }

        static void Main3(string[] args)
        {
            //float x = (float)0.1;   // rzutowanie, konwersja
            //double x = 0.01;        // dużo bardziej poprawnie
            decimal x = 0.01m;         // rekomendowane dla pieniędzy

            float y = 0.1f;         // litereł typu float

            decimal suma = 0;         // domyślna konwersja 0 -> 0.0

            for (int i = 1; i <= 1000000; i++)  //milion razy wykonaj - pętla z licznikiem 'i++' oznacza 'zwiększ o 1'
            {
                suma = suma + x;                // suma akumulacyjna
            }
            Console.WriteLine(suma);
        }

        static void Main4(string[] args)
        {
            char znak = 'a';
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine( (char)(znak + i) );
            }

            string napis = "a";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(napis + i);
            }
        }

        static void Main5(string[] args)
        {
            string napis = "ala ma kota";
            for (int i = napis.Length-1; i >=0; i--) // napis.Length dynamicznie daje ilość znaków. Pomniejszamy go o 1, żeby pętla nie wyszła poza zakres)
            {
                Console.Write(napis[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int x = -1, y = 5;
            int z = 0;
            int u = x;
            do
            {
                //z = z + y; //- to samo co poniżej
                z += y;
                //u = u - 1; //- to samo co poniżej
                u--;

            } while (u != 0);
            Console.WriteLine(z);

        }
    }
}
