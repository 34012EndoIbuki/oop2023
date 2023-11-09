using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class KilogramUnit : DistanceUnit {
        private static List<KilogramUnit> units = new List<KilogramUnit> {
            new KilogramUnit{Name = "mg",Coefficient = 1 / 1000,},
            new KilogramUnit{Name = "g",Coefficient = 1,},
            new KilogramUnit{Name = "kg",Coefficient = 1000,},
            new KilogramUnit{Name = "t",Coefficient = 1000 * 1000,},
        };

        public static ICollection<KilogramUnit> Units { get { return units; } }

        public double FromMetricUnit(PondUnit unit, double value) {
            return (value * unit.Coefficient) * 0.06479891 / this.Coefficient;
        }
    }
}
