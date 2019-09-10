using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBatchEmerytura //bez interakcji
{
    class Program
    {

        const int wiekEmerytalny = 65; //najlepiej utworzyć plik konfiguracyjny dla zmiennych

        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja EMERYTURA"); //cw i 2x tab

            if(args.Length !=2) //!- różne, sprawdzamy ilość argumentów - w tym zadaniu muszą być 2 argumenty
            {
                Console.WriteLine("Brak danych. Koniec");
                return; //wychodzimy z 'Main'
            }

            string imie = args[0];
            Console.WriteLine($"Witaj {imie}");


            int wiek = int.Parse(args[1]);
            if (wiek < wiekEmerytalny)
            {
                Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury");
            }
            else
            {
                Console.WriteLine("Jesteś emerytem");
            }
            Console.ReadKey(); //oczekuje na naciśnięcie dowolnego klawisza -> ctrl + F5 uruchamia bez debugowania i daje podobny efekt
        }
    }
}

