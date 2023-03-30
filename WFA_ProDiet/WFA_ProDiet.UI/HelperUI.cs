using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace WFA_ProDiet.UI
{
    public static class HelperUI
    {
        static Timer _timer;
        static Form _form;
        public static void TimerOpacity(this Form form)
        {
            _form= form;
            _timer = new Timer();
            _timer.Interval = 15;
            _form.Opacity = 0;
            _timer.Tick += Timer_Tick1;
            _timer.Start();
            
        }
        private static void Timer_Tick1(object? sender, EventArgs e)
        {
            if (_form.Opacity<1)
            {
                _form.Opacity += 0.05;
            }
            else
            {
                _timer.Stop();
            }
        }

        
    }
}
