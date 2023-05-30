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
                /*if (2001 <= Year || Year <= 2100) {
                    return true;
                } else {
                    return false;
                }*/
            }
            
        }


        #endregion



    }
}
