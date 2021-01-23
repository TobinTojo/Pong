namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picLeftPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picRightPaddle = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblStart = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // picLeftPaddle
            // 
            this.picLeftPaddle.BackColor = System.Drawing.Color.White;
            this.picLeftPaddle.Location = new System.Drawing.Point(20, 280);
            this.picLeftPaddle.Name = "picLeftPaddle";
            this.picLeftPaddle.Size = new System.Drawing.Size(20, 150);
            this.picLeftPaddle.TabIndex = 0;
            this.picLeftPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.White;
            this.picBall.Location = new System.Drawing.Point(490, 340);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.TabIndex = 2;
            this.picBall.TabStop = false;
            // 
            // picRightPaddle
            // 
            this.picRightPaddle.BackColor = System.Drawing.Color.White;
            this.picRightPaddle.Location = new System.Drawing.Point(964, 280);
            this.picRightPaddle.Name = "picRightPaddle";
            this.picRightPaddle.Size = new System.Drawing.Size(20, 150);
            this.picRightPaddle.TabIndex = 3;
            this.picRightPaddle.TabStop = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 10;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(327, 375);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(373, 39);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Press ENTER to Begin!";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(810, 75);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(36, 39);
            this.lblPlayer2.TabIndex = 5;
            this.lblPlayer2.Text = "0";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(206, 75);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(36, 39);
            this.lblPlayer1.TabIndex = 6;
            this.lblPlayer1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1006, 753);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picRightPaddle);
            this.Controls.Add(this.picLeftPaddle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picLeftPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLeftPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picRightPaddle;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
    }
}

