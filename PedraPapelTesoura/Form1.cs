using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    {
        Image[] imgPCU = new Image[]
        {
            Properties.Resources.PedraC,
            Properties.Resources.PapelC, 
            Properties.Resources.TesouraC,

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LbDescricaoCPU_Click(object sender, EventArgs e)
        {

        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            PicJogador.Image = bt.BackgroundImage;
            Jogada jogadaJogador = RetornaJogadaDoJogador(Convert.ToInt32(bt.Tag));
            Jogada jogadaAdversario = RetornaJogadaDoAdversario();
            Resultado resultado = RetornaGanhador(jogadaJogador, jogadaAdversario);

            if (resultado == Resultado.VitoriaCPU) {
                LbPtCPU.Text = (int.Parse(LbPtCPU.Text) + 1).ToString();
            } else if (resultado == Resultado.VitoriaJogador) { 
                  LbPtJogador.Text = (int.Parse(LbPtCPU.Text) + 1).ToString();
            }
        }

       

        private Resultado RetornaGanhador(Jogada jogador, Jogada adversaio)
        {
            if (jogador == Jogada.Pedra)
            {
                if (adversaio == Jogada.Papel)
                {
                    return Resultado.VitoriaCPU;
                }
                else if (adversaio == Jogada.Tesoura)
                {
                    return Resultado.VitoriaJogador;
                }
            }
            else if (jogador == Jogada.Papel)
            {
                if (adversaio == Jogada.Pedra)
                {
                    return Resultado.VitoriaJogador;
                }
                else if (adversaio == Jogada.Tesoura)
                {
                    return Resultado.VitoriaCPU;
                }
            }
            else {
                if (adversaio == Jogada.Pedra)
                {
                    return Resultado.VitoriaCPU;
                }
                else if (adversaio == Jogada.Papel)
                {
                    return Resultado.VitoriaJogador;
                }
            }

            return Resultado.Empata;
           
            
        }
        private Jogada RetornaJogadaDoJogador(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadaDoAdversario()
        { 
            Random rnd = new Random();
            int escolha = rnd.Next(3);
            PicCPU.Image = imgPCU[escolha];
            return (Jogada)escolha;
        }
    }

    enum Jogada
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }

    enum Resultado
    { 
        VitoriaJogador,
        VitoriaCPU,
        Empata
    }
}
