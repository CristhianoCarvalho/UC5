﻿namespace MarioLikeGame
{
    partial class frmTelaJogo
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            this.pbWin = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.personagem = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSuperior.Controls.Add(this.btnRestart);
            this.pnlSuperior.Controls.Add(this.lblPontos);
            this.pnlSuperior.Controls.Add(this.lblTempo);
            this.pnlSuperior.Location = new System.Drawing.Point(-1, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1920, 70);
            this.pnlSuperior.TabIndex = 0;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Lime;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Blue;
            this.btnRestart.Location = new System.Drawing.Point(483, 6);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(219, 58);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Voltar ao Menu";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.Blue;
            this.lblPontos.Location = new System.Drawing.Point(914, 6);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(152, 46);
            this.lblPontos.TabIndex = 0;
            this.lblPontos.Text = "Pontos";
            this.lblPontos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.Blue;
            this.lblTempo.Location = new System.Drawing.Point(13, 6);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(149, 46);
            this.lblTempo.TabIndex = 0;
            this.lblTempo.Text = "Tempo";
            this.lblTempo.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(432, 370);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 63);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Tag = "gameOver";
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // pbGameOver
            // 
            this.pbGameOver.Image = global::MarioLikeGame.Properties.Resources.gameover;
            this.pbGameOver.Location = new System.Drawing.Point(482, 327);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(200, 180);
            this.pbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGameOver.TabIndex = 5;
            this.pbGameOver.TabStop = false;
            this.pbGameOver.Tag = "pbGameOver";
            this.pbGameOver.Visible = false;
            // 
            // pbWin
            // 
            this.pbWin.Image = global::MarioLikeGame.Properties.Resources.tenor;
            this.pbWin.Location = new System.Drawing.Point(419, 283);
            this.pbWin.Name = "pbWin";
            this.pbWin.Size = new System.Drawing.Size(314, 270);
            this.pbWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbWin.TabIndex = 4;
            this.pbWin.TabStop = false;
            this.pbWin.Tag = "pbGameOver";
            this.pbWin.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::MarioLikeGame.Properties.Resources.kisspng_new_super_mario_bros_u_bowser_beetle_5ad1f32e0cdb43_3592346115237087180527;
            this.pictureBox9.Location = new System.Drawing.Point(197, 251);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 2;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "inimigo";
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox19.Image = global::MarioLikeGame.Properties.Resources.kisspng_new_super_mario_bros_u_bowser_beetle_5ad1f32e0cdb43_3592346115237087180527;
            this.pictureBox19.Location = new System.Drawing.Point(859, 453);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(100, 100);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 2;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "inimigo";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MarioLikeGame.Properties.Resources.kisspng_new_super_mario_bros_u_paper_mario_beetle_5abb4759a1dad9_378294461522222937663;
            this.pictureBox7.Location = new System.Drawing.Point(433, 468);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 70);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "inimigo";
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox17.Image = global::MarioLikeGame.Properties.Resources.kisspng_mario_bros_bowser_new_super_mario_bros_super_mari_filebowser_png_wikipedia_5be19bc035cd85_6759633715415121282204;
            this.pictureBox17.Location = new System.Drawing.Point(840, 251);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(164, 170);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 2;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "inimigo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MarioLikeGame.Properties.Resources.kisspng_super_mario_world_new_super_mario_bros_wii_super_time_bomb_5abeeeff023e92_7921074015224624630092;
            this.pictureBox3.Location = new System.Drawing.Point(1075, 683);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "inimigo";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::MarioLikeGame.Properties.Resources.kisspng_super_mario_world_new_super_mario_bros_wii_super_time_bomb_5abeeeff023e92_7921074015224624630092;
            this.pictureBox5.Location = new System.Drawing.Point(207, 98);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "inimigo";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Image = global::MarioLikeGame.Properties.Resources.kisspng_mario_kart_wii_super_mario_bros_new_super_mario_b_dead_fish_5ac87f99525176_9005307915230893053372;
            this.pictureBox15.Location = new System.Drawing.Point(668, 108);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(50, 60);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 2;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "inimigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MarioLikeGame.Properties.Resources.kisspng_mario_kart_wii_super_mario_bros_new_super_mario_b_dead_fish_5ac87f99525176_9005307915230893053372;
            this.pictureBox1.Location = new System.Drawing.Point(25, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "inimigo";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MarioLikeGame.Properties.Resources.kisspng_new_super_mario_bros_mario_bros_video_games_ninte_5b9a8122180912_0395698915368522580985;
            this.pictureBox4.Location = new System.Drawing.Point(25, 679);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "coletaveis2";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = global::MarioLikeGame.Properties.Resources.kisspng_new_super_mario_bros_mario_bros_video_games_ninte_5b9a8122180912_0395698915368522580985;
            this.pictureBox14.Location = new System.Drawing.Point(663, 468);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(65, 65);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 2;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "coletaveis2";
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::MarioLikeGame.Properties.Resources.Cogumelo_Vermelho;
            this.pictureBox23.Location = new System.Drawing.Point(433, 679);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(60, 60);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox23.TabIndex = 2;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "coletaveis2";
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.Image = global::MarioLikeGame.Properties.Resources.Cogumelo_Vermelho;
            this.pictureBox20.Location = new System.Drawing.Point(1100, 108);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(60, 60);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 2;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "coletaveis2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox2.Location = new System.Drawing.Point(20, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "coletaveis";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox18.Location = new System.Drawing.Point(894, 679);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(65, 65);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 2;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "coletaveis";
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox24.Location = new System.Drawing.Point(1084, 472);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(65, 65);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox24.TabIndex = 2;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "coletaveis";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox10.Location = new System.Drawing.Point(433, 268);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(65, 65);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "coletaveis";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox13.Location = new System.Drawing.Point(663, 268);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(65, 65);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 2;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "coletaveis";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox12.Location = new System.Drawing.Point(668, 679);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(65, 65);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 2;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "coletaveis";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox8.Location = new System.Drawing.Point(210, 679);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(65, 65);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 2;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "coletaveis";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox6.Location = new System.Drawing.Point(210, 464);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "coletaveis";
            // 
            // pictureBox21
            // 
            this.pictureBox21.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox21.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox21.Location = new System.Drawing.Point(1084, 268);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(65, 65);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox21.TabIndex = 2;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "coletaveis";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox16.Location = new System.Drawing.Point(888, 108);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(65, 65);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 2;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "coletaveis";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = global::MarioLikeGame.Properties.Resources._5a386abf8b8445_0588402815136467835715;
            this.pictureBox11.Location = new System.Drawing.Point(440, 108);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(65, 65);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "coletaveis";
            // 
            // personagem
            // 
            this.personagem.BackColor = System.Drawing.Color.Transparent;
            this.personagem.Image = global::MarioLikeGame.Properties.Resources.Raccoon_Mario;
            this.personagem.Location = new System.Drawing.Point(12, 76);
            this.personagem.Name = "personagem";
            this.personagem.Size = new System.Drawing.Size(79, 94);
            this.personagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personagem.TabIndex = 1;
            this.personagem.TabStop = false;
            this.personagem.Click += new System.EventHandler(this.personagem_Click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::MarioLikeGame.Properties.Resources.fundo2;
            this.pictureBox22.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox22.TabIndex = 6;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            // 
            // frmTelaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 765);
            this.Controls.Add(this.pbGameOver);
            this.Controls.Add(this.pbWin);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.personagem);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pictureBox22);
            this.MinimizeBox = false;
            this.Name = "frmTelaJogo";
            this.Text = "MarioLike";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelaJogo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTelaJogo_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmTelaJogo_KeyUp);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox personagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox pbWin;
        private System.Windows.Forms.PictureBox pbGameOver;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox22;
    }
}

