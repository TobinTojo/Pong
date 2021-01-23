using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace Pong
{
    enum PaddleState
    {
        None,
        Up,
        Down
    }


    public partial class Form1 : Form
    {
        //global variables
        PaddleState LeftPaddle = PaddleState.None;
        PaddleState RightPaddle = PaddleState.None;
        Vector2 Velocity;
        Vector2 Position;
        float Speed;
        int Player1 = 0, Player2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //move left paddle
            if (e.KeyCode == Keys.W)
            {
                LeftPaddle = PaddleState.Up;
            }
            if (e.KeyCode == Keys.S)
            {
                LeftPaddle = PaddleState.Down;
            }
            //move right paddle
            if (e.KeyCode == Keys.Up)
            {
                RightPaddle = PaddleState.Up;
            }
            if (e.KeyCode == Keys.Down)
            {
                RightPaddle = PaddleState.Down;
            }
            if (e.KeyCode == Keys.Return)
            {
                //reset
                Reset();

                lblStart.Visible = false;
                tmrGame.Enabled = true;
            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //PaddleState is None for all
            if (e.KeyCode == Keys.W)
            {
                LeftPaddle = PaddleState.None;
            }
            if (e.KeyCode == Keys.S)
            {
                LeftPaddle = PaddleState.None;
            }
            
            if (e.KeyCode == Keys.Up)
            {
                RightPaddle = PaddleState.None;
            }
            if (e.KeyCode == Keys.Down)
            {
                RightPaddle = PaddleState.None;
            }

        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            //detect if ball hits a paddle
            if (picLeftPaddle.Bounds.IntersectsWith(picBall.Bounds) ||
                picRightPaddle.Bounds.IntersectsWith(picBall.Bounds))
            {
                //we have a collision
                //set max speed
                if (Speed < 11)
                {
                    Velocity.X = -1.1f * Velocity.X;
                    Velocity.Y = 1.1f * Velocity.Y;
                    Speed = (float)Velocity.Length();
                }
                else
                {
                    Velocity.X = -1 * Velocity.X;
                }

            }


            //detect if the ball hits top or bottom wall
            if (picBall.Top <= 0 || picBall.Bottom >= ClientSize.Height)
            {
                Velocity.Y = -1 * Velocity.Y;
            }

            //check if ball scores
            if (picBall.Left <= 0)
            {
                Player2++;
                lblPlayer2.Text = Player2.ToString();
                Reset();
            }
            else if (picBall.Right >= ClientSize.Width)
            {
                Player1++;
                lblPlayer1.Text = Player1.ToString();
                Reset();
            }


            //move the ball
            Position = Position + Velocity;
            picBall.Left = (int)Position.X;
            picBall.Top = (int)Position.Y;

            //move the paddles
            if (LeftPaddle == PaddleState.Up)
            {
                picLeftPaddle.Top -= 5;
            }
            if (LeftPaddle == PaddleState.Down)
            {
                picLeftPaddle.Top += 5;
            }
            if (RightPaddle == PaddleState.Up)
            {
                picRightPaddle.Top -= 5;
            }
            if (RightPaddle == PaddleState.Down)
            {
                picRightPaddle.Top += 5;
            }


        }


        private float FindRandomAngle()
        {
            //generate a random angle for the ball
            Random RandomAngle = new Random();

            int R = 0;
            while (R % 2 == 0)
            {
                R = RandomAngle.Next(1, 8);
            }
            //convert angle to radian from degrees
            float Angle = MathHelper.ToRadians(R * 45);

            return Angle;
        }

        private void Reset()
        {
            //set the ball in middle of screen
            float Width = (ClientSize.Width + picBall.Width) / 2;
            float Height = (ClientSize.Height + picBall.Height) / 2;
            Position = new Vector2(Width, Height);
            //set velocity of ball
            float Angle = FindRandomAngle();
            Speed = 6;
            float Vx = Speed * (float)Math.Cos(Angle);
            float Vy = Speed * (float)Math.Sin(Angle);
            Velocity = new Vector2(Vx, Vy);

        }


    }
}
