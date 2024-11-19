using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Traffic_Lights_V6
{
    internal class SignalBox
    {

        private enum State
        {
            Red = 1,
            Green = 2,
            Amber= 3,
            RedAmber=4
        }

        private Lamp _redLamp;      
        private Lamp _greenLamp;
        private Lamp _amberLamp;
        private State _state;

        public SignalBox(int x, int y)
        {
            _redLamp = new Lamp(Color.Red, x, y);
            _greenLamp = new Lamp(Color.Green, x, y + 50);
            _amberLamp = new Lamp(Color.Yellow, x, y + 100);

            _state = State.Red;
        }

    }
}
