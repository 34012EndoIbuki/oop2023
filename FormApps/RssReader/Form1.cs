using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using(var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);   //Xmlデータ取得
                var nodes = xdoc.Root.Descendants("item").Select(x => new ItemData {Title =  };
                foreach (var title in nodes) {
                    //title.ReplaceAll("title", " ");
                    lbRssTitle.Items.Add(title.Value);
                }

            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
