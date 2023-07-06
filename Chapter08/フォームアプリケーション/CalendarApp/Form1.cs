using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class btPMonth : Form {
        public DateTime now = DateTime.Now;

        public btPMonth() {
            InitializeComponent();
            timeText.Text = now.ToString();
        }

        private void btDayCalc_Click(object sender, EventArgs e) {
            var dtp = dtpDate.Value;

            var now = DateTime.Now;

            tbMessage.Text = "今日から" + (now - dtp).Days + "日経過";
        }

        private void Form1() {

        }

        private void btMDay_Click(object sender, EventArgs e) {
            //tbMessage.Text = now.AddDays(-1).ToString();
            //先生  tbMessage.Text = dtpDate.Value.AddYears(1);
            //      tbMessage.Text = dtpDate.Value.ToShortDateString();
        }

        private void btAge_Click(object sender, EventArgs e) {
            var age = GetAge(dtpDate.Value, DateTime.Now);
            tbMessage.Text = "貴方の年齢は" + age + "歳です";
        }
        public static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        //タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            timeText.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd) HH時mm分ss秒");
        }

    }
}