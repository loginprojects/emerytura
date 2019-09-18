using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Program
    {
        /*
        
Utwórz listę elementów typu string reprezentującą zwyczajowe nazwy gatunków zwierząt (np. kot, pies, ...).
Dodaj do niej co najmniej 5 elementów.
Wydrukuj zawartość listy na konsoli.
Usuń z listy element ostatni oraz element drugi.
Ponownie wydrukuj zawartość listy na konsoli.
Wstaw na koniec listy element mucha.
Wstaw na pozycji 1 element gazela.
Ponownie wydrukuj zawartość listy na konsoli.
Usuń z listy element gazela.
Ponownie wydrukuj zawartość listy na konsoli.
Wypisz na konsoli true jeśli element krowa jest na liście, w przeciwnym przypadku wypisz false.
Wypisz na konsoli indeks elementu mucha.
Odwróć kolejność elementów na liście i wypisz ma konsoli zawartość listy.
Posortuj listę w kolejności rosnącej i wypisz ją. Wykorzystamy domyślny sposób porównywania napisów.
Posortuj listę w kolejności malejącej i wypisz ją. Wskazówka: argumentem metody sortującej będzie obiekt typu Comparison<string>, czyli funkcja porównująca: (x,y) => y.CompareTo(x).
Dodatkowe: Posortuj listę w kolejności od najkrótszego do najdłuższego napisu. Jeśli napisy są tej samej długości, przyjmij naturalny porządek zdefiniowany w typie string.
         
             */
        static void PiszListe<T>(List<T> lista)
        {
            foreach (var x in lista)
                Console.Write(x + ", ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<string> zwierzaki; //nie ma listy jeszcze, jest tylko deklaracja
            zwierzaki = new List<string>(); //w nawiasie moglyby być elementy listy
            zwierzaki.Add("kot");
            zwierzaki.Add("pies");
            zwierzaki.AddRange(new string[] { "chomik", "anakonda", "tygrys" });

            Console.WriteLine(zwierzaki);
            foreach (var z in zwierzaki)
                Console.WriteLine(z);

            zwierzaki.RemoveAt(zwierzaki.Count - 1); //usuwa ostatni element
            zwierzaki.RemoveAt(1);

            PiszListe(zwierzaki);

            zwierzaki.Add("mucha");
            zwierzaki.Insert(1, "gazela");
            PiszListe(zwierzaki);
            zwierzaki.RemoveAll(x => x == "gazela");
            PiszListe(zwierzaki);

            if (zwierzaki.Contains("krowa"))
                Console.WriteLine(true);

            else
                Console.WriteLine(false);

            Console.WriteLine(zwierzaki.Contains("krowa") ? true : false);  // to samo co u góry z if
            Console.WriteLine(zwierzaki.Contains("krowa"));                 // najbardziej uproszczone, bo contains zwraca prawdę lub fałsz zatem nie ma potrzeby ustawiania warunków    

            Console.WriteLine(zwierzaki.FindIndex(x => x == "mucha"));

            //wypisuje listę w odwrotnym porządku

            zwierzaki.Reverse();
            PiszListe(zwierzaki);

            zwierzaki.Sort();
            PiszListe(zwierzaki);

            //zwierzaki.Sort((x, y) => x.CompareTo(y)); //sortowanie domyśle poprzez komparator = to co wyżej
            zwierzaki.Sort((x, y) => y.CompareTo(x));
            PiszListe(zwierzaki);

            zwierzaki.Sort((x, y) => x.Length - y.Length);
            PiszListe(zwierzaki);

        }
    }
}
