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

        private void Form1_Load(object sender, EventArgs e) {
            tsInfoText.Text = "";   //情報表示領域のテキストを初期化
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

        private void btAdd_Click(object sender, EventArgs e) {
            /*var addurl = new ItemData();
            addurl.Link = tbUrl.Text;

            ItemDatas.Add(addurl);
            dgvUrl.Columns[0].HeaderText = "URL";*/

            //DataGridViewLinkColumnの作成

            statasLabelDisp();
            if(tbUrl == null) {
                statasLabelDisp("urlを入力してください");    //tsInfoText.Text = "記録者を入力してください";
                return;
            }

            DataTable table = new DataTable("Table");
            table.Rows.Add("髪");
            dgvUrl.DataSource = table;


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
            dgvUrl.Columns.Add(column);
        }

        private void dgvUrl_CellClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView dgv = (DataGridView)sender;
            //"Link"列ボタンクリック
            if (dgv.Columns[e.ColumnIndex].Name == "Link") {
                MessageBox.Show(e.RowIndex.ToString() +
                "行リンククリック。");
                //訪問済み
                DataGridViewLinkCell cell =
                (DataGridViewLinkCell)dgv[e.ColumnIndex, e.RowIndex];
                cell.LinkVisited = true;
            }
        }

        private void statasLabelDisp_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            //MessageBox.Show(msg);     //ポップアップ表示
            tsInfoText.Text = msg;
        }

    }
}
