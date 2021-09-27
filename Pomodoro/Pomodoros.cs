using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Media;

namespace MiPomodoro
{
    class Pomodoros
    {
        Timer timer;

        private int segundos;
        private int minutos;
        private int acuTiempo;

        private int pomodoro;
        private bool descanso;

        private int cantPomodoros;
        private int desCorto;
        private int desLargo;
        private int tmpPomodoro;

        public event EventHandler evtSegundos; // EventHandler, es un Delegado
        public event EventHandler evtPaso;

        public Pomodoros(int cantPomodoros, int desCorto, int desLargo, int tmpPomodoro)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Evento_Elapsed;

            descanso = false;
            pomodoro = 1;

            this.cantPomodoros = cantPomodoros;
            this.desCorto = desCorto;
            this.desLargo = desLargo;
            this.tmpPomodoro = tmpPomodoro;

            this.acuTiempo = 0;
        }

        public int Segundos
        {
            get => segundos;
        }

        public int Minutos
        {
            get => minutos;
        }

        public int Pomodoro
        {
            get => pomodoro;
        }

        public bool Descanso
        {
            get => descanso;
        }

        public int AcuTiempo
        {
            get
            {
                int get = acuTiempo;
                acuTiempo = 0;
                return get;
            }
        }
        // -----------------------------------------------------------------------------------------------------------------
        //
        //
        public void Iniciar()
        {
            timer.Stop();
            segundos = 0;
            minutos = CambiaMinutos();
            evtSegundos(this, EventArgs.Empty);
            timer.Start();
        }

        public void Paso()
        {
            if (descanso == false)
            {
                descanso = true;
            }
            else
            {
                pomodoro++;
                descanso = false;
                if (pomodoro > cantPomodoros)
                {
                    pomodoro = 1;
                }
            }
            Iniciar();
        }

        public void Pause()
        {
            timer.Stop();
        }

        public void Play()
        {
            timer.Start();
        }

        private int CambiaMinutos()
        {
            if (descanso && pomodoro < cantPomodoros)
            {
                return desCorto;
            }
            else if (descanso && pomodoro == cantPomodoros)
            {
                return desLargo;
            }
            else
            {
                return tmpPomodoro;
            }
        }
        // -----------------------------------------------------------------------------------------------------------------
        // Control tiempo
        //
        private void Evento_Elapsed(object sender, EventArgs e)
        {
            segundos--;
            if (segundos == -1)
            {
                segundos = 59;
                if(descanso == false)
                    acuTiempo++;
                TMinutos();
            }
            evtSegundos(this, EventArgs.Empty);
        }

        private void TMinutos()
        {
            minutos--;
            if (minutos == -1)
            {
                Paso();
                PlaySonido();
                evtPaso(this, EventArgs.Empty);
            }
        }
        // -----------------------------------------------------------------------------------------------------------------
        // Sonido
        //
        private void PlaySonido()
        {
            SoundPlayer Sonido = new SoundPlayer(Properties.Resources.Paso);
            Sonido.Play();
        }
    }
}
