using System;
using System.Collections.Generic;
using System.Text;

namespace MarioLikeGame.Model
{
    public class Placar
    {
        private int idJogador;
        private string nomeJogador;
        private int scoreJogador;
        private DateTime dataScorejogador;
        private string tempoJogador;

        public Placar()
        {
        }

        public Placar(int idJogador, string nomeJogador, int scoreJogador, DateTime dataScorejogador, string tempoJogador)
        {
            this.IdJogador = idJogador;
            this.Nome = nomeJogador;
            this.Pontos = scoreJogador;
            this.DataHora = dataScorejogador;
            this.Tempo = tempoJogador;
        }

        public int IdJogador { get => idJogador; set => idJogador = value; }
        public string Nome { get => nomeJogador; set => nomeJogador = value; }
        public int Pontos { get => scoreJogador; set => scoreJogador = value; }
        public DateTime DataHora { get => dataScorejogador; set => dataScorejogador = value; }
        public string Tempo { get => tempoJogador; set => tempoJogador = value; }
    }
}
