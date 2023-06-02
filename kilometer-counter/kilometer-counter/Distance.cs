using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kilometer_counter {
    public class Distance {
        public Distance(int route, int start, int finish, int kilometers) {
            this.Route = route;
            this.Start = start;
            this.Finish = finish;
            this.Kilometers = kilometers;
        }

        public int Route { get; set; }
        public int Start { get; set; }
        public int Finish { get; set; }
        public int Kilometers { get; set; }
    }
}
