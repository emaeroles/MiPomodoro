using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Pomodoro
{
    class TimerMio
    {
        Timer timer;
        private int decimas;
        private int segundos;
        private int minutos;

        public delegate void Delegado(Object sender, EventArgs e);
        public event Delegado evtSegundos;
        public event Delegado evtFin;

        public int SegundosP
        {
            get => segundos;
        }

        public int MinutosP
        {
            get => minutos;
        }

        public TimerMio()
        {
            this.timer = new Timer();
            this.timer.Interval = 100;
            this.timer.Elapsed += Timer_Elapsed;
        }

        public void Iniciar(int minutos)
        {
            this.decimas = 10;
            this.segundos = 0;
            this.minutos = minutos;
            this.timer.Start();
        }

        public void Pause()
        {
            this.timer.Stop();
        }

        public void Play()
        {
            this.timer.Start();
        }
        
        private void Timer_Elapsed(object sender, EventArgs e)
        {
            decimas--;
            if (decimas == 0)
            {
                decimas = 10;
                Segundos();
            }
        }

        public void Segundos()
        {
            evtSegundos(this, EventArgs.Empty);
            segundos--;
            if (segundos == -1)
            {
                segundos = 09;
                Minutos();
            }
            //evtSegundos(this, EventArgs.Empty);
        }

        public void Minutos()
        {
            minutos--;
            if (minutos == -1)
                evtFin(this, EventArgs.Empty);
        }
    }
}
