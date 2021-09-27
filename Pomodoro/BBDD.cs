using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPomodoro
{
    static class BBDD
    {
        static public int acuBBDD;
        
        static public void Ver()
        {
            System.Windows.Forms.MessageBox.Show(acuBBDD.ToString());
        }
    }
}
