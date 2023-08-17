namespace WindowsFormsApplication1
{
    partial class GameScreen
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
            this.Playground = new System.Windows.Forms.Panel();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.lbl_GamePaused = new System.Windows.Forms.Label();
            this.takeAway_PowerUp = new System.Windows.Forms.PictureBox();
            this.extraPoints_PowerUp = new System.Windows.Forms.PictureBox();
            this.live_PowerUp = new System.Windows.Forms.PictureBox();
            this.lbl_live = new System.Windows.Forms.Label();
            this.lbl_live_display = new System.Windows.Forms.Label();
            this.lbl_GameOver = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_score_display = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.Game_Time = new System.Windows.Forms.Timer(this.components);
            this.Playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takeAway_PowerUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoints_PowerUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.live_PowerUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // Playground
            // 
            this.Playground.Controls.Add(this.lbl_Message);
            this.Playground.Controls.Add(this.lbl_GamePaused);
            this.Playground.Controls.Add(this.takeAway_PowerUp);
            this.Playground.Controls.Add(this.extraPoints_PowerUp);
            this.Playground.Controls.Add(this.live_PowerUp);
            this.Playground.Controls.Add(this.lbl_live);
            this.Playground.Controls.Add(this.lbl_live_display);
            this.Playground.Controls.Add(this.lbl_GameOver);
            this.Playground.Controls.Add(this.lbl_score);
            this.Playground.Controls.Add(this.lbl_score_display);
            this.Playground.Controls.Add(this.ball);
            this.Playground.Controls.Add(this.racket);
            this.Playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playground.Location = new System.Drawing.Point(0, 0);
            this.Playground.Name = "Playground";
            this.Playground.Size = new System.Drawing.Size(1300, 786);
            this.Playground.TabIndex = 1;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Message.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.Color.Black;
            this.lbl_Message.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_Message.Location = new System.Drawing.Point(532, 9);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(316, 40);
            this.lbl_Message.TabIndex = 11;
            this.lbl_Message.Text = "Press Enter to Pause";
            this.lbl_Message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_GamePaused
            // 
            this.lbl_GamePaused.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GamePaused.AutoSize = true;
            this.lbl_GamePaused.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GamePaused.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GamePaused.Location = new System.Drawing.Point(221, 160);
            this.lbl_GamePaused.Name = "lbl_GamePaused";
            this.lbl_GamePaused.Size = new System.Drawing.Size(881, 282);
            this.lbl_GamePaused.TabIndex = 10;
            this.lbl_GamePaused.Text = "                        Game Paused\r\n \r\nPress    Enter  - To Resume\r\nPress    R  " +
    "       - To Restart \r\nPress    M        - To Go back to the Main menu \r\nPress   " +
    " ESC     - To Quit ";
            this.lbl_GamePaused.Visible = false;
            // 
            // takeAway_PowerUp
            // 
            this.takeAway_PowerUp.BackColor = System.Drawing.Color.Transparent;
            this.takeAway_PowerUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.takeAway_PowerUp.Image = global::WindowsFormsApplication1.Properties.Resources.I_TakeAway;
            this.takeAway_PowerUp.Location = new System.Drawing.Point(415, 25);
            this.takeAway_PowerUp.Name = "takeAway_PowerUp";
            this.takeAway_PowerUp.Size = new System.Drawing.Size(35, 25);
            this.takeAway_PowerUp.TabIndex = 9;
            this.takeAway_PowerUp.TabStop = false;
            // 
            // extraPoints_PowerUp
            // 
            this.extraPoints_PowerUp.BackColor = System.Drawing.Color.Transparent;
            this.extraPoints_PowerUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.extraPoints_PowerUp.Image = global::WindowsFormsApplication1.Properties.Resources.I_ExtraPoints;
            this.extraPoints_PowerUp.Location = new System.Drawing.Point(335, 25);
            this.extraPoints_PowerUp.Name = "extraPoints_PowerUp";
            this.extraPoints_PowerUp.Size = new System.Drawing.Size(35, 25);
            this.extraPoints_PowerUp.TabIndex = 8;
            this.extraPoints_PowerUp.TabStop = false;
            // 
            // live_PowerUp
            // 
            this.live_PowerUp.BackColor = System.Drawing.Color.Transparent;
            this.live_PowerUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.live_PowerUp.Image = global::WindowsFormsApplication1.Properties.Resources.I_Live;
            this.live_PowerUp.Location = new System.Drawing.Point(250, 25);
            this.live_PowerUp.Name = "live_PowerUp";
            this.live_PowerUp.Size = new System.Drawing.Size(35, 25);
            this.live_PowerUp.TabIndex = 7;
            this.live_PowerUp.TabStop = false;
            // 
            // lbl_live
            // 
            this.lbl_live.AutoSize = true;
            this.lbl_live.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_live.Location = new System.Drawing.Point(174, 89);
            this.lbl_live.Name = "lbl_live";
            this.lbl_live.Size = new System.Drawing.Size(42, 66);
            this.lbl_live.TabIndex = 6;
            this.lbl_live.Text = " ";
            // 
            // lbl_live_display
            // 
            this.lbl_live_display.AutoSize = true;
            this.lbl_live_display.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_live_display.Location = new System.Drawing.Point(12, 89);
            this.lbl_live_display.Name = "lbl_live_display";
            this.lbl_live_display.Size = new System.Drawing.Size(143, 66);
            this.lbl_live_display.TabIndex = 5;
            this.lbl_live_display.Text = "Live:";
            // 
            // lbl_GameOver
            // 
            this.lbl_GameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_GameOver.AutoSize = true;
            this.lbl_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GameOver.Font = new System.Drawing.Font("Kristen ITC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameOver.Location = new System.Drawing.Point(221, 322);
            this.lbl_GameOver.Name = "lbl_GameOver";
            this.lbl_GameOver.Size = new System.Drawing.Size(833, 235);
            this.lbl_GameOver.TabIndex = 4;
            this.lbl_GameOver.Text = "                        Game Over \r\n\r\nPress    R     - To Restart \r\nPress    M   " +
    " - To Go back to the Main menu \r\nPress    ESC - To Quit ";
            this.lbl_GameOver.Visible = false;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(174, 9);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(57, 66);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "0";
            // 
            // lbl_score_display
            // 
            this.lbl_score_display.AutoSize = true;
            this.lbl_score_display.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score_display.Location = new System.Drawing.Point(12, 9);
            this.lbl_score_display.Name = "lbl_score_display";
            this.lbl_score_display.Size = new System.Drawing.Size(178, 66);
            this.lbl_score_display.TabIndex = 2;
            this.lbl_score_display.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(42, 247);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(233, 674);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(300, 25);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // Game_Time
            // 
            this.Game_Time.Interval = 1;
            this.Game_Time.Tick += new System.EventHandler(this.Game_Time_Tick);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 786);
            this.Controls.Add(this.Playground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safe Zone";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            this.Playground.ResumeLayout(false);
            this.Playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takeAway_PowerUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraPoints_PowerUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.live_PowerUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Playground;
        private System.Windows.Forms.Label lbl_GameOver;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_score_display;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer Game_Time;
        private System.Windows.Forms.Label lbl_live;
        private System.Windows.Forms.Label lbl_live_display;
        private System.Windows.Forms.PictureBox live_PowerUp;
        private System.Windows.Forms.PictureBox extraPoints_PowerUp;
        private System.Windows.Forms.PictureBox takeAway_PowerUp;
        private System.Windows.Forms.Label lbl_GamePaused;
        private System.Windows.Forms.Label lbl_Message;
    }
}