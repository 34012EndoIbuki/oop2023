using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {

        Bar bar;    //  Barインスタンス格納
        PictureBox pbBar;   //Bar表示用

        private Timer moveTimer;    //タイマー用
        private SoccerBall soccerBall;
        private TennisBall tennisBall;
        private PictureBox pb;
            
        private List<Obj> obj = new List<Obj>();    //ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();      //表示用

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {

            //フォーム
            this.Size = new Size(800, 600);
            this.BackColor = Color.Green;
            
            this.Text = "BallGame";

            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;



            //BARインスタンス生成
            bar = new Bar(350, 400);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY); //画像の位置
            pbBar.Size = new Size(150, 10); //画像の表示サイズ
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pbBar.Parent = this;


            moveTimer = new Timer();
            moveTimer.Interval = 10; //タイマーのインターバル（ms）
            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録
        }

        //キーが押されたときのイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);

        }

        //マウスクリック時のイベントハンドラ
/*        private void Program_MouseClick(object sender, MouseEventArgs e) {
            //ボールインスタンス生成
            soccerBall = new SoccerBall(e.X - 25, e.Y - 25);
            pb = new PictureBox();   //画像を表示するコントロール
            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);　//画像の位置
            pb.Size = new Size(50, 50); //画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;

            balls.Add(soccerBall);
            pbs.Add(pb);

            this.Text = "BallGame soccerball" + SoccerBall.Count +"tennisball"+ TennisBall.Count;

            moveTimer.Start();  //タイマースタート
        }
*/


        private void Program_MouseClick(object sender, MouseEventArgs e) {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    soccerBall = new SoccerBall(e.X - 25, e.Y - 25);
                    pb = new PictureBox();   //画像を表示するコントロール
                    pb.Image = soccerBall.Image;
                    pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY); //画像の位置
                    pb.Size = new Size(50, 50); //画像の表示サイズ
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
                    pb.Parent = this;

                    obj.Add(soccerBall);
                    pbs.Add(pb);

                    this.Text = "BallGame[SoccerBall:" + SoccerBall.Count + "TennisBall:" + TennisBall.Count;

                    moveTimer.Start();  //タイマースタート
                    break;

                case MouseButtons.Right:
                    tennisBall = new TennisBall(e.X - 25, e.Y - 25);
                    pb = new PictureBox();   //画像を表示するコントロール
                    pb.Image = tennisBall.Image;
                    pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY); //画像の位置
                    pb.Size = new Size(50, 50); //画像の表示サイズ
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
                    pb.Parent = this;

                    obj.Add(tennisBall);
                    pbs.Add(pb);

                    this.Text = "BallGame[SoccerBall:" + SoccerBall.Count + "TennisBall:" + TennisBall.Count;

                    moveTimer.Start();  //タイマースタート
                    break;
            }
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {

            for (int i = 0; i < obj.Count; i++)
            {
                obj[i].Move(pbBar,pbs[i]);  //移動
                pbs[i].Location = new Point((int)obj[i].PosX, (int)obj[i].PosY); //画像の位置
            }
        }

    }
}
