namespace MarioLikeGame
{
    partial class frmTelaInicial
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
            this.pnlTelaInicialSup = new System.Windows.Forms.Panel();
            this.pbMario1 = new System.Windows.Forms.PictureBox();
            this.pbMario2 = new System.Windows.Forms.PictureBox();
            this.lblNomeJogo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListaRecorde = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDigite = new System.Windows.Forms.TextBox();
            this.pnlTelaInicialSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecorde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTelaInicialSup
            // 
            this.pnlTelaInicialSup.BackColor = System.Drawing.Color.Coral;
            this.pnlTelaInicialSup.Controls.Add(this.pbMario1);
            this.pnlTelaInicialSup.Controls.Add(this.pbMario2);
            this.pnlTelaInicialSup.Controls.Add(this.lblNomeJogo);
            this.pnlTelaInicialSup.Location = new System.Drawing.Point(-1, 0);
            this.pnlTelaInicialSup.Name = "pnlTelaInicialSup";
            this.pnlTelaInicialSup.Size = new System.Drawing.Size(1920, 165);
            this.pnlTelaInicialSup.TabIndex = 1;
            // 
            // pbMario1
            // 
            this.pbMario1.Image = global::MarioLikeGame.Properties.Resources.MarioSMBW;
            this.pbMario1.Location = new System.Drawing.Point(23, 10);
            this.pbMario1.Name = "pbMario1";
            this.pbMario1.Size = new System.Drawing.Size(100, 144);
            this.pbMario1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMario1.TabIndex = 2;
            this.pbMario1.TabStop = false;
            // 
            // pbMario2
            // 
            this.pbMario2.Image = global::MarioLikeGame.Properties.Resources.MarioSMBW;
            this.pbMario2.Location = new System.Drawing.Point(1785, 10);
            this.pbMario2.Name = "pbMario2";
            this.pbMario2.Size = new System.Drawing.Size(100, 144);
            this.pbMario2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMario2.TabIndex = 2;
            this.pbMario2.TabStop = false;
            this.pbMario2.Click += new System.EventHandler(this.pbMario2_Click);
            // 
            // lblNomeJogo
            // 
            this.lblNomeJogo.AutoSize = true;
            this.lblNomeJogo.Font = new System.Drawing.Font("Showcard Gothic", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogo.ForeColor = System.Drawing.Color.Snow;
            this.lblNomeJogo.Location = new System.Drawing.Point(632, 41);
            this.lblNomeJogo.Name = "lblNomeJogo";
            this.lblNomeJogo.Size = new System.Drawing.Size(620, 83);
            this.lblNomeJogo.TabIndex = 3;
            this.lblNomeJogo.Text = "Mario Like Game";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(1511, 256);
            this.txtNome.MaxLength = 15;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(339, 53);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Player 1";
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(1578, 520);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(204, 115);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(1578, 686);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(204, 115);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbOpcoes.Location = new System.Drawing.Point(1555, 481);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(251, 342);
            this.gbOpcoes.TabIndex = 6;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(1480, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogador";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 961);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 80);
            this.panel1.TabIndex = 1;
            // 
            // dgvListaRecorde
            // 
            this.dgvListaRecorde.AllowUserToAddRows = false;
            this.dgvListaRecorde.AllowUserToDeleteRows = false;
            this.dgvListaRecorde.AllowUserToResizeColumns = false;
            this.dgvListaRecorde.AllowUserToResizeRows = false;
            this.dgvListaRecorde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaRecorde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaRecorde.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaRecorde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRecorde.Location = new System.Drawing.Point(22, 280);
            this.dgvListaRecorde.Name = "dgvListaRecorde";
            this.dgvListaRecorde.RowHeadersVisible = false;
            this.dgvListaRecorde.Size = new System.Drawing.Size(1393, 577);
            this.dgvListaRecorde.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarioLikeGame.Properties.Resources.super_mario_world_wallpapers1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 808);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtDigite
            // 
            this.txtDigite.BackColor = System.Drawing.Color.Red;
            this.txtDigite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDigite.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDigite.Location = new System.Drawing.Point(1491, 338);
            this.txtDigite.Name = "txtDigite";
            this.txtDigite.Size = new System.Drawing.Size(377, 26);
            this.txtDigite.TabIndex = 8;
            this.txtDigite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDigite.Visible = false;
            this.txtDigite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.txtDigite);
            this.Controls.Add(this.dgvListaRecorde);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTelaInicialSup);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "frmTelaInicial";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MarioLike";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            this.pnlTelaInicialSup.ResumeLayout(false);
            this.pnlTelaInicialSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecorde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTelaInicialSup;
        private System.Windows.Forms.PictureBox pbMario1;
        private System.Windows.Forms.PictureBox pbMario2;
        private System.Windows.Forms.Label lblNomeJogo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListaRecorde;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDigite;
    }
}