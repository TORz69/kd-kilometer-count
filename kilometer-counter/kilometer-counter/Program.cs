using System;
using System.Diagnostics;
using System.Xml;

namespace kilometer_counter {
    public class Program {

        public static void Main(string[] args) {
            Repository repository = new Repository();
            OutputController oc = new OutputController();

            Console.WriteLine("Dostepne linie: D1, D3, D4, D5, D6, D7, D8, D9, D10, D11, D13, D15, D16, D19, D21, D25, D26, D28" +
                "D29, D70, D92");
            Console.Write("Wybierz linie: D...");

            int route = Convert.ToInt32(Console.ReadLine());

            if (route != 1 && route != 3 && route != 4 && route != 5 && route != 6 && route != 7 && route != 8 && 
                route != 9 && route != 10 && route != 11 && route != 13 && route != 15 && route != 16 && route != 19 
                && route != 21 && route != 25 && route != 26 && route != 28 && route != 29 && route != 70 && route != 92) {
                Console.WriteLine("Nie ma takiej linii. Program konczy dzialanie");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write("Wybierz przystanek poczatkowy: ");
            int start = 0;

            oc.printChoice(route);
            
            Console.Write("Wybor: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wybierz przystanek koncowy: ");
            int end = 0;

            oc.printChoice(route);

            Console.Write("Wybor: ");
            end = Convert.ToInt32(Console.ReadLine());

            if (start == end) {
                Console.WriteLine("Przystanek poczatkowy i koncowy nie moga byc takie same. Program konczy dzialanie");
                Console.ReadKey();
                Environment.Exit(0);
            }

            int distance = repository.getDistance(route, start, end);
            Console.WriteLine($"Dystans: {distance}km");
            Console.WriteLine("Jeszcze raz? (t/n)");
            string again = Console.ReadLine();

            if (again == "t") {
                Process.Start("kilometer-counter.exe");
            }
        }
    }
}
