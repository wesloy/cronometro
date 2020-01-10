using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cronometro
{
    public partial class frmCronometro : Form
    {

        DateTime DataHoraAbertura;
        TimeSpan DiferencaDataHora;
        string pausaRegresiiva = "00:00:00";
        bool alterarCor = false;

        public frmCronometro()
        {
            InitializeComponent();
        }


        private void btIniciar_Click(object sender, EventArgs e)
        {

            if (rbProgressivo.Checked == true)
            {
                if (DiferencaDataHora.ToString() == "00:00:00" && lbCronometro.Text == "00:00:00")
                {
                    DataHoraAbertura = DateTime.Now.ToLocalTime();
                }
                else
                {
                    DataHoraAbertura = DateTime.Parse((DateTime.Now.ToLocalTime()).Subtract(DateTime.Parse(lbCronometro.Text)).ToString(@"hh\:mm\:ss"));
                }
            }


            if (rbRegressivo.Checked == true)
            {

                if (txtRegressivo.Text == "00:00:00" || txtRegressivo.Text == "  :  :")
                {
                    MessageBox.Show("É necessário fornecer um valor válido para o cronômetro regressivo!", "Cronômetro", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    return;
                }


                if (pausaRegresiiva == "00:00:00")
                {
                    lbCronometro.Text = txtRegressivo.Text;
                } else
                {
                    lbCronometro.Text = pausaRegresiiva;
                    pausaRegresiiva = "00:00:00";
                }                
            }

            if (cbSilencioso.Checked == false)
            {
                sonorizacao(1);
            }

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (rbProgressivo.Checked == true)
            {
                DiferencaDataHora = (DateTime.Now).Subtract(DataHoraAbertura);
                if (DiferencaDataHora.Seconds > 0)
                {
                    //"{0:HH:MM:ss}"
                    lbCronometro.Text = DiferencaDataHora.ToString(@"hh\:mm\:ss");
                }
            }


            if (rbRegressivo.Checked == true)
            {

                var tempoFracionado = lbCronometro.Text.Split(':');
                var segundos = int.Parse(tempoFracionado[2]);
                var minutos = int.Parse(tempoFracionado[1]);
                var horas = int.Parse(tempoFracionado[0]);

                if (segundos > 0 || minutos > 0 || horas > 0)
                {
                    if (minutos >= 0 && horas >= 0)
                    {
                        if(minutos == 0 && horas > 0)
                        {
                            minutos = 59;
                            horas -= 1;
                        } else if  (segundos == 0)
                        {
                            minutos -= 1;
                        }                        
                    } 

                    if (segundos == 0)
                    {
                        segundos = 59;
                    } else
                    {
                        segundos -= 1;
                    }

                }
                //else if (segundos == 0 && minutos == 0 && horas > 0)
                //{
                //    horas -= 1;
                //}

                //exibindo valor final e testanto se o tempo zerou
                if (segundos == 0 && minutos == 0 && horas == 0)
                {
                    timer.Stop();
                    if (cbSilencioso.Checked == false)
                    {
                        sonorizacao(5);
                    }
                }

                lbCronometro.Text = horas.ToString("00") + ":" + minutos.ToString("00") + ":" + segundos.ToString("00");
            }


            if (cbAlertar.Checked == true)
            {

                DateTime tempoCronometro = DateTime.Parse(lbCronometro.Text);
                DateTime tempoAlerta = DateTime.Parse(txtAlerta.Text);

                if (rbProgressivo.Checked == true)
                {
                    if (tempoCronometro >= tempoAlerta)
                    {
                        alterarCor = true;
                    }
                }

                if (rbRegressivo.Checked == true)
                {
                    if (tempoCronometro <= tempoAlerta)
                    {
                        alterarCor = true;
                    }
                }

     
                if (lbCronometro.BackColor == Color.Red && alterarCor == true)
                {
                    lbCronometro.BackColor = Color.Black;
                } else if (lbCronometro.BackColor == Color.Black && alterarCor == true)
                {
                    lbCronometro.BackColor = Color.Red;
                }                
            }


        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

            if (rbProgressivo.Checked == true)
            {
                DiferencaDataHora = (DateTime.Now).Subtract(DataHoraAbertura);
            }
                

            if (rbRegressivo.Checked == true)
            {
                pausaRegresiiva = lbCronometro.Text;
            }


            if (cbSilencioso.Checked == false)
            {
                sonorizacao(1);
            }

            timer.Stop();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            lbCronometro.Text = "00:00:00";
            lbCronometro.BackColor = Color.Black;
            alterarCor = false;
            timer.Stop();
        }

        private void sonorizacao ( int repeticoes)
        {
            for (int i = 1; i < repeticoes; i++)
            {
                SystemSounds.Asterisk.Play();
                SystemSounds.Beep.Play();
            }

        }

    }
}
