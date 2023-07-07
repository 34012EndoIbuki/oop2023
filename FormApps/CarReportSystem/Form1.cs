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
            repo.Author = cbAuthor.ToString();
            //repo.Maker = dttpDate.Value;
            repo.CarName = cbCarName.ToString();
            repo.Report = tbReport.ToString();
            //repo.CarImage = dttpDate.Value;


            CarReports.Add(repo);
        }

        private CarReport.MakerGroup getSlectedMaker() {
            return CarReport.MakerGroup.トヨタ;
        }
    }
}
