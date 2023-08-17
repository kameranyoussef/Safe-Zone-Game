/*     Safe Zone V.1 produced by Kamran Youssef
 *     This is my first game creating using c# everything 
 *     i have used in this project came from researchers and all the 
 *     all libraries are unfamiliar and is my first time using them.    
 */

/*      This class is game screen class
 *      In this class is for racket, ball, power up, live, score 
 *      
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class GameScreen : Form
    {

        // variables for speed of the ball
        public int speed_left , speed_top ;

        // variable for the score system 
        public int score = 0;

        //variable for live system 
        public int live = 3;

        //veriable for power up system
        public int count_down;

        //stop is declared for the pwoer up timer
        public Timer power_up_timer;
        
        // variables for speed of the  power up 
        public int powerup_speed;

        // for random power up 
        public int powerup_num;
        //to check if power up is on or off
        public bool power_up_check;
        
        //to trun off or on the power up
        public bool live_powerup_check;
        public bool extraPoints_powerup_check;
        public bool takeAway_powerup_check;


        // to generate a random int value
        public Random random = new Random();

        //variables for different difficulty setting song
        System.Media.SoundPlayer song_easy_player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer song_hard_player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer song_insane_player = new System.Media.SoundPlayer();

        //variables for different sounds effect
        System.Media.SoundPlayer game_over_sound_player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer live_player = new System.Media.SoundPlayer();

        //To Load All Sound Elements
        public void LoadSoundElements()
        {
            //loading the songs for different difficulty setting 
            song_easy_player.Stream = Properties.Resources.song_easy;
            song_hard_player.Stream = Properties.Resources.song_hard;
            song_insane_player.Stream = Properties.Resources.song_insane;


            //loading sounds effect 
            game_over_sound_player.Stream = Properties.Resources.game_over_se;
            live_player.Stream = Properties.Resources.live_se;
        
        }
        
        //To Set Game Options
        public void SetGameOptions()
        {
            //Game the easy difficulty setting 
            if (MainMenu.difficulty_easy == true)
            {
                //ball speed
                speed_left = 5;
                speed_top = 5;
                //power up speed
                powerup_speed = 5;
                // racket size 
                racket.Width = 500;
                if (MainMenu.music_on == true)
                {
                    song_easy_player.PlayLooping();
                }

            }

            //Game the hard difficulty setting 
            else if (MainMenu.difficulty_hard == true)
            {
                //ball speed
                speed_left = 10;
                speed_top = 10;
                //power up speed
                powerup_speed = 7;
                // racket size 
                racket.Width = 300;

                if (MainMenu.music_on == true)
                {
                    song_hard_player.PlayLooping();
                }
            }

            //Game the insane difficulty setting 
            else if (MainMenu.difficulty_insane == true)
            {
                //ball speed
                speed_left = 15;
                speed_top = 15;
                //power up speed
                powerup_speed = 9;
                // racket size 
                racket.Width = 150;
                if (MainMenu.music_on == true)
                {
                    song_insane_player.PlayLooping();
                }
            }
        }

        //To Set Ball  settings 
        public void Ball()
        {
            // starting random postion for the ball 
            ball.Top = 50;
            ball.Left = random.Next(50, Playground.Width - 60);
            
            //set the ball color to red
            ball.BackColor = Color.Red;
        }

        //To Set PowerUp setting  
        public void PowerUp()
        {
            //setting random postion for the live power up 
            live_PowerUp.Top = -25;
            live_PowerUp.Left = random.Next(250, Playground.Width - 40);

            //setting random postion for the live power up 
            extraPoints_PowerUp.Top = -25;
            extraPoints_PowerUp.Left = random.Next(250, Playground.Width - 40);

            //setting random postion for the live power up 
            takeAway_PowerUp.Top = -25;
            takeAway_PowerUp.Left = random.Next(250, Playground.Width - 40);
            
            //to set the timer interval to 1
            power_up_timer = new Timer() { Interval = 1 };

            //to trun on the timer
            power_up_check = true;
            
            //to trun on the powerups
            live_powerup_check = true;
            extraPoints_powerup_check = true;
            takeAway_powerup_check = true;
        }

        //To Set Racket Settings 
        public void Racket()
        {
            //set the racket color to Black
            racket.BackColor = Color.Black;
            
            //set the poistion of the racket
            racket.Top = Playground.Bottom - (Playground.Bottom / 10); 
            
            
        }

        //To Set Screen Properties
        public void ScreenProperties()
        {
               
            Cursor.Hide();                                   //to hide the cursor
            this.FormBorderStyle = FormBorderStyle.None;     //removes border
            this.TopMost = true;                             //bring the from to the front 
            this.Bounds = Screen.PrimaryScreen.Bounds;       //make it fullscreen 
            Playground.BackColor = Color.White;              //set the background color to white

            
            

        }

        public GameScreen()
        {
            InitializeComponent();
            
            //To Load All Sound Elements
            LoadSoundElements();
           
            //To Set Screen Properties
            ScreenProperties();
           
            //To Set Game Options
            SetGameOptions();
           
            //To Set ball starting postion 
            Ball();
            
            //To Set Racket Settings 
            Racket();
            
            //To Set PowerUp setting  
            PowerUp();

            //setting the postion of the game over menu 
            lbl_GameOver.Left = (Playground.Width / 2) - (lbl_GameOver.Width / 2);
            lbl_GameOver.Top = (Playground.Height / 2) - (lbl_GameOver.Height / 2);

            //to show the live
            lbl_live.Text = Convert.ToString(live);

            Game_Time.Enabled = true;                        //Enabling the timer
        }

        private void Game_Time_Tick(object sender, EventArgs e)
        {
            //running the power up timer
            if(power_up_check == true)
            {
                //Adding 1 to the power up timer interval every loop
                power_up_timer.Interval = power_up_timer.Interval + 1;
            }
            if (power_up_timer.Interval > 800)
            {
                //trun off the power timer
                power_up_check = false;
                //picking a random power up
                RandomPowerUp();
            }
            //power up collision with racket
            PowerUpCollisionWR();

            //power up collision with the room
            PowerUpCollisionWG();

            // set the center of the racket to the position of the cursor 
            racket.Left = Cursor.Position.X - (racket.Width / 2);
           
            // for the ball to move 
            ball.Left += speed_left;
            ball.Top += speed_top;

            //ball collision
            BallCollision();

            //if player lives = 0 game over
            if (live == 0)
            {
                //game over
                GameOver();
            }
        }

        //Picking Random PowerUp
        public void RandomPowerUp()
        {
            powerup_num = random.Next(1, 3);


            if (powerup_num == 1 && live_powerup_check == true)
            {
                //trun off other power ups 
                extraPoints_powerup_check = false;
                takeAway_powerup_check = false;
                //for the live powerup to move 
                live_PowerUp.Top += powerup_speed;
            }
            else if (powerup_num == 2 && extraPoints_powerup_check == true)
            {
                //trun off other power ups 
                live_powerup_check = false;
                takeAway_powerup_check = false;
                //for the extra points powerup to move      
                extraPoints_PowerUp.Top += powerup_speed;
            }
            else if (powerup_num == 3 && takeAway_powerup_check == true)
            {
                //trun off other power ups 
                live_powerup_check = false;
                extraPoints_powerup_check = false;
                //for the take away powerup to move      
                takeAway_PowerUp.Top += powerup_speed;
            }
        }

        //power up collision with racket
        public void PowerUpCollisionWR()
        {
            //live power up collision with racket
            if (live_PowerUp.Bottom >= racket.Top && live_PowerUp.Bottom <= racket.Bottom && live_PowerUp.Left >= racket.Left && live_PowerUp.Right <= racket.Right)
            {
                //setting new random postion for the live power up 
                live_PowerUp.Top = -25;
                live_PowerUp.Left = random.Next(250, Playground.Width - 40);
                //add one to live 
                live++;
                //stop the game for 1 sec
                System.Threading.Thread.Sleep(100);
                //to update the live
                lbl_live.Text = Convert.ToString(live);
                //reset power up timer
                power_up_timer.Interval = 1;
                //trun on the power up timer
                power_up_check = true;
                //reset power ups
                live_powerup_check = true;
                extraPoints_powerup_check = true;
                takeAway_powerup_check = true;
            }
            //extra points power up collision with racket
            if (extraPoints_PowerUp.Bottom >= racket.Top && extraPoints_PowerUp.Bottom <= racket.Bottom && extraPoints_PowerUp.Left >= racket.Left && extraPoints_PowerUp.Right <= racket.Right)
            {
                //setting new random postion for the extra points power up 
                extraPoints_PowerUp.Top = -25;
                extraPoints_PowerUp.Left = random.Next(250, Playground.Width - 40);
                //add 2 points to score
                score = score + 2;
                //stop the game for 1 sec
                System.Threading.Thread.Sleep(100);
                //to update the score
                lbl_score.Text = score.ToString();
                //reset power up timer
                power_up_timer.Interval = 1;
                //trun on the power up timer
                power_up_check = true;
                //reset power ups
                live_powerup_check = true;
                extraPoints_powerup_check = true;
                takeAway_powerup_check = true;
            }
            //take away power up collision with racket
            if (takeAway_PowerUp.Bottom >= racket.Top && takeAway_PowerUp.Bottom <= racket.Bottom && takeAway_PowerUp.Left >= racket.Left && takeAway_PowerUp.Right <= racket.Right)
            {
                //setting new random postion for the live power up 
                takeAway_PowerUp.Top = -25;
                takeAway_PowerUp.Left = random.Next(250, Playground.Width - 40);
                //add one to live 
                live--;
                //stop the game for 1 sec
                System.Threading.Thread.Sleep(100);
                //to update the live
                lbl_live.Text = Convert.ToString(live);
                //reset power up timer
                power_up_timer.Interval = 1;
                //trun on the power up timer
                power_up_check = true;
                //reset power ups
                live_powerup_check = true;
                extraPoints_powerup_check = true;
                takeAway_powerup_check = true;
            }
        }

        //power up collision with the room
        public void PowerUpCollisionWG()
        {
            //To reset the live power up when power up hit the bottom 
            if (live_PowerUp.Bottom >= Playground.Bottom)
            {
                //setting new random postion for the live power up 
                live_PowerUp.Top = -25;
                live_PowerUp.Left = random.Next(250, Playground.Width - 40);
                //reset power up timer
                power_up_timer.Interval = 1;
                //trun on the power up timer
                power_up_check = true;
                //reset power ups
                live_powerup_check = true;
                extraPoints_powerup_check = true;
                takeAway_powerup_check = true;
            }
            //To reset the extra points power up when power up hit the bottom 
            if (extraPoints_PowerUp.Bottom >= Playground.Bottom)
            {
                //setting new random postion for the live power up 
                extraPoints_PowerUp.Top = -25;
                extraPoints_PowerUp.Left = random.Next(250, Playground.Width - 40);
                //reset power up timer
                power_up_timer.Interval = 1;
                //trun on the power up timer
                power_up_check = true;
                //reset power ups
                live_powerup_check = true;
                extraPoints_powerup_check = true;
                takeAway_powerup_check = true;
            }
            //To reset the take away power up when power up hit the bottom 
            if (takeAway_PowerUp.Bottom >= Playground.Bottom)
            {
                //setting new random postion for the live power up 
                takeAway_PowerUp.Top = -25;
                takeAway_PowerUp.Left = random.Next(250, Playground.Width - 40);
                //reset power up timer
                power_up_timer.Interval = 1;
                //trun on the power up timer
                power_up_check = true;
                //reset power ups
                live_powerup_check = true;
                extraPoints_powerup_check = true;
                takeAway_powerup_check = true;
            }
        }

        //ball collision
        public void BallCollision()
        {
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right) //collision with racket
            {

                if (MainMenu.difficulty_easy == true)
                {
                    // incrumenting the speed of the ball depending on the game settings 
                    speed_top += 1;
                    speed_left += 1;

                }
                else if (MainMenu.difficulty_hard == true)
                {
                    // incrumenting the speed of the ball depending on the game settings 
                    speed_top += 2;
                    speed_left += 2;
                }
                else if (MainMenu.difficulty_insane == true)
                {
                    // incrumenting the speed of the ball depending on the game settings 
                    speed_top += 3;
                    speed_left += 3;
                }

                //change direction
                speed_top = -speed_top;

                // add one to the score
                score += 1;

                // To Display the score
                lbl_score.Text = score.ToString();

                //To Change the backgorund color to a random color 
                Playground.BackColor = Color.FromArgb(random.Next(150, 255), random.Next(150, 255), random.Next(150, 255));
                live_PowerUp.BackColor = Playground.BackColor;
            }

            // change direction of the ball to right side when it hits the left side of the screen
            if (ball.Left <= Playground.Left)
            {
                speed_left = -speed_left;
            }

            // change direction of the ball to left side when it hits the right side of the screen
            if (ball.Right >= Playground.Right)
            {
                speed_left = -speed_left;
            }

            // change direction of the ball to bottom side when it hits the top side of the screen
            if (ball.Top <= Playground.Top)
            {
                speed_top = -speed_top;
            }


            //To stop the game when the ball hit the bottom 
            if (ball.Bottom >= Playground.Bottom)
            {

                speed_top = -speed_top;
                //to decrement  live by 1
                live--;
                //to update the live
                lbl_live.Text = Convert.ToString(live);

                //play sound effect when lossing a live
                if (MainMenu.sound_e_on == true)
                {
                    live_player.Play();
                    System.Threading.Thread.Sleep(150);
                }

                //to play back the song for easy difficulty setting 
                if (MainMenu.difficulty_easy == true && MainMenu.music_on == true)
                {

                    song_easy_player.PlayLooping();
                }

                //to play back the song for easy hard difficulty setting 
                else if (MainMenu.difficulty_hard == true && MainMenu.music_on == true)
                {

                    song_hard_player.PlayLooping();
                }

                //to play back the song for easy insane difficulty setting 
                else if (MainMenu.difficulty_insane == true && MainMenu.music_on == true)
                {

                    song_insane_player.PlayLooping();
                }

            }
        }

        //game paused
        public void Paused()
        {

                   //stop the game
                Game_Time.Enabled = false;
                   //Show message 
                lbl_Message.Visible = false;

                //To show the pause menu 
                lbl_GamePaused.Visible = true;
        }

        //game resume
        public void Resume()
        {
            //run the game
            Game_Time.Enabled = true;

            //Show message 
            lbl_Message.Visible = true;

            //hiding the pause menu 
            lbl_GamePaused.Visible = false;
        
        }

        //game over
        public void GameOver()
        {
            //stop the game
            Game_Time.Enabled = false;

            //To show the game over menu 
            lbl_GameOver.Visible = true;

            //stop music when the ball hit the bottom
            song_easy_player.Stop();
            song_hard_player.Stop();
            song_insane_player.Stop();

            //hide message 
            lbl_Message.Visible = false;

            //playing sound effect 
            if (MainMenu.sound_e_on == true)
            {
                game_over_sound_player.Play();
            }
        }


        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            
               if (e.KeyCode == Keys.Enter && Game_Time.Enabled == true)
            {
                //game paused
                Paused();

            }
               else if (e.KeyCode == Keys.Enter && Game_Time.Enabled == false)
            {

               //game resume
                Resume();

            }

               //only if the ball hit the bottom of the screen 
           
            if (Game_Time.Enabled == false)
            {
                // To restart the game 
                if (e.KeyCode == Keys.R)
                {
                    // restarting ball setting 
                    Ball();

                    //resetting the live to 3
                    live = 3;
                    lbl_live.Text = Convert.ToString(live);

                    //resetting the score to 0
                    score = 0;
                    lbl_score.Text = "0";

                    //hiding the game over menu 
                    lbl_GameOver.Visible = false;

                    //show message 
                    lbl_Message.Visible = true;

                    //hiding the pause menu 
                    lbl_GamePaused.Visible = false;

                    //to reset the backgound color to white 
                    Playground.BackColor = Color.White;

                    //to reset the racket color to new color
                    racket.BackColor = Color.FromArgb(random.Next(150, 255), random.Next(150, 255), random.Next(150, 255));

                    //restarting power up to random postion 
                    PowerUp();

                    //resetting game settings 
                    SetGameOptions();

                    //endabling the timer
                    Game_Time.Enabled = true;

                }
                // To go back to the main menu the game 
                if (e.KeyCode == Keys.M)
                {
                    // to hide the game screen
                    this.Hide();

                    // to show the main menu
                    MainMenu m_menu = new MainMenu();
                    m_menu.Show();

                    //to show the cursor 
                    Cursor.Show();
                }

                //press escape to quit 
                if (e.KeyCode == Keys.Escape)
                {
                    Application.Exit();
                }
            }
        }      

    }
}
