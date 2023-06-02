using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kilometer_counter {
    public class OutputController {
        public OutputController() {
            //ctor
        }

        public void printChoice(int route) {
            switch (route) {
                case 1: Console.WriteLine("1. Wroclaw Glowny, 2. Legnica, 3. Chojnow, 4. Wegliniec, 5. Luban Slaski"); break;
                case 3: Console.WriteLine("1. Wroclaw Glowny, 2. Wroclaw Mikolajow, 3. Rawicz"); break;
                case 4: Console.WriteLine("1. Wroclaw Glowny, 2. Swidnica Miasto"); break;
                case 5:
                    Console.WriteLine("1. Legnica, 2. Jawor, 3. Jaworzyna Slaska, 4. Swidnica Miasto, 5. Dzierzoniow Slaski" +
                    "6. Kamieniec Zabkowicki, 7. Klodzko Miasto, 8. Kudowa-Zdroj"); break;
                case 6:
                    Console.WriteLine("1. Wroclaw Glowny, 2. Katy Wroclawskie, 3. Jaworzyna Slaska, 4. Walbrzych Glowny, 5. Sedzislaw" +
                    "6. Jelenia Gora, 7. Jelenia Gora Zabobrze, 8. Szklarska Poreba Gorna"); break;
                case 7:
                    Console.WriteLine("1. Krotoszyn, 2. Milicz, 3. Olesnica, 4. Wroclaw Mikolajow, 5. Wroclaw Glowny" +
                    "6. Jelcz-Laskowice"); break;
                case 8: Console.WriteLine("1. Wroclaw Glowny, 2. Wroclaw Mikolajow, 3. Trzebnica"); break;
                case 9: Console.WriteLine("1. Wroclaw Glowny, 2. Ziebice, 3. Klodzko Miasto, 4. Miedzylesie, 5. Lichkov"); break;
                case 10: Console.WriteLine("1. Wroclaw Glowny, 2. Legnica, 3. Chojnow, 4. Wegliniec, 5. Zgorzelec, 6. Goerlitz"); break;
                case 11: Console.WriteLine("1. Wroclaw Glowny, 2. Legnica, 3. Lubin, 4. Glogow"); break;
                case 13: Console.WriteLine("1. Legnica, 2. Chojnow, 3. Rokitki, 4. Chocianow"); break;
                case 15: Console.WriteLine("1. Walbrzych Miasto, 2. Walbrzych Glowny, 3. Jedlina-Zdroj, 4. Klodzko Miasto, 5. Kudowa-Zdroj"); break;
                case 16: Console.WriteLine("1. Wroclaw Glowny, 2. Jaworzyna Slaska, 3. Swidnica Miasto, 4. Dzierzoniow Slaski, 5. Bielawa Zachodnia"); break;
                case 19: Console.WriteLine("1. Jelenia Gora, 2. Jelenia Gora Zabobrze, 3. Luban Slaski, 4. Zgorzelec, 5. Goerlitz"); break;
                case 21: Console.WriteLine("1. Szklarska Poreba Gorna, 2. Polana Jakuszycka, 3. Harrachov"); break;
                case 25: Console.WriteLine("1. Wroclaw Glowny, 2. Legnica, 3. Chojnow, 4. Rokitki, 5. Zary, 6. Zagan, 7. Forst"); break;
                case 26: Console.WriteLine("1. Sedzislaw, 2. Kralovec"); break;
                case 28: Console.WriteLine("1. Wroclaw Glowny, 2. Jaworzyna Slaska, 3. Walbrzych Glowny, 4. Mezimesti"); break;
                case 29: Console.WriteLine("1. Wroclaw Glowny, 2. Kamieniec Zabkowicki, 3. Klodzko Miasto, 4. Kudowa-Zdroj"); break;
                case 70: Console.WriteLine("1. Wroclaw Glowny, 2. Wroclaw Mikolajow, 3. Jelcz-Laskowice"); break;
                case 92: Console.WriteLine("1. Klodzko Glowne, 2. Klodzko Miasto, 3. Stronie Slaskie"); break;
                default: Console.WriteLine("Wrong choice"); break;
            }
        }

    }
}
