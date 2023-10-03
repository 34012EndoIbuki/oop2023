using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        //取得データ保存用
        List<ItemData> ItemDatas = new List<ItemData>();    //二つのデータを持つ

        public Form1() {
            InitializeComponent();
            
        }

        private void btGet_Click(object sender, EventArgs e) {
            if ((tbUrl.Text == "")) {
                MessageBox.Show("値が未入力です");
                return;
            }
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);   //Xmlデータ取得
                ItemDatas = xdoc.Root.Descendants("item")
                    .Select(x => new ItemData {
                        Title = (string)x.Element("title"),     //titleとlinkを取得
                        Link = (string)x.Element("link")
                    }).ToList();  //型がstringで認識されていないので(string)でstring型に明示的にキャストする
                foreach (var title in ItemDatas) {
                    //title.ReplaceAll("title", " ");
                    //lbRssTitle.Items.Add(title.Value);]
                    lbRssTitle.Items.Add(title.Title);
                }

            }
        }

        /*private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);   //Xmlデータ取得
                //var nodes = xdoc.Root.Descendants("item").Select(x => new ItemData { Title = (string)x.Element("link") });//Where(a => lbRssTitle.SelectedItem = a.Element("title"))
                var nodes = xdoc.Root.Descendants("item").Elements("link").Select(x => x.Elements("title") == lbRssTitle.Items);
                //System.Diagnostics.Process.Start(nodes);
                OpenUrl(nodes);
            }
        }
        private Process OpenUrl(string nodes) {
            ProcessStartInfo pi = new ProcessStartInfo() {
                FileName = nodes,
                UseShellExecute = true,
            };

            return Process.Start(pi);
        }*/

        private void lbRssTitle_Click(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex == -1) {
                return;
            }
            wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
        }

        private void tbUrl_TextChanged(object sender, EventArgs e) {
            
        }
    }
}
