using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Traffic_Lights_V6
{
    internal class TrafficLight
    {

        private enum State
        {
            Red = 1,
            Green = 2,
            Amber = 3,
            RedAmber=4
        }
        private Lamp _amberLamp;
        private Lamp _redLamp;
        private Lamp _greenLamp;
        private State _state;

        public void ChangeState()
        {
            switch(_state)
            {
                case State.Red:
                    _redLamp.ChangeState(true);
                    _amberLamp.ChangeState(false);
                    _greenLamp.ChangeState(false);
                    _state = State.Green;
                    break;

                case State.RedAmber:
                    _redLamp.ChangeState(true);
                    _amberLamp.ChangeState(true);
                    _greenLamp.ChangeState(false);
                    _state = State.Red;
                    break;

                case State.Green:
                    _redLamp.ChangeState(false);
                    _amberLamp.ChangeState(false);
                    _greenLamp.ChangeState(true);
                    _state = State.Green;
                    break;

                case State.Amber:
                    _redLamp.ChangeState(false);
                    _amberLamp.ChangeState(true);
                    _greenLamp.ChangeState(false);
                    _state = State.Amber;
                    break;
                    

            }
        }
        public void Display(Graphics g)
        {
            _redLamp.Display(g);
            _greenLamp.Display(g);
            _amberLamp.Display(g);
        }
        public TrafficLight(int x, int y)
        {
            _redLamp = new Lamp(Color.Red, x, y);
            _greenLamp = new Lamp(Color.Green, x, y + 50);
            _amberLamp = new Lamp(Color.Yellow, x, y + 100);

            _state = State.Red;
        }

    }
}
