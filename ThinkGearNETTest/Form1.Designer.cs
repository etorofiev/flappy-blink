namespace ThinkGearNETTest
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
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblAttention = new System.Windows.Forms.Label();
            this.lblMeditation = new System.Windows.Forms.Label();
            this.btnEnableBlink = new System.Windows.Forms.Button();
            this.btnDisableBlink = new System.Windows.Forms.Button();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.endText1 = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameDesigner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPort
            // 
            this.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(86, 543);
            this.cboPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(160, 24);
            this.cboPort.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(25, 577);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 28);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(304, 543);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(271, 145);
            this.txtState.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 548);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM Port:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(153, 577);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(112, 28);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Location = new System.Drawing.Point(17, 646);
            this.lblAttention.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(64, 17);
            this.lblAttention.TabIndex = 5;
            this.lblAttention.Text = "Attention";
            // 
            // lblMeditation
            // 
            this.lblMeditation.AutoSize = true;
            this.lblMeditation.Location = new System.Drawing.Point(17, 671);
            this.lblMeditation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeditation.Name = "lblMeditation";
            this.lblMeditation.Size = new System.Drawing.Size(73, 17);
            this.lblMeditation.TabIndex = 5;
            this.lblMeditation.Text = "Meditation";
            // 
            // btnEnableBlink
            // 
            this.btnEnableBlink.Location = new System.Drawing.Point(25, 607);
            this.btnEnableBlink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnableBlink.Name = "btnEnableBlink";
            this.btnEnableBlink.Size = new System.Drawing.Size(112, 28);
            this.btnEnableBlink.TabIndex = 6;
            this.btnEnableBlink.Text = "Enable Blink";
            this.btnEnableBlink.UseVisualStyleBackColor = true;
            this.btnEnableBlink.Click += new System.EventHandler(this.btnEnableBlink_Click);
            // 
            // btnDisableBlink
            // 
            this.btnDisableBlink.Location = new System.Drawing.Point(153, 607);
            this.btnDisableBlink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisableBlink.Name = "btnDisableBlink";
            this.btnDisableBlink.Size = new System.Drawing.Size(112, 28);
            this.btnDisableBlink.TabIndex = 7;
            this.btnDisableBlink.Text = "Disable Blink";
            this.btnDisableBlink.UseVisualStyleBackColor = true;
            this.btnDisableBlink.Click += new System.EventHandler(this.btnDisableBlink_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::ThinkGearNETTest.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(-2, 371);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(82, 57);
            this.flappyBird.TabIndex = 8;
            this.flappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::ThinkGearNETTest.Properties.Resources.pipedown;
            this.pipeBottom.Location = new System.Drawing.Point(724, -297);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(192, 554);
            this.pipeBottom.TabIndex = 9;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::ThinkGearNETTest.Properties.Resources.pipe;
            this.pipeTop.Location = new System.Drawing.Point(287, 325);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(191, 176);
            this.pipeTop.TabIndex = 10;
            this.pipeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::ThinkGearNETTest.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-2, 498);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1360, 210);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 11;
            this.ground.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 25;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreText.Location = new System.Drawing.Point(583, 543);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(107, 35);
            this.scoreText.TabIndex = 12;
            this.scoreText.Text = "scoreText";
            // 
            // endText1
            // 
            this.endText1.AutoSize = true;
            this.endText1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endText1.Location = new System.Drawing.Point(583, 588);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(109, 35);
            this.endText1.TabIndex = 13;
            this.endText1.Text = "endText1";
            // 
            // endText2
            // 
            this.endText2.AutoSize = true;
            this.endText2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endText2.Location = new System.Drawing.Point(583, 630);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(109, 35);
            this.endText2.TabIndex = 14;
            this.endText2.Text = "endText2";
            // 
            // gameDesigner
            // 
            this.gameDesigner.AutoSize = true;
            this.gameDesigner.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameDesigner.Location = new System.Drawing.Point(583, 671);
            this.gameDesigner.Name = "gameDesigner";
            this.gameDesigner.Size = new System.Drawing.Size(152, 35);
            this.gameDesigner.TabIndex = 15;
            this.gameDesigner.Text = "gameDesigner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 773);
            this.Controls.Add(this.gameDesigner);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.btnDisableBlink);
            this.Controls.Add(this.btnEnableBlink);
            this.Controls.Add(this.lblMeditation);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboPort);
            this.Controls.Add(this.ground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThinkGearNET Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboPort;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label lblAttention;
		private System.Windows.Forms.Label lblMeditation;
		private System.Windows.Forms.Button btnEnableBlink;
		private System.Windows.Forms.Button btnDisableBlink;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Label gameDesigner;
    }
}

