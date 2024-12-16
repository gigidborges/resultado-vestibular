using System;
using System.Windows.Forms;

namespace Exe025
{
    public partial class FrmExe025 : Form
    {
        //Declaração do Array da lista de classificados
        int[] listaClassificados = new int[10];


        public FrmExe025()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNumero.Text = "";
            LblResultado.Text = "";
            TxtNumero.Focus();
        }

        private void FrmExe025_Load(object sender, EventArgs e)
        {
            //Conteúdo do Array - Lista das inscrições CLASSIFICADAS
            listaClassificados[0] = 10514;
            listaClassificados[1] = 30343;
            listaClassificados[2] = 8240;
            listaClassificados[3] = 3125;
            listaClassificados[4] = 50525;
            listaClassificados[5] = 23289;
            listaClassificados[6] = 7310;
            listaClassificados[7] = 9281;
            listaClassificados[8] = 49524;
            listaClassificados[9] = 33001;
        }

        private void BtnConsultar1_Click(object sender, EventArgs e)
        {
            try
            {
                int numInscricao = Convert.ToInt32(TxtNumero.Text);

                for (int x = 0; x <= 9; x++)
                {
                    if (listaClassificados[x] == numInscricao)
                    {
                        x++;
                        LblResultado.Text = $"Parabéns!!!" + 
                            $"Você está classificado" + 
                            $"{x.ToString()}a. posição!!!";
                        return;
                    }
                }
                LblResultado.Text = "Lista de espera!!!";

            }

            catch
            {

            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int numInscricao = Convert.ToInt32(TxtNumero.Text);

                //localiza a posicao do candidato no array se não existir o indice será = -1
                int posicao = Array.IndexOf(listaClassificados, numInscricao);

                if (posicao < 0)
                {
                    LblResultado.Text = "Lista de espera!!";

                }

                else
                {
                    posicao += 1;
                    LblResultado.Text = $"Parabéns!!Você está classificado na" +
                        $"{posicao.ToString()} posição!!";
                }
            }
            catch
            {
                MessageBox.Show("Digite somente números!!!", "Atenção");
                TxtNumero.Text = "";
                TxtNumero.Focus();
            }
            

        }
    }
}

