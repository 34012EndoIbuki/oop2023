using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        BindingList<ItemData> bdl = new BindingList<ItemData>();
        //BindingList<urldb> bdl2 = new BindingList<urldb>();
        List<string> CheckURL = new List<string>();
        List<string> CheckName = new List<string>();

        public Form1() {
            InitializeComponent();
            dgvUrl.DataSource = bdl;
            //dgvUrl.DataSource = bdl2;
            

        }

        private void Form1_Load(object sender, EventArgs e) {
            tsInfoText.Text = "";   //情報表示領域のテキストを初期化
            bdl.Add(new ItemData { Title = "IT", Link = "https://news.yahoo.co.jp/rss/categories/it.xml"});
            bdl.Add(new ItemData { Title = "Anime", Link = "https://news.yahoo.co.jp/rss/media/animage/all.xml" });
            bdl.Add(new ItemData { Title = "Otaku", Link = "https://news.yahoo.co.jp/rss/media/otakulab/all.xml" });
            CheckURL.Add("https://news.yahoo.co.jp/rss/categories/it.xml");
            CheckURL.Add("https://news.yahoo.co.jp/rss/media/animage/all.xml");
            CheckURL.Add("https://news.yahoo.co.jp/rss/media/otakulab/all.xml");
            CheckName.Add("IT");
            CheckName.Add("Anime");
            CheckName.Add("Otaku");
            //dgvUrl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUrl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btGet_Click(object sender, EventArgs e) {
            if ((tbUrl.Text == "")) {
                MessageBox.Show("値が未入力です");
                return;
            }

            lbRssTitle.Items.Clear();   //リストボックスクリア

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

        private void statasLabelDisp(string msg = "") {
            //MessageBox.Show(msg);     //ポップアップ表示
            tsInfoText.Text = msg;
        }

        private void btAdd_Click(object sender, EventArgs e) {
            /*var addurl = new ItemData();
            addurl.Link = tbUrl.Text;

            ItemDatas.Add(addurl);
            dgvUrl.Columns[0].HeaderText = "URL";*/

            //DataGridViewLinkColumnの作成

            statasLabelDisp();
            if (tbUrl.Text == "") {
                MessageBox.Show("urlを入力してください");    //tsInfoText.Text = "記録者を入力してください";
                return;
            }

            if ((tbName.Text == "")) {
                MessageBox.Show("名前が未入力です");
                return;
            }

            if (dgvUrl.Columns.Contains(tbUrl.Text)) {
                Console.WriteLine("入力されたURLすでに存在します");
            }

            foreach(var str in CheckURL) {
                if(str == tbUrl.Text) {
                    MessageBox.Show("入力されたURLはすでに存在します");
                    return;
                }
            }

            foreach (var str in CheckName) {
                if (str == tbName.Text) {
                    MessageBox.Show("入力された名前はすでに存在します");
                    return;
                }
            }

            CheckURL.Add(tbUrl.Text);
            CheckName.Add(tbName.Text);
            

            ItemData link = new ItemData();
            link.Title = tbName.Text;
            link.Link = tbUrl.Text;
            bdl.Add(link);
            dgvUrl.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUrl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            /*//DataGridViewLinkColumnの作成
            DataGridViewLinkColumn column = new DataGridViewLinkColumn();
            //列の名前を設定
            column.Name = "Link";
            //全てのリンクに"詳細閲覧"と表示する
            column.UseColumnTextForLinkValue = true;
            column.Text = "詳細閲覧";
            //マウスポインタがリンク上にあるときだけ下線をつける
            column.LinkBehavior = LinkBehavior.HoverUnderline;
            //自動的に訪問済みになるようにする
            //デフォルトでTrue
            column.TrackVisitedState = true;
            //DataGridViewに追加する
            //dgvUrl.Columns.Add(column);

            urldb link = new urldb();
            link.Title = "c1";
            link.Link = column;
            bdl2.Add(link);*/

        }

        private void dgvUrl_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            tbUrl.Text = dgvUrl.CurrentRow.Cells[1].Value.ToString();
            tbName.Text = dgvUrl.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvUrl_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            tbUrl.Text = dgvUrl.CurrentRow.Cells[1].Value.ToString();
            tbName.Text = dgvUrl.CurrentRow.Cells[0].Value.ToString();

            lbRssTitle.Items.Clear();   //リストボックスクリア

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
    }
}
