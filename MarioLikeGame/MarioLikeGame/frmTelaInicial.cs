using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarioLikeGame.DAL;

namespace MarioLikeGame
{
    public partial class frmTelaInicial : Form
    {

        List<System.Windows.Media.MediaPlayer> sounds = new List<System.Windows.Media.MediaPlayer>();
        public frmTelaInicial()
        {
            InitializeComponent();
            //playSound("smb_world_clear.wav");
            
            
        }

        private void PreencheGrid()
        {
            //Declarando a DAL
            GamerDal gamerDal;

            //Instancindo a DAL na construção do formulário
            gamerDal = new GamerDal();

            //Limpando o DataSource
            dgvListaRecorde.DataSource = null;

            //Listando a DAL
            dgvListaRecorde.DataSource = gamerDal.Listar();

            //Remover a coluna id_Jogador
            dgvListaRecorde.Columns.Remove("IdJogador");

            AlterarGrid();


        }

        private void AlterarGrid()
        {
            dgvListaRecorde.Columns[0].HeaderText = "Nome";
            dgvListaRecorde.Columns[1].HeaderText = "Pontos";
            dgvListaRecorde.Columns[2].HeaderText = "Data/Hora";
            dgvListaRecorde.Columns[3].HeaderText = "Tempo";

            //Altera Fonte, o tamanho e estilo do cabeçalho
            dgvListaRecorde.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 30, FontStyle.Regular);
            //Alterar a cor da coluna
            dgvListaRecorde.DefaultCellStyle.ForeColor = Color.Blue;
            //Alterar o alinhamento do título das colunas
            dgvListaRecorde.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListaRecorde.AutoSize = true;
            //Desabilitar o estilo do header para que as alterações surtam efeito
            dgvListaRecorde.EnableHeadersVisualStyles = false;
            //Alterar a fonte da primeira linha, apontando o campeão
            
            if (dgvListaRecorde.RowCount > 0)
            {
                dgvListaRecorde.CurrentRow.DefaultCellStyle.BackColor = Color.OrangeRed;
            }

            //Alterar a fonte da grid
            dgvListaRecorde.DefaultCellStyle.Font = new Font("Open Sans", 30, FontStyle.Regular);
            //Alterar alinhamento das celulas
            dgvListaRecorde.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Alterar a cor da célula selecionada
            dgvListaRecorde.DefaultCellStyle.SelectionBackColor = Color.OrangeRed;
            //Alterar a cor do fundo da grid
            dgvListaRecorde.DefaultCellStyle.BackColor = Color.Blue;
            //Alterar a cor da fonte da grid
            dgvListaRecorde.DefaultCellStyle.ForeColor = Color.White;
            
        }

        private void pbMario2_Click(object sender, EventArgs e)
        {

        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {
            
            
            
            //Preencher o Grid
            PreencheGrid();
            

            //Setar o foco para o TextBox: nome do jogador
            txtNome.Focus();
            txtNome.Select();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            if(txtNome.Text.Trim() == string.Empty)
            {
                txtDigite.Text = "Digite o nome ou não vai JOGAR!";
                txtDigite.Visible = true;
                txtNome.Focus();
            }
            else
            {
                //Não exibir a instância atual da classe
                this.Visible = false;
                //Cria uma nova instância do frmTelaJogo()
                var frm = new frmTelaJogo();
                //Pega o nome do Jogador e envia para o Form1
                frm.nomeGamer = txtNome.Text;
                txtDigite.Visible = false;
                //Exibir p formulário
                frm.ShowDialog();

                //Exibir a nova instância da classe
                this.Visible = true;
                PreencheGrid();
            }
            
            
        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playSound(string nome)
        {
            string url = Application.StartupPath + @"\" + nome;
            var sound = new System.Windows.Media.MediaPlayer();
            sound.Open(new Uri(url));
            sound.Play();
            sounds.Add(sound);
        }
        private void stopSound()
        {
            for (int i = sounds.Count - 1; i >= 0; i--)
            {
                sounds[i].Stop();
                sounds.RemoveAt(i);
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
