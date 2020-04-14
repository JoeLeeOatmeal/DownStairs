using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownStairs
{   
    public partial class Form1 : Form
    {

        Random rd;
        int playerDropSpeed = 6;
        int gameSpeed = -2;
        int score = 0;
        int health = 10;

        public Form1()
        {
            InitializeComponent();
            rd = new Random();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    player.Image = playerImageList.Images[1];
                    if (player.Left + player.Width < ClientSize.Width)
                    {
                        player.Left += 10;
                    }            
                    break;
                case Keys.Left:
                    player.Image = playerImageList.Images[2];
                    if (player.Left > 0)
                    {
                        player.Left += -10;
                    }                
                    break;
            }
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            player.Image = playerImageList.Images[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameOver(IsGameOver());
            MinusHealth(CheckHurt());
            PlayerDrop();
            GameSpeedChanger();
            BrickMove();

            label2.Text = "Health : " + health;
        }

        private void MinusHealth(bool boo)
        {
            if (boo == true)
            {
                health--;
                player.Top = player.Top + player.Height + brick1.Height + 1;
            }
        }

        private bool CheckHurt()
        {
            if (player.Top < 0)
            {
                return true;
            }
            else
                return false;
        }


        private void GameSpeedChanger()
        {
            switch (score)
            {
                case 10:
                    gameSpeed = -3;
                    break;
                case 20:
                    gameSpeed = -4;
                    break;
                case 30:
                    gameSpeed = -5;
                    break;
                case 40:
                    gameSpeed = -6;
                    break;
                case 50:
                    gameSpeed = -7;
                    break;
                case 60:
                    gameSpeed = -8;
                    break;
            }
        }

        private void GameOver(bool boo)
        {
            if (boo == true)
            {
                timer1.Enabled = false;
                label1.Visible = true;
            }
        }
        
        private bool IsGameOver()
        {
            if (player.Top > ClientSize.Height || health <= 0)
            {
                return true;
            }
            else
                return false;
        }

        private void PlayerDrop()
        {
            if (player.Bounds.IntersectsWith(brick1.Bounds) ||
                player.Bounds.IntersectsWith(brick2.Bounds) ||
                player.Bounds.IntersectsWith(brick3.Bounds) ||
                player.Bounds.IntersectsWith(brick4.Bounds) ||
                player.Bounds.IntersectsWith(brick5.Bounds) ||
                player.Bounds.IntersectsWith(brick6.Bounds)   )
            {
                player.Top += gameSpeed;
            }
            else
            {
                player.Top += playerDropSpeed;
            }
        }


        private void BrickMove()
        {
            if (brick1.Top + brick1.Height < 0)
            {
                BrickRecreate(brick1);
            }
            brick1.Top += gameSpeed;

            if (brick2.Top + brick2.Height < 0)
            {
                BrickRecreate(brick2);
            }
            brick2.Top += gameSpeed;

            if (brick3.Top + brick3.Height < 0)
            {
                BrickRecreate(brick3);
            }
            brick3.Top += gameSpeed;

            if (brick4.Top + brick4.Height < 0)
            {
                BrickRecreate(brick4);
            }
            brick4.Top += gameSpeed;

            if (brick5.Top + brick5.Height < 0)
            {
                BrickRecreate(brick5);
            }
            brick5.Top += gameSpeed;

            if (brick6.Top + brick6.Height < 0)
            {
                BrickRecreate(brick6);
            }
            brick6.Top += gameSpeed;
        }

        private void BrickRecreate(PictureBox brick) 
        {
            brick.Top = ClientSize.Height;
            brick.Left = rd.Next(0, ClientSize.Width - brick.Width);
            score++;
        }
    }
}
