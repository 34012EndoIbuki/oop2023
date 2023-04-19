using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form{

        private Timer moveTimer;    //タイマー用
        private SoccerBall soccerBall;
        private PictureBox pb;

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {
            this.Size = new Size(800,600);
            this.BackColor = Color.Green;
            this.Text = "BallGame";

            //ボールインスタンス生成
            soccerBall = new SoccerBall();
            pb = new PictureBox();   //画像を表示するコントロール
            pb.Image = soccerBall.Image;    //画像にサッカーボールのイメージをセット
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);    //画像の位置
            pb.Size = new Size(50, 50); //画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;

            moveTimer = new Timer();
            moveTimer.Interval = 1; //ミリ単位  インターバル(ms)
            moveTimer.Start();  //タイマースタート
            moveTimer.Tick += MoveTimer_Tick;   //MoveTimer_Tickをtabして召喚↓
        }

        void MoveTimer_Tick(object sender, EventArgs e) {
            int count = 0;
            count++;
            soccerBall.Move();
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
        }
    }
}
