/*     Safe Zone V.1 produced by Kamran Youssef
 *     This is my first game creating using c# everything 
 *     i have used in this project came from researchers and all the 
 *     all libraries are unfamiliar and is my first time using them.    
 */

/*      This class is used to set up game option its is for the main menu  
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
    public partial class MainMenu : Form
    {
        // variables for the game setting 
        public static bool difficulty_easy;
        public static bool difficulty_hard;
        public static bool difficulty_insane;
        public static bool sound_e_on;
        public static bool music_on;


        //variable for the menu song
        System.Media.SoundPlayer song_menu_player = new System.Media.SoundPlayer();


        public MainMenu()
        {
            InitializeComponent();
            
            //To load the defult options for the game
            LoadMainMenu();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //this is example of validation 
            //I use the  Sound Effects option to make sure the user select an option

            if (rb_sound_E_off.Checked == false && rb_sound_E_on.Checked == false)
            {
                MessageBox.Show("Please Select Sound Effects option?");
            }

            else
            {
                //To check game settings 
                SettingCheck();

                //stopping the menu song
                song_menu_player.Stop();
                this.Hide();   // hide the main menu 
                GameScreen gameScreen = new GameScreen();
                gameScreen.Show(); // show the game screen
            }

        }

        public void LoadMainMenu()
        {
            //Setting up default game setting
            rb_easy.Checked = true;
            rb_muisc_on.Checked = true;
            //rb_sound_E_on.Checked = true;
           

            //loading the menu song
            song_menu_player.Stream = Properties.Resources.song_menu;

            //playing the menu song
            song_menu_player.PlayLooping();
        }

        public void SettingCheck()
        {

            //setting up difficulty game settings
            if (rb_easy.Checked == true)
            {
                difficulty_easy = true;
                difficulty_hard = false;
                difficulty_insane = false;
            }
            else if (rb_hard.Checked == true)
            {
                difficulty_easy = false;
                difficulty_hard = true;
                difficulty_insane = false;
            }
            else if (rb_insane.Checked == true)
            {
                difficulty_easy = false;
                difficulty_hard = false;
                difficulty_insane = true;
            }

            //setting up sound effects settings
            if (rb_sound_E_on.Checked == true)
            {
                sound_e_on = true;
            }

            //setting up music settings
            if (rb_muisc_on.Checked == true)
            {
                music_on = true;
            }
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //To quit the game
            Application.Exit(); 
        }
    }
}
