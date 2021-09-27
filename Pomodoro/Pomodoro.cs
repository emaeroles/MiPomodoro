using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    class Pomodoro
    {
        private int pomodoro;
        private bool descanso;
        private int cantPomodoros;
        private int tmpPomodoro;
        private int tmpDescansoCorto;
        private int tmpDescansoLargo;

        TimerMio timerMio;

        public delegate void Delegado(Object sender, EventArgs e);
        public event Delegado evtPaso;

        public bool Descanso
        {
            get => descanso;
        }

        public int PomodoroP
        {
            get => pomodoro;
        }

        public int Cantidad
        {
            get => cantPomodoros;
        }

        public Pomodoro(TimerMio timerMio)
        {
            pomodoro = 0;
            descanso = true;
            this.timerMio = timerMio;
            this.timerMio.evtFin += Evento_Paso;
        }

        public void Iniciar(int cantPomodoros, int tmpPomodoro, int tmpDescansoCorto, int tmpDescansoLargo)
        {
            this.cantPomodoros = cantPomodoros;
            this.tmpPomodoro = tmpPomodoro;
            this.tmpDescansoCorto = tmpDescansoCorto;
            this.tmpDescansoLargo = tmpDescansoLargo;
        }

        public void Evento_Paso(object sender, EventArgs e)
        {
            PasoPomodoro();
            PlaySonido();
        }

        public void PasoPomodoro()
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

            this.timerMio.Iniciar(CantMinutos());
        }

        private int CantMinutos()
        {
            if (descanso && pomodoro < cantPomodoros)
            {
                return tmpDescansoCorto;
            }
            else if (descanso && pomodoro == cantPomodoros)
            {
                return tmpDescansoLargo;
            }
            else
            {
                return tmpPomodoro;
            }
        }

        private void PlaySonido()
        {
            SoundPlayer Sonido = new SoundPlayer(Properties.Resources.Paso);
            Sonido.Play();
        }
    }
}
