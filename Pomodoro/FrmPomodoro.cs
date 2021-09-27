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


namespace MiPomodoro
{
    public partial class FrmPomodoro : Form
    {
        Pomodoros pomodoros;
        
        public FrmPomodoro()
        {
            InitializeComponent();
        }

        private void FrmPomodoro_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; // Por los hilos

            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            PnlTimer.Visible = false;
            CboTmpPomodoro.SelectedIndex = 4;
            CboDesCorto.SelectedIndex = 4;
            CboDesLargo.SelectedIndex = 1;
            CboCantidad.SelectedIndex = 2;
        }
        // -----------------------------------------------------------------------------------------------------------------
        //
        //
        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            pomodoros = new Pomodoros(Convert.ToInt32(CboCantidad.SelectedItem),
                                      Convert.ToInt32(CboDesCorto.SelectedItem),
                                      Convert.ToInt32(CboDesLargo.SelectedItem),
                                      Convert.ToInt32(CboTmpPomodoro.SelectedItem));
            pomodoros.evtSegundos += Evento_Actualizar;
            pomodoros.evtPaso += Evento_Paso;

            PnlTimer.Visible = true;
            PnlTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            menuStrip1.Visible = false;

            VisibilidadLabels(Convert.ToInt32(CboCantidad.SelectedItem));
            CambioAparienciaPaso();
            pomodoros.Iniciar();
        }

        private void Evento_Actualizar(object sender, EventArgs e)
        {
            LblMinutos.Text = pomodoros.Minutos.ToString().Length < 2 ? "0" + pomodoros.Minutos.ToString() : pomodoros.Minutos.ToString();
            LblSegundos.Text = pomodoros.Segundos.ToString().Length < 2 ? "0" + pomodoros.Segundos.ToString() : pomodoros.Segundos.ToString();
        }
        // -----------------------------------------------------------------------------------------------------------------
        // Lo del Paso
        //
        private void BtnPaso_Click(object sender, EventArgs e)
        {
            pomodoros.Paso();
            CambioAparienciaPaso();         
        }

        private void Evento_Paso(object sender, EventArgs e)
        {
            CambioAparienciaPaso();

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
            this.CenterToScreen();
        }

        private void CambioAparienciaPaso()
        {
            if (BtnPaso.Text == "Descanso")
            {
                BtnPaso.Text = "Pomodoro";
            }
            else
            {
                BtnPaso.Text = "Descanso";
            }

            if (pomodoros.Descanso)
                CambioColorGreen();
            else
                CambioColorRed();
        }
        // -----------------------------------------------------------------------------------------------------------------
        // Pausa, Play, Stop y FormClosing
        //
        private void BtnPausePlay_Click(object sender, EventArgs e)
        {
            if (BtnPausePlay.Text == "Pause")
            {
                BtnPausePlay.Text = "Play";
                pomodoros.Pause();
            }
            else
            {
                BtnPausePlay.Text = "Pause";
                pomodoros.Play();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            PnlTimer.Visible = false;
            menuStrip1.Visible = true;

            pomodoros.Pause();
            BBDD.acuBBDD += pomodoros.AcuTiempo;
            //BBDD.Ver();
        }

        private void FrmPomodoro_FormClosing(object sender, FormClosingEventArgs e)
        {
            BBDD.acuBBDD += pomodoros.AcuTiempo;
            //BBDD.Ver();
        }
        // -----------------------------------------------------------------------------------------------------------------
        // Metodos paneles estadisticas y acerca de
        //
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

        private void BtnVolverAcercaDe_Click(object sender, EventArgs e)
        {
            PnlAyuda.Dock = System.Windows.Forms.DockStyle.None;
        }
        // -----------------------------------------------------------------------------------------------------------------
        // Metodos labels pomodoros, AL PASAR
        //
        private void CambioColorGreen()
        {
            switch (pomodoros.Pomodoro)
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
            switch (pomodoros.Pomodoro)
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
    }
}
