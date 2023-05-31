using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {


        #region 4.1.1
        /*       private int year;
               private int month;

               public int Year {
                   set { this.year = value; }
                   get { return this.year; }
               }

               public int Month {
                   set { this.month = value; }
                   get { return this.month; }
               }*/

        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }
        #endregion

        #region 4.1.2

        public bool Is21Century {
            get {
                return (2001 <= Year && Year <= 2100);
                /*if (2001 <= Year && Year <= 2100) {
                    return true;
                } lse;else {
                    return fa
                }*/
            }
            
        }


        #endregion

        #region 4.1.3

        public YearMonth AddOneMonth() {
            if(Month == 12) {
                return new YearMonth(Year + 1, 1);
            } else {
                return new YearMonth(Year, Month + 1);
            }
            
            //return new YearMonth(Month == 12 ? Year + 1 : Year,Month == 12 ? 1 : Month + 1);
        }

        #endregion

        #region 4.1.4

        public override string ToString() {
            return Year + "年" + Month + "月";
        }

        #endregion





    }
}
