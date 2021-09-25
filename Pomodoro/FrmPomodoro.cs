using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pomodoro
{
    public partial class FrmPomodoro : Form
    {
        private double segundos;
        private double minutos;
        private double decimas;
        private int pomodoro;
        private int cantPomodoros;
        private bool descanso;
        
        public FrmPomodoro()
        {
            InitializeComponent();
        }

        private void FrmPomodoro_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            PnlTimer.Visible = false;
            CboTmpPomodoro.SelectedIndex = 4;
            CboDesCorto.SelectedIndex = 4;
            CboDesLargo.SelectedIndex = 1;
            CboCantidad.SelectedIndex = 2;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            PnlTimer.Visible = true;
            cantPomodoros = Convert.ToInt32(CboCantidad.SelectedItem);
            pomodoro = 0;
            descanso = true;
            menuStrip1.Visible = false;
            PnlTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            Paso(false);
            VisibilidadLabels(cantPomodoros);
        }

        private void IniciarTimer()
        {
            if(descanso && pomodoro < cantPomodoros)
            {
                minutos = Convert.ToInt32(CboDesCorto.SelectedItem);
            }
            else if (descanso && pomodoro == cantPomodoros)
            {
                minutos = Convert.ToInt32(CboDesLargo.SelectedItem);
            }
            else
            {
                minutos = Convert.ToInt32(CboTmpPomodoro.SelectedItem);
            }
            decimas = 10;
            segundos = 0;
            Timer.Start();
            LblMinutos.Text = minutos.ToString().Length < 2 ? "0" + minutos.ToString() : minutos.ToString();
            LblSegundos.Text = segundos.ToString().Length < 2 ? "0" + segundos.ToString() : segundos.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            decimas--;
            int dec = (int)Math.Round(decimas);
            if (dec == 0)
            {
                decimas = 10;
                Segundos();
            }
        }

        private void Segundos()
        {
            segundos--;
            if (segundos == -1)
            {
                segundos = 59;
                Minutos();
            }
            LblSegundos.Text = segundos.ToString().Length < 2 ? "0" + segundos.ToString() : segundos.ToString();
        }

        private void Minutos()
        {
            minutos--;
            if (minutos == -1)
            {
                Paso(true);
            }
            else
            {
                LblMinutos.Text = minutos.ToString().Length < 2 ? "0" + minutos.ToString() : minutos.ToString();
            }
        }

        private void BtnPaso_Click(object sender, EventArgs e)
        {
            Paso(false);
        }

        private void CambioTextoBtnPaso()
        {
            if (BtnPaso.Text == "Descanso")
            {
                BtnPaso.Text = "Pomodoro";
            }
            else
            {
                BtnPaso.Text = "Descanso";
            }
        }

        private void Paso(bool automatico)
        {
            CambioTextoBtnPaso();

            if (descanso == false)
            {
                descanso = true;
                CambioColorGreen();
            }
            else
            {
                pomodoro++;
                descanso = false;
                if (pomodoro > cantPomodoros)
                {
                    pomodoro = 1;
                }
                CambioColorRed();
            }           

            if (automatico)
            {
                PlaySonido();
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                this.Activate();
                this.CenterToScreen();
            }

            IniciarTimer();
        }

        private void CambioColorGreen()
        {
            switch (pomodoro)
            {
                case 1:
                    LblP1.BackColor = Color.Green;
                    break;
                case 2:
                    LblP2.BackColor = Color.Green;
                    break;
                case 3:
                    LblP3.BackColor = Color.Green;
                    break;
                case 4:
                    LblP4.BackColor = Color.Green;
                    break;
                case 5:
                    LblP5.BackColor = Color.Green;
                    break;
                case 6:
                    LblP6.BackColor = Color.Green;
                    break;
                case 7:
                    LblP7.BackColor = Color.Green;
                    break;
                case 8:
                    LblP8.BackColor = Color.Green;
                    break;
                default:
                    break;
            }
        }

        private void CambioColorRed()
        {
            switch (pomodoro)
            {
                case 1:
                    LblP1.BackColor = Color.Red;
                    LblP2.BackColor = Color.Empty;
                    LblP3.BackColor = Color.Empty;
                    LblP4.BackColor = Color.Empty;
                    LblP5.BackColor = Color.Empty;
                    LblP6.BackColor = Color.Empty;
                    LblP7.BackColor = Color.Empty;
                    LblP8.BackColor = Color.Empty;
                    break;
                case 2:
                    LblP2.BackColor = Color.Red;
                    break;
                case 3:
                    LblP3.BackColor = Color.Red;
                    break;
                case 4:
                    LblP4.BackColor = Color.Red;
                    break;
                case 5:
                    LblP5.BackColor = Color.Red;
                    break;
                case 6:
                    LblP6.BackColor = Color.Red;
                    break;
                case 7:
                    LblP7.BackColor = Color.Red;
                    break;
                case 8:
                    LblP8.BackColor = Color.Red;
                    break;
                default:
                    break;
            }
        }

        private void BtnPausePlay_Click(object sender, EventArgs e)
        {
            if (BtnPausePlay.Text == "Pause")
            {
                BtnPausePlay.Text = "Play";
                Timer.Stop();
            }
            else
            {
                BtnPausePlay.Text = "Pause";
                Timer.Start();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            PnlTimer.Visible = false;
            menuStrip1.Visible = true;
            Timer.Stop();
        }

        private void PlaySonido()
        {
            SoundPlayer Sonido = new SoundPlayer(Properties.Resources.Paso);
            Sonido.Play();
        }

        private void VisibilidadLabels(int cantidad)
        {
            LblP3.Visible = false;
            LblP4.Visible = false;
            LblP5.Visible = false;
            LblP6.Visible = false;
            LblP7.Visible = false;
            LblP8.Visible = false;
            switch (cantidad)
            {
                case 2:
                    Labels2();
                    break;
                case 3:
                    Labels3();
                    break;
                case 4:
                    Labels4();
                    break;
                case 5:
                    Labels5();
                    break;
                case 6:
                    Labels6();
                    break;
                case 7:
                    Labels7();
                    break;
                case 8:
                    Labels8();
                    break;
                default:
                    break;
            }
        }

        private void Labels2()
        {
            LblP1.Visible = true;
            LblP1.Location = new Point(203, 50);
            LblP2.Visible = true;
            LblP2.Location = new Point(254, 50);
        }
        private void Labels3()
        {
            LblP1.Visible = true;
            LblP1.Location = new Point(173, 50);
            LblP2.Visible = true;
            LblP2.Location = new Point(224, 50);
            LblP3.Visible = true;
            LblP3.Location = new Point(275, 50);
        }
        private void Labels4()
        {
            LblP1.Visible = true;
            LblP1.Location = new Point(152, 50);
            LblP2.Visible = true;
            LblP2.Location = new Point(203, 50);
            LblP3.Visible = true;
            LblP3.Location = new Point(254, 50);
            LblP4.Visible = true;
            LblP4.Location = new Point(305, 50);
        }
        private void Labels5()
        {
            LblP1.Visible = true;
            LblP1.Location = new Point(122, 50);
            LblP2.Visible = true;
            LblP2.Location = new Point(173, 50);
            LblP3.Visible = true;
            LblP3.Location = new Point(224, 50);
            LblP4.Visible = true;
            LblP4.Location = new Point(275, 50);
            LblP5.Visible = true;
            LblP5.Location = new Point(326, 50);
        }
        private void Labels6()
        {
            LblP1.Visible = true;
            LblP1.Location = new Point(101, 50);
            LblP2.Visible = true;
            LblP2.Location = new Point(152, 50);
            LblP3.Visible = true;
            LblP3.Location = new Point(203, 50);
            LblP4.Visible = true;
            LblP4.Location = new Point(254, 50);
            LblP5.Visible = true;
            LblP5.Location = new Point(305, 50);
            LblP6.Visible = true;
            LblP6.Location = new Point(356, 50);
        }
        private void Labels7()
        {
            LblP1.Visible = true;
            LblP1.Location = new Point(71, 50);
            LblP2.Visible = true;
            LblP2.Location = new Point(122, 50);
            LblP3.Visible = true;
            LblP3.Location = new Point(173, 50);
            LblP4.Visible = true;
            LblP4.Location = new Point(224, 50);
            LblP5.Visible = true;
            LblP5.Location = new Point(275, 50);
            LblP6.Visible = true;
            LblP6.Location = new Point(326, 50);
            LblP7.Visible = true;
            LblP7.Location = new Point(377, 50);
        }
        private void Labels8()
        {
            LblP1.Visible = true;
            LblP1.Location = new Point(50, 50);
            LblP2.Visible = true;
            LblP2.Location = new Point(101, 50);
            LblP3.Visible = true;
            LblP3.Location = new Point(152, 50);
            LblP4.Visible = true;
            LblP4.Location = new Point(203, 50);
            LblP5.Visible = true;
            LblP5.Location = new Point(254, 50);
            LblP6.Visible = true;
            LblP6.Location = new Point(305, 50);
            LblP7.Visible = true;
            LblP7.Location = new Point(356, 50);
            LblP8.Visible = true;
            LblP8.Location = new Point(407, 50);
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnlAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void BtnVolverEstadisticas_Click(object sender, EventArgs e)
        {
            PnlEstadisticas.Dock = System.Windows.Forms.DockStyle.None;
        }

        private void BtnVolverAyuda_Click(object sender, EventArgs e)
        {
            PnlAyuda.Dock = System.Windows.Forms.DockStyle.None;
        }
    }
}
