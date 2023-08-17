namespace WindowsFormsApplication1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_Difficulty = new System.Windows.Forms.Label();
            this.rb_easy = new System.Windows.Forms.RadioButton();
            this.rb_hard = new System.Windows.Forms.RadioButton();
            this.rb_insane = new System.Windows.Forms.RadioButton();
            this.P_Sound_Effects = new System.Windows.Forms.Panel();
            this.rb_sound_E_off = new System.Windows.Forms.RadioButton();
            this.rb_sound_E_on = new System.Windows.Forms.RadioButton();
            this.lbl_sound_effects = new System.Windows.Forms.Label();
            this.P_Music = new System.Windows.Forms.Panel();
            this.lbl_Music = new System.Windows.Forms.Label();
            this.rb_muisc_on = new System.Windows.Forms.RadioButton();
            this.rb_muisc_off = new System.Windows.Forms.RadioButton();
            this.p_Difficulty = new System.Windows.Forms.Panel();
            this.P_Sound_Effects.SuspendLayout();
            this.P_Music.SuspendLayout();
            this.p_Difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(245, 456);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(314, 74);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(245, 78);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(314, 74);
            this.btn_Start.TabIndex = 12;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_Difficulty
            // 
            this.lbl_Difficulty.AutoSize = true;
            this.lbl_Difficulty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Difficulty.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Difficulty.ForeColor = System.Drawing.Color.White;
            this.lbl_Difficulty.Location = new System.Drawing.Point(61, 21);
            this.lbl_Difficulty.Name = "lbl_Difficulty";
            this.lbl_Difficulty.Size = new System.Drawing.Size(139, 33);
            this.lbl_Difficulty.TabIndex = 5;
            this.lbl_Difficulty.Text = "Difficulty ";
            // 
            // rb_easy
            // 
            this.rb_easy.AutoSize = true;
            this.rb_easy.BackColor = System.Drawing.Color.Transparent;
            this.rb_easy.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_easy.ForeColor = System.Drawing.Color.White;
            this.rb_easy.Location = new System.Drawing.Point(17, 76);
            this.rb_easy.Name = "rb_easy";
            this.rb_easy.Size = new System.Drawing.Size(77, 33);
            this.rb_easy.TabIndex = 2;
            this.rb_easy.TabStop = true;
            this.rb_easy.Text = "Easy";
            this.rb_easy.UseVisualStyleBackColor = false;
            // 
            // rb_hard
            // 
            this.rb_hard.AutoSize = true;
            this.rb_hard.BackColor = System.Drawing.Color.Transparent;
            this.rb_hard.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_hard.ForeColor = System.Drawing.Color.White;
            this.rb_hard.Location = new System.Drawing.Point(136, 76);
            this.rb_hard.Name = "rb_hard";
            this.rb_hard.Size = new System.Drawing.Size(84, 33);
            this.rb_hard.TabIndex = 3;
            this.rb_hard.TabStop = true;
            this.rb_hard.Text = "Hard";
            this.rb_hard.UseVisualStyleBackColor = false;
            // 
            // rb_insane
            // 
            this.rb_insane.AutoSize = true;
            this.rb_insane.BackColor = System.Drawing.Color.Transparent;
            this.rb_insane.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_insane.ForeColor = System.Drawing.Color.White;
            this.rb_insane.Location = new System.Drawing.Point(66, 133);
            this.rb_insane.Name = "rb_insane";
            this.rb_insane.Size = new System.Drawing.Size(99, 33);
            this.rb_insane.TabIndex = 4;
            this.rb_insane.TabStop = true;
            this.rb_insane.Text = "Insane";
            this.rb_insane.UseVisualStyleBackColor = false;
            // 
            // P_Sound_Effects
            // 
            this.P_Sound_Effects.BackColor = System.Drawing.Color.Transparent;
            this.P_Sound_Effects.Controls.Add(this.rb_sound_E_off);
            this.P_Sound_Effects.Controls.Add(this.rb_sound_E_on);
            this.P_Sound_Effects.Controls.Add(this.lbl_sound_effects);
            this.P_Sound_Effects.Location = new System.Drawing.Point(12, 263);
            this.P_Sound_Effects.Name = "P_Sound_Effects";
            this.P_Sound_Effects.Size = new System.Drawing.Size(234, 132);
            this.P_Sound_Effects.TabIndex = 17;
            // 
            // rb_sound_E_off
            // 
            this.rb_sound_E_off.AutoSize = true;
            this.rb_sound_E_off.BackColor = System.Drawing.Color.Transparent;
            this.rb_sound_E_off.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sound_E_off.ForeColor = System.Drawing.Color.White;
            this.rb_sound_E_off.Location = new System.Drawing.Point(108, 78);
            this.rb_sound_E_off.Name = "rb_sound_E_off";
            this.rb_sound_E_off.Size = new System.Drawing.Size(65, 31);
            this.rb_sound_E_off.TabIndex = 13;
            this.rb_sound_E_off.TabStop = true;
            this.rb_sound_E_off.Text = "Off";
            this.rb_sound_E_off.UseVisualStyleBackColor = false;
            // 
            // rb_sound_E_on
            // 
            this.rb_sound_E_on.AutoSize = true;
            this.rb_sound_E_on.BackColor = System.Drawing.Color.Transparent;
            this.rb_sound_E_on.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sound_E_on.ForeColor = System.Drawing.Color.White;
            this.rb_sound_E_on.Location = new System.Drawing.Point(29, 78);
            this.rb_sound_E_on.Name = "rb_sound_E_on";
            this.rb_sound_E_on.Size = new System.Drawing.Size(58, 31);
            this.rb_sound_E_on.TabIndex = 15;
            this.rb_sound_E_on.TabStop = true;
            this.rb_sound_E_on.Text = "On";
            this.rb_sound_E_on.UseVisualStyleBackColor = false;
            // 
            // lbl_sound_effects
            // 
            this.lbl_sound_effects.AutoSize = true;
            this.lbl_sound_effects.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sound_effects.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sound_effects.ForeColor = System.Drawing.Color.White;
            this.lbl_sound_effects.Location = new System.Drawing.Point(24, 23);
            this.lbl_sound_effects.Name = "lbl_sound_effects";
            this.lbl_sound_effects.Size = new System.Drawing.Size(186, 33);
            this.lbl_sound_effects.TabIndex = 14;
            this.lbl_sound_effects.Text = "Sound Effects";
            // 
            // P_Music
            // 
            this.P_Music.BackColor = System.Drawing.Color.Transparent;
            this.P_Music.Controls.Add(this.lbl_Music);
            this.P_Music.Controls.Add(this.rb_muisc_on);
            this.P_Music.Controls.Add(this.rb_muisc_off);
            this.P_Music.Location = new System.Drawing.Point(554, 263);
            this.P_Music.Name = "P_Music";
            this.P_Music.Size = new System.Drawing.Size(234, 132);
            this.P_Music.TabIndex = 16;
            // 
            // lbl_Music
            // 
            this.lbl_Music.AutoSize = true;
            this.lbl_Music.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Music.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Music.ForeColor = System.Drawing.Color.White;
            this.lbl_Music.Location = new System.Drawing.Point(80, 23);
            this.lbl_Music.Name = "lbl_Music";
            this.lbl_Music.Size = new System.Drawing.Size(88, 33);
            this.lbl_Music.TabIndex = 6;
            this.lbl_Music.Text = "Music";
            // 
            // rb_muisc_on
            // 
            this.rb_muisc_on.AutoSize = true;
            this.rb_muisc_on.BackColor = System.Drawing.Color.Transparent;
            this.rb_muisc_on.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_muisc_on.ForeColor = System.Drawing.Color.White;
            this.rb_muisc_on.Location = new System.Drawing.Point(46, 78);
            this.rb_muisc_on.Name = "rb_muisc_on";
            this.rb_muisc_on.Size = new System.Drawing.Size(58, 31);
            this.rb_muisc_on.TabIndex = 7;
            this.rb_muisc_on.TabStop = true;
            this.rb_muisc_on.Text = "On";
            this.rb_muisc_on.UseVisualStyleBackColor = false;
            // 
            // rb_muisc_off
            // 
            this.rb_muisc_off.AutoSize = true;
            this.rb_muisc_off.BackColor = System.Drawing.Color.Transparent;
            this.rb_muisc_off.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_muisc_off.ForeColor = System.Drawing.Color.White;
            this.rb_muisc_off.Location = new System.Drawing.Point(138, 78);
            this.rb_muisc_off.Name = "rb_muisc_off";
            this.rb_muisc_off.Size = new System.Drawing.Size(65, 31);
            this.rb_muisc_off.TabIndex = 8;
            this.rb_muisc_off.TabStop = true;
            this.rb_muisc_off.Text = "Off";
            this.rb_muisc_off.UseVisualStyleBackColor = false;
            // 
            // p_Difficulty
            // 
            this.p_Difficulty.BackColor = System.Drawing.Color.Transparent;
            this.p_Difficulty.Controls.Add(this.lbl_Difficulty);
            this.p_Difficulty.Controls.Add(this.rb_easy);
            this.p_Difficulty.Controls.Add(this.rb_insane);
            this.p_Difficulty.Controls.Add(this.rb_hard);
            this.p_Difficulty.Location = new System.Drawing.Point(282, 170);
            this.p_Difficulty.Name = "p_Difficulty";
            this.p_Difficulty.Size = new System.Drawing.Size(234, 187);
            this.p_Difficulty.TabIndex = 18;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 600);
            this.Controls.Add(this.p_Difficulty);
            this.Controls.Add(this.P_Music);
            this.Controls.Add(this.P_Sound_Effects);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.P_Sound_Effects.ResumeLayout(false);
            this.P_Sound_Effects.PerformLayout();
            this.P_Music.ResumeLayout(false);
            this.P_Music.PerformLayout();
            this.p_Difficulty.ResumeLayout(false);
            this.p_Difficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Difficulty;
        private System.Windows.Forms.RadioButton rb_easy;
        private System.Windows.Forms.RadioButton rb_hard;
        private System.Windows.Forms.RadioButton rb_insane;
        private System.Windows.Forms.Panel P_Sound_Effects;
        private System.Windows.Forms.RadioButton rb_sound_E_off;
        private System.Windows.Forms.RadioButton rb_sound_E_on;
        private System.Windows.Forms.Label lbl_sound_effects;
        private System.Windows.Forms.Panel P_Music;
        private System.Windows.Forms.Label lbl_Music;
        private System.Windows.Forms.RadioButton rb_muisc_on;
        private System.Windows.Forms.RadioButton rb_muisc_off;
        private System.Windows.Forms.Panel p_Difficulty;
    }
}

