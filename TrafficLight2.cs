using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Traffic_Lights_V6
{
    internal class TrafficLight2
    {

        private enum State
        {
            Red = 1,
            Green = 2,
            Amber = 3,
            RedAmber=4
        }


        private Lamp _amberLamp2;
        private Lamp _redLamp2;
        private Lamp _greenLamp2;

        private State _state;

        public void ChangeState()
        {
            switch(_state)
            {
                case State.Red:
                    _redLamp2.ChangeState(true);
                    _amberLamp2.ChangeState(false);
                    _greenLamp2.ChangeState(false);
                    _state = State.RedAmber;
                    break;

                case State.RedAmber:
                    _redLamp2.ChangeState(true);
                    _amberLamp2.ChangeState(true);
                    _greenLamp2.ChangeState(false);
                    _state = State.Green;
                    break;

                case State.Green:
                    _redLamp2.ChangeState(false);
                    _amberLamp2.ChangeState(false);
                    _greenLamp2.ChangeState(true);
                    _state = State.Amber;
                    break;

                case State.Amber:
                    _redLamp2.ChangeState(false);
                    _amberLamp2.ChangeState(true);
                    _greenLamp2.ChangeState(false);
                    _state = State.Red;
                    break;
                    

            }
        }
        public void Display(Graphics g)
        {
            _redLamp2.Display(g);
            _greenLamp2.Display(g);
            _amberLamp2.Display(g);
        }
        public TrafficLight2(int x, int y)
        {
           
            _redLamp2 = new Lamp(Color.Red, x + 150, y);
            _greenLamp2 = new Lamp(Color.Green, x + 150, y + 100);
            _amberLamp2 = new Lamp(Color.Yellow, x + 150, y + 50);

            _state = State.Red;
        }

    }
}
