using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using ThinkGearNET;

namespace ThinkGearNETTest
{
	public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 5;
        int Inscore = 0;
        private ThinkGearWrapper _thinkGearWrapper = new ThinkGearWrapper();

		public Form1()
		{
			InitializeComponent();
            endText1.Text = "Game Over!";
            endText2.Text = "Your final score: " + Inscore;
            gameDesigner.Text = "Game Designed By VFU MindWave team";

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
				MessageBox.Show("Could not connect to headset.");


            endText1.Text = "Game Over!";
            endText2.Text = "Your final score: " + Inscore;
            gameDesigner.Text = "Game Designed By VFU MindWave team";

            endText1.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;

            gameTimer.Start();
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
                    lblAttention.Text = "Attention: " + e.ThinkGearState.Attention;
                    lblMeditation.Text = "Meditation: " + e.ThinkGearState.Meditation;
                    txtState.Text = e.ThinkGearState.ToString();
                }));
                Thread.Sleep(10);
            } else
            {
                // update the textbox and sleep for a tiny bit
                BeginInvoke(new MethodInvoker(delegate
                {
                    jumping = false;
                    gravity = 4;
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
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            scoreText.Text = "" + Inscore;

            if (flappyBird.Bottom <= 0)
            {
                flappyBird.Top -= gravity;
            }

            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 1000;
                Inscore += 1;
            }
            else if (pipeTop.Left < -95)
            {
                pipeTop.Left = 1100;
                Inscore += 1;
            }

            if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                //EndGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                //EndGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                //EndGame();
            }
        }
    }
}
