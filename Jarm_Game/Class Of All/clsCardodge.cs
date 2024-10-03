using System;
using System.Drawing;
using System.Windows.Forms;

namespace Jarm_Game
{
    internal class clsCardodge
    {
        private int speed = 15;
        private int score = 0;

        public void Arrow_Key_Movement(bool right, bool left, Control Player) //Movement of the player
        {
            if (right)
            {
                if (Player.Top < 470)
                {
                    Player.Top += 30;
                }
            }
            if (left)
            {
                if (Player.Top > 77)
                {
                    Player.Top -= 30;
                }
            }
        }

        public void EnemyMovement(Control Enemy) // enemy random movement
        {
            Random rnd = new Random();
            int x;

            if (Enemy.Left >= Enemy.Width * -1)
            {
                if (score > 9)
                {
                    Enemy.Left -= 15;
                }
                if (score > 14)
                {
                    Enemy.Left -= 20;
                }
                if (score > 19)
                {
                    Enemy.Left -= 30;
                }

                Enemy.Left -= speed;
            }
            else
            {
                score += 1;
                x = rnd.Next(0, 300);
                Enemy.Location = new Point(1000, x);
            }
        }

        public void GameReset(Control en,
           Control pl, Control ex,
           Timer tim,
           Control lblg, Label lbls) // Flow of the car dodge game
        {
            score = 0;
            tim.Start();
            //273, 494 player enemy 876, 140
            pl.Location = new Point(283, 494);
            en.Location = new Point(876, 140);
            ex.Visible = !true;
            lblg.Visible = !true;
            lbls.Visible = true;
            pl.Visible = true;
            en.Visible = true;


        }

        public void GameResult(Control enemy,
            Control player, Control explosion,
            Timer timerofcardodge,
            Control lblgameover, Label lblscore, Button btntryagain , Button btnexit) // Flow of the car dodge game
        {
            lblscore.Text = score.ToString();

            if (enemy.Location.X < 1000)
            {
                if (player.Bounds.IntersectsWith(enemy.Bounds))
                {
                    btnexit.Visible = true;
                    btntryagain.Visible = true;
                    player.Visible = false;
                    explosion.Visible = true;
                    explosion.Location = enemy.Location;
                    explosion.BackColor = Color.Transparent;
                    enemy.Visible = false;
                    timerofcardodge.Stop();
                    lblgameover.Show();
                }
            }
        }
    }
}
