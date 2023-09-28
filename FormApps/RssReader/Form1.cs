using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);   //Xmlデータ取得
                var nodes = xdoc.Root.Descendants("item").Select(x => new ItemData { Title = (string)x.Element("title") });  //型がstringで認識されていないので(string)でstring型に明示的にキャストする
                foreach (var title in nodes) {
                    //title.ReplaceAll("title", " ");
                    //lbRssTitle.Items.Add(title.Value);]
                    lbRssTitle.Items.Add(title.Title);
                }

            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);   //Xmlデータ取得
                var nodes = xdoc.Root.Descendants("item").Where(a => lbRssTitle.SelectedItem = a.Element("title"))
                wbBrowser.Navigate((Uri)nodes);
            }
        }
    }
}
