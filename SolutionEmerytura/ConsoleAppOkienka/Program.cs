using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic; //dołączamy nowy język 

namespace ConsoleAppOkienka
{
    class Program
    {

        const int wiekEmerytalny = 67; //najlepiej utworzyć plik konfiguracyjny dla zmiennych

        static void Main(string[] args)
        {
            Interaction.MsgBox("Aplikacja EMERYTURA"); // polecenia właściwe dla VisualBasic. C# nie ma okienek.
            
            string imie = Interaction.InputBox("Podaj imię"); ;
            Console.WriteLine($"Witaj {imie}");

            Console.WriteLine("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            if (wiek < wiekEmerytalny)
            {
                Console.WriteLine($"Zostało Ci {wiekEmerytalny - wiek} lat do emerytury");
            }
            else
            {
                Console.WriteLine("Jesteś emerytem");
            }
            //Console.ReadKey(); //oczekuje na naciśnięcie dowolnego klawisza -> ctrl + F5 uruchamia bez debugowania i daje podobny efekt
        }
    }
}
