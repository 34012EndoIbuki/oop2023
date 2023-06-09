﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;  //
            //マスク処理
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

            CarReports.Add(repo);
            Clear();
        }

        //追加を押した際にクリアする処理
        public void Clear() {
            var repo = new CarReport();
            //repo.Date = dttpDate.Value;
            cbAuthor.Text = null;
            //getSlectedMaker();
            cbCarName.Text = null;
            tbReport.Text = null;
            ofdImageFileOpen.Image = null;
            dgvCarReports.CurrentCell = null;


        }

        //削除
        private void btDereteReport_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in dgvCarReports.SelectedRows) {
                dgvCarReports.Rows.Remove(item);
            }

            //先生ver
            //CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);


        }

        //修正ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {
            //理想は必要に応じて修正ボタンを押せないようにするForm1_Load(マスク処理)
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
                    break;
                case CarReport.MakerGroup.日産:
                    break;
                case CarReport.MakerGroup.ホンダ:
                    break;
                case CarReport.MakerGroup.輸入車:
                    break;
                case CarReport.MakerGroup.スバル:
                    break;
                case CarReport.MakerGroup.スズキ:
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    break;
                case CarReport.MakerGroup.その他:
                    break;
                default:
                    break;
            }
        }




        //画像表示
        private void pbOpenImage_Click(object sender, EventArgs e) {
            ofdOpenImageFile.ShowDialog();
            ofdImageFileOpen.Image = Image.FromFile(ofdOpenImageFile.FileName);
        }

        //画像削除
        private void pbDeleteImage_Click(object sender, EventArgs e) {
            ofdImageFileOpen.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
            btModifyReport.Enabled = false;     //マスクする
            tsInfoText.Text = "ここにメッセージを表示できます";
        }


        //dgvの行を選択
        private void dgvCarReports_Click_1(object sender, EventArgs e) {
            dttpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value; //DateTime型にキャスト
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            ofdImageFileOpen.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }





        //終了メニュー選択時のイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();    //モーダルダイアログとして表示
        }
    }
}
