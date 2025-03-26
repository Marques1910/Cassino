using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaçaNiquel
{
    public partial class frmCacaNiquel : Form
    {
        private Random sorteio = new Random();
        private int niquel1, niquel2, niquel3;
        private int contaGiro = 0;
        private int contaNiquel = 1;
        public frmCacaNiquel()
        {
            InitializeComponent();
        }

        private void tmrSorteioGeral_Tick(object sender, EventArgs e)
        {
            MostraNiquel();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            btnJogar.Text = "&STOP";
            //contaGiro = 0;
            tmrNiquel.Enabled = true;

        }

        private void tmrNiquel_Tick(object sender, EventArgs e)
        {
            if (contaNiquel == 1)
            {
                niquel1 = sorteio.Next(1,10);
                lblNiquel1.Text = niquel1.ToString();
            }

            else if (contaNiquel == 2)
            {
                niquel2 = sorteio.Next(1, 10);
                lblNiquel2.Text = niquel2.ToString();
            }


            else if (contaNiquel == 3)
            {
                niquel3 = sorteio.Next(1, 10);
                lblNiquel3.Text = niquel3.ToString();
            }

            else
            {
                tmrNiquel.Enabled = false;
                VerificacaoNiquel();
                contaNiquel = 1;
            }



            if (contaGiro == 10)
            {
                contaNiquel++;
                contaGiro = 0;
            }

            contaGiro++;
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            //tmrSorteioGeral.Enabled = true;
            MostraNiquel();
            VerificacaoNiquel();
        }
        private void MostraNiquel()
        {
            niquel1 = sorteio.Next(1, 10);
            niquel2 = sorteio.Next(1, 10);
            niquel3 = sorteio.Next(1, 10);

            lblNiquel1.Text = niquel1.ToString();
            lblNiquel2.Text = niquel2.ToString();
            lblNiquel3.Text = niquel3.ToString();   
        }

        private void VerificacaoNiquel()
        {

            if (niquel1 == niquel2 && niquel2 == niquel3)
            {
                MessageBox.Show("Parabens vc ganhou no jogo do tigrinho\n\n" +
                    "Sequencia: " + niquel1.ToString() + " - " +
                                    niquel2.ToString() + " - " +
                                    niquel3.ToString(),
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNiquel1.Text = String.Empty;
                lblNiquel2.Text = String.Empty;
                lblNiquel3.Text = String.Empty;
                btnJogar.Text = "&Jogar";
            }

            else if (niquel1 != niquel2 && niquel2 != niquel3 && niquel1 != niquel3)
            {
                MessageBox.Show("que pessimo\n\n" +
                    "Sequencia: " + niquel1.ToString() + " - " +
                                    niquel2.ToString() + " - " +
                                    niquel3.ToString(),
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNiquel1.Text = String.Empty;
                lblNiquel2.Text = String.Empty;
                lblNiquel3.Text = String.Empty;
                btnJogar.Text = "&Jogar";
            }

            else
            {
                MessageBox.Show("dois iguais parabens\n\n" +
                    "Sequencia: " + niquel1.ToString() + " - " +
                                    niquel2.ToString() + " - " +
                                    niquel3.ToString(),
                    "Tigrinho Wins !!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblNiquel1.Text = String.Empty;
                lblNiquel2.Text = String.Empty;
                lblNiquel3.Text = String.Empty;
                btnJogar.Text = "&Jogar";
            }

        }
    }
}
