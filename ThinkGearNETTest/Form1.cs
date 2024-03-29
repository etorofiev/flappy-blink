﻿using System;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using ThinkGearNET;

namespace ThinkGearNETTest
{
	public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 6;
        int gravity = 5;
        int Inscore = 0;
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();
        private Random rng = new Random();

		public Form1()
		{
			InitializeComponent();
            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
            gameTimer.Stop();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach(string port in SerialPort.GetPortNames())
				cboPort.Items.Add(port);
			cboPort.SelectedIndex = 0;
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper = new ThinkGearWrapper();

			// setup the event
			_thinkGearWrapper.ThinkGearChanged += _thinkGearWrapper_ThinkGearChanged;

			// connect to the device on the specified COM port at 57600 baud
			if(!_thinkGearWrapper.Connect(cboPort.SelectedItem.ToString(), 57600, true))
            {
                MessageBox.Show("Could not connect to headset.");
            } else {
                endText1.Text = "Game Over!";
                endText2.Text = "Your final score: " + Inscore;
                gameDesigner.Text = "Game Designed By VFU MindWave team";

                endText1.Visible = false;
                endText2.Visible = false;
                gameDesigner.Visible = false;

                gameTimer.Start();
            }
        }

		void _thinkGearWrapper_ThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
		{
            if (e.ThinkGearState.Raw > 180)
            {
                // update the textbox and sleep for a tiny bit
                BeginInvoke(new MethodInvoker(delegate
                {
                    jumping = true;
                    gravity = -45;
                    //lblAttention.Text = "Attention: " + e.ThinkGearState.Attention;
                    //lblMeditation.Text = "Meditation: " + e.ThinkGearState.Meditation;
                    txtState.Text = e.ThinkGearState.ToString();
                }));
                Thread.Sleep(10);
            } else
            {
                // update the textbox and sleep for a tiny bit
                BeginInvoke(new MethodInvoker(delegate
                {
                    jumping = false;
                    gravity = 5;
                    //lblAttention.Text = "Attention: " + e.ThinkGearState.Attention;
                    //lblMeditation.Text = "Meditation: " + e.ThinkGearState.Meditation;
                    //txtState.Text = e.ThinkGearState.ToString();
                }));
                Thread.Sleep(10);
            }
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			_thinkGearWrapper.Disconnect();
		}

		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.Disconnect();
		}

		private void btnEnableBlink_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.EnableBlinkDetection(true);
		}

		private void btnDisableBlink_Click(object sender, EventArgs e)
		{
			_thinkGearWrapper.EnableBlinkDetection(false);
		}

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            scoreText.Text = "Current score: " + Inscore;

            if (flappyBird.Bottom <= 0)
            {
                flappyBird.Top -= gravity;
            }

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 1350;
                Inscore += 1;
            }
            else if (pipeTop.Left < -150)
            {
                pipeTop.Left = 1350;
                Inscore += 1;
            }
            else if (pipeBottom2.Left < -150)
            {
                pipeBottom2.Left = 1350;
                int newSize = rng.Next(100, 200);
                int diff = pipeBottom2.Size.Height - newSize;
                //int newSize = pipeBottom2.MaximumSize.Height;
                pipeBottom2.Size = new Size(pipeBottom2.Size.Width, newSize);
                pipeBottom2.Location = new Point(pipeBottom2.Location.X, pipeBottom2.Location.Y + diff);
                Inscore += 1;
            }
            else if (pipeTop2.Left < -150)
            {
                pipeTop2.Left = 1350;
                pipeTop2.Location = new Point(pipeTop2.Location.X, rng.Next(-450, -280));
                Inscore += 1;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                EndGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds))
            {
                EndGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                EndGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds))
            {
                EndGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                flappyBird.Top -= gravity * 8;
                //EndGame();
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            endText1.Text = "Game Over!";
            endText2.Text = "Your final score: " + Inscore;
            gameDesigner.Text = "Game Designed By VFU MindWave team";

            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
        }

        private void RestartGame()
        {
            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
            Inscore = 0;
            flappyBird.Location = new Point(-2, 30);
            pipeTop.Location = new Point(120, 325);
            pipeBottom2.Location = new Point(846, 327);
            pipeBottom2.Size = new Size(190, 228);
            pipeBottom.Location = new Point(466, -354);
            pipeTop2.Location = new Point(1153, -331);
            pipeTop2.Size = new Size(190, 550);
            gameTimer.Start();
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
