namespace Traffic_Lights_V6
{
    internal class TrafficLight
    {

        private enum State
        {
            Red = 1,
            Green = 2,
            Amber = 3,
            RedAmber = 4
        }
        private Lamp _amberLamp1;
        private Lamp _redLamp1;
        private Lamp _greenLamp1;



        private State _state;

        public void ChangeState()
        {

            switch (_state)
            {
                case State.Red:
                    _redLamp1.ChangeState(true);
                    _amberLamp1.ChangeState(false);
                    _greenLamp1.ChangeState(false);
                    _state = State.RedAmber;
                    break;

                case State.RedAmber:
                    _redLamp1.ChangeState(true);
                    _amberLamp1.ChangeState(true);
                    _greenLamp1.ChangeState(false);
                    _state = State.Green;
                    break;

                case State.Green:
                    _redLamp1.ChangeState(false);
                    _amberLamp1.ChangeState(false);
                    _greenLamp1.ChangeState(true);
                    _state = State.Amber;
                    break;

                case State.Amber:
                    _redLamp1.ChangeState(false);
                    _amberLamp1.ChangeState(true);
                    _greenLamp1.ChangeState(false);
                    _state = State.Red;
                    break;


            }
        }
        public void Display(Graphics g)
        {
            _redLamp1.Display(g);
            _greenLamp1.Display(g);
            _amberLamp1.Display(g);
        }
        public TrafficLight(int x, int y)
        {
            _redLamp1 = new Lamp(Color.Red, x, y);
            _greenLamp1 = new Lamp(Color.Green, x, y + 100);
            _amberLamp1 = new Lamp(Color.Yellow, x, y + 50);



            _state = State.Red;
        }


    }
}
