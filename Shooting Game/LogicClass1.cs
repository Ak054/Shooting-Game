using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_Game
{
    
    class LogicClass1
    {

        public int Bullet;
        public int Score = 0;
        public int ShootAwayGoals = 3;
        public int ShootAHeadGoals = 6;

        public void Load()
        {
            Bullet = 0;
        }
        //SPining gun
        public void Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 5);
        }
        //Now the coding of ShootAHead
        public void ShootAHead()
        {
            if(Bullet == 4)
            {
                MessageBox.Show("You Die");
                Score -= 10;
            }
            else
            {
                MessageBox.Show("Start Playing");
                Bullet++;
            }
        }
        //Now the Function of ShootAway
        public void ShootAway()
        {
            ShootAwayGoals--;
            if(ShootAwayGoals == 0)
            {
                MessageBox.Show("you lose");
            }
            else
            {
                if(Bullet ==4)
                {
                    MessageBox.Show("You are save");
                    Score += 20;
                }
                else { MessageBox.Show("Start Playing");
                    Bullet++;

                }
            }
        }
    }
}
