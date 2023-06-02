using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kilometer_counter {
    public class Repository {
        public ObservableCollection<Distance> distances = new ObservableCollection<Distance>();

        public int getDistance(int route, int start, int end) {
            return distances.Where(x => x.Route == route && x.Start == start && x.Finish == end).Select(x => x.Kilometers).FirstOrDefault();
        }

        public Repository() {
            // D1 - 1. Wrocław Główny, 2. Legnica, 3. Chojnów, 4. Węgliniec, 5. Lubań Śląski
            
        }

        
    }
}
