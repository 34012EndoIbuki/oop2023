using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFromApp1 {
    public partial class From1 : Form {
        public From1() {
            InitializeComponent();
        }

        private void btButton_Click(object sender, EventArgs e) {
            //int ans = int.Parse(tbNum.Text) + int.Parse(tbNum2.Text);
            //tbAns.Text = ans.ToString();
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();
        }
    }
}
