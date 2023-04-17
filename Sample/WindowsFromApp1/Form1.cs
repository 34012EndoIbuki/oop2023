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

        private void Button1_Click(object sender, EventArgs e) {
            int ans = int.Parse(tbNum.Text) + int.Parse(tbNum2.Text);
            tbAns.Text = ans.ToString();

        }

        private void From1_Load(object sender, EventArgs e) {

        }
    }
}
