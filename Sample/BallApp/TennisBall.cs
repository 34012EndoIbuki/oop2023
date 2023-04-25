using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class TennisBall : Obj {    //Objを継承

        //フィールド

        private static int count; //インスタンスの個数　サッカーボールの数

        Random random = new Random();   //乱数インスタンス

        //プロパティ
        public static int Count { get => count; set => count = value; }


        //コンストラクタ
        public TennisBall (double xp, double yp)
            :base(xp, yp, @"pic\tennis_ball.png") {

            int rndX = random.Next(-25, 25);
            MoveX = (rndX != 0 ? rndX : 1); //乱数で移動量を設定

            int rndY = random.Next(-25, 25);
            MoveY = (rndY != 0 ? rndY : 1); //乱数で移動量を設定

            Count++;
        }

        //抽象クラスの実装
        public override void Move() {
            //throw new NotImplementedException();

            Console.WriteLine("Ｘ座標 = {0}, Ｙ座標 = {1}", PosX, PosY);

            if (PosY > 600 || PosY < 0)
            {
                MoveY = -MoveY;
            }

            if (PosX > 800 || PosX < 0)
            {
                MoveX = -MoveX;
            }
            PosX += MoveX;
            PosY += MoveY;
        
         }
    }
}
