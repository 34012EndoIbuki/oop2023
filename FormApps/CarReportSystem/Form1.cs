using CarReportSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private int mode;

        //設定情報保存
        Settings settingss = new Settings();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;  //
        }

        //ステータスラベルのテキスト表示・非表示（引数なしはメッセージ非表示）
        private void statasLabelDisp(string msg = "") {
            //MessageBox.Show(msg);     //ポップアップ表示
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            statasLabelDisp();   //string msg = ""にすると("")はなくてもいい 
            if (cbAuthor.Text == ""){   //if(cbAuther.Text.Epuals("")でも可
                statasLabelDisp("記録者を入力してください");    //tsInfoText.Text = "記録者を入力してください";
                return;
            }else if(cbCarName.Text == "") {
                statasLabelDisp("車名を入力してください"); //tsInfoText.Text = "車名を入力してください";
                return;
            }

            var repo = new CarReport();
            repo.Date = dttpDate.Value;
            repo.Author = cbAuthor.Text;
            repo.Maker = getSlectedMaker();
            repo.CarName = cbCarName.Text;
            repo.Report = tbReport.Text;
            repo.CarImage = ofdImageFileOpen.Image;

            //記録者コンボボックス履歴登録処理
            if (!cbAuthor.Items.Contains(cbAuthor.Text)) {
                cbAuthor.Items.Add(cbAuthor.Text);
            }
            //車名コンボボックス履歴登録処理
            if (!cbCarName.Items.Contains(cbCarName.Text)) {
                cbCarName.Items.Add(cbCarName.Text);
            }

            //↑先生ver
            /*setCbAuther(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
            private void setCbAuther(string author) {
                if (!cbAuthor.Items.Contains(author)) {
                    cbAuthor.Items.Add(author);
                }
            }
            private void setCbCarName(string carname) {
                if (!cbCarName.Items.Contains(carname)) {
                    cbCarName.Items.Add(carname);
                }
            }*/

            CarReports.Add(repo);
            Clear();
        }

        //追加を押した際にクリアする処理
        public void Clear() {
            var repo = new CarReport();
            //repo.Date = dttpDate.Value;
            cbAuthor.Text = null;
            setSelectedMaker(CarReport.MakerGroup.その他);
            cbCarName.Text = null;
            tbReport.Text = null;
            ofdImageFileOpen.Image = null;
            dgvCarReports.CurrentCell = null;


        }

        //削除
        private void btDereteReport_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in dgvCarReports.SelectedRows) {
                dgvCarReports.Rows.Remove(item);
                dttpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value; //DateTime型にキャスト
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                ofdImageFileOpen.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
            }

            //先生ver
            //CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);

            if (dgvCarReports.Rows.Count == 0) {
                btModifyReport.Enabled = false;
                btDereteReport.Enabled = false;
            }

            


        }

        //修正ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {
            
            if (dgvCarReports.Rows.Count == 0) {
                return;
            }  //0だったらreturn
            CarReports[dgvCarReports.CurrentRow.Index].Date = dttpDate.Value;
            CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Maker = getSlectedMaker();
            CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
            dgvCarReports.Refresh();    //一覧更新

        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSlectedMaker() {

            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked == true) {  //trueは省略可
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;



            /* if (rbToyota.Checked) {
                 return CarReport.MakerGroup.トヨタ;
             } else if (rbNissan.Checked) {
                 return CarReport.MakerGroup.日産;
             } else if (rbHonda.Checked) {
                 return CarReport.MakerGroup.ホンダ;
             } else if (rbImported.Checked) {
                 return CarReport.MakerGroup.輸入車;
             } else if (rbSubaru.Checked) {
                 return CarReport.MakerGroup.スバル;
             } else if (rbSuzuki.Checked) {
                 return CarReport.MakerGroup.スズキ;
             } else if (rbDaihatu.Checked) {
                 return CarReport.MakerGroup.ダイハツ;
             } 
             return CarReport.MakerGroup.その他;*/
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatu.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }




        //画像表示
        private void pbOpenImage_Click(object sender, EventArgs e) {
            if(ofdOpenImageFile.ShowDialog() == DialogResult.OK) {
                ofdImageFileOpen.Image = Image.FromFile(ofdOpenImageFile.FileName);
            }
        }

        //画像削除
        private void pbDeleteImage_Click(object sender, EventArgs e) {
            ofdImageFileOpen.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            //理想は必要に応じて修正ボタンを押せないようにするForm1_Load(マスク処理)
            /*if(dgvCarReports.RowEnter) {
                btModifyReport.Enabled = false;     //マスクする
                btDereteReport.Enabled = false;
            }*/
            btModifyReport.Enabled = false;     //マスクする
            btDereteReport.Enabled = false;
            tsInfoText.Text = "ここにメッセージを表示できます";
        }


        //dgvの行を選択
        private void dgvCarReports_Click_1(object sender, EventArgs e) {
            btModifyReport.Enabled = true;
            btDereteReport.Enabled = true;
            if (0 < dgvCarReports.RowCount) {
                dttpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value; //DateTime型にキャスト
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                ofdImageFileOpen.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
            }
        }





        //終了メニュー選択時のイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイアログとして表示
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if(cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settingss.MainFormColor = cdColor.Color.ToArgb();
            }
            /*cdColor.ShowDialog();
            BackColor = cdColor.Color;*/
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            //画像の大きさをPictureBoxに合わせる
            //ofdImageFileOpen.SizeMode = PictureBoxSizeMode.StretchImage;
            mode = mode < 4 ? ((mode == 1) ? 3 : ++mode) : 0;   //AutoSize(2)を除外
            //ofdImageFileOpen.SizeMode = mode < PictureBoxSizeMode.Zoom ? ((mode == PictureBoxSizeMode.StretchImage) ? PictureBoxSizeMode.CenterImage : ++mode) : PictureBoxSizeMode.Normal;   //AutoSize(2)を除外
            /*if(mode > 4) {
                mode = 0;
            }*/
            ofdImageFileOpen.SizeMode = (PictureBoxSizeMode)mode;
            mode++;


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルのシリアル化
            var novel = new Settings {
                MainFormColor = cdColor.Color.ToArgb()
            };
            using(var set = XmlWriter.Create("Settings.xml")) {
                var serializer = new XmlSerializer(novel.GetType());
                serializer.Serialize(set,novel);
            }
        }
    }
}
