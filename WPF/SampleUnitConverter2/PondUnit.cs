using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter2 {
    public class PondUnit : DistanceUnit {
        private static List<PondUnit> units = new List<PondUnit> {
            new PondUnit{Name = "gr",Coefficient = 1,},
            new PondUnit{Name = "oz",Coefficient = 437.5,},
            new PondUnit{Name = "lb",Coefficient = 437.5 * 16,},
            new PondUnit{Name = "st",Coefficient = 437.5 * 16 * 14,},
        };

        public static ICollection<PondUnit> Units { get { return units; } }

        public double FromKilogramUnit(KilogramUnit unit, double value) {
            //return (value * unit.Coefficient) / 0.06479891 / this.Coefficient;
            return (value * unit.Coefficient) / 64.79891 / this.Coefficient;
        }
    }
}
