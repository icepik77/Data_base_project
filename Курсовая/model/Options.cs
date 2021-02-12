using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовой_проект.model
{
    public class Options
    {
        
        public Guid id;
        public double D1, D2, D_medium, N, n1, U, b, delta_belt, n2, gear_ratio, k_sliding, L, a, speed_freequency, B, a_infinity, arrow, a1, y1, lambda, delta;
        public string type_belt = "";
        public string material_belt = "";
        public string Type_frequency = "";
        public string Type_L = "";
        public string Type_D1 = "";
        public int quantity_padding = 0;
        public string layers = "";
 
    }
}
