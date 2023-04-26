using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {

        public Bar(double xp,double yp)
            :base(xp, yp,@"pic\bar.png"){
            base.MoveX = 10;
            base.MoveY = 0;
        }
        

        //抽象クラスを継承しているので、不要なメソッドは空にする
        public override void Move(PictureBox pbBar, PictureBox pbBall) {
            
        }

        public override void Move(Keys direction) {

            double movepoint;


            if (direction == Keys.Right)
            {
                PosX += 20;
                movepoint = PosX + 20;
                if (movepoint > 650)
                {
                    PosX = 650;
                }
            }
            else if (direction == Keys.Left)
            {
                PosX -= 20;
                movepoint = PosX - 20;
                if (movepoint < 0)
                {
                    PosX = 0;
                }
            }
            else if (direction == Keys.Up)
            {
                PosY -= 20;
                movepoint = PosY - 20;
                if (movepoint < 0)
                {
                    PosY = 0;
                }
            }
            else if (direction == Keys.Down)
            {
                PosY += 20;
                movepoint = PosY + 20;
                if (movepoint > 550)
                {
                    PosY = 550;
                }
            }
        }
    }
}
