using System;
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
            dgvCarReports.DataSource = CarReports;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            var repo = new CarReport();
            repo.Date = dttpDate.Value;
            repo.Author = cbAuthor.Text;
            repo.Maker = getSlectedMaker();
            repo.CarName = cbCarName.Text;
            repo.Report = tbReport.Text;
            repo.CarImage = ofdImageFileOpen.Image;


            CarReports.Add(repo);
        }

        //追加
        private CarReport.MakerGroup getSlectedMaker() {

            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked == true) {  //trueは省略可
                    return (CarReport.MakerGroup)((RadioButton)item).Tag;
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

        //削除
        private void btDereteReport_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in dgvCarReports.SelectedRows) {
                dgvCarReports.Rows.Remove(item);
            }

            
        }

        
        //画像表示
        private void pbOpenImage_Click(object sender, EventArgs e) {
            ofdOpenImageFile.ShowDialog();
            ofdImageFileOpen.Image = Image.FromFile(ofdOpenImageFile.FileName);
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;   //画像項目非表示
        }
    }
}
