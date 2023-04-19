using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {

        private Image image;    //画像データ
        
        private double posX;    //x座標
        private double posY;    //y座標

        private double moveX = 10;  //xの移動量
        private double moveY = 10;//Program.MoveTimer_Tick.count;  //yの移動量

        //コンストラクタ
        public SoccerBall() {
            image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = 0.0;
            PosY = 0.0;
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //メソッド
        public void Move() {

            Console.WriteLine("X座標 = {0},Y座標 = {1}", posX, posY);

            if (0 > posX || posX > 800)
            {
                moveX = -moveX;
            }
            if(0 > posY || posY > 600)
            {
                moveY = -moveY;
            }
            posX += moveX;
            posY += moveY;

            
            
        }

    }
}
