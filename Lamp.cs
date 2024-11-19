using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Lights_V6
{
    internal class Lamp
    {
        private Color _lampColour;      
        private bool _state;            
        private Rectangle _position;

        public void ChangeState() { _state = !_state; }


        public void ChangeState(bool state) { _state = state; }

        public void Display(Graphics g)
        {
            SolidBrush brush;

            if (_state) brush = new SolidBrush(_lampColour);
            else brush = new SolidBrush(Color.Gray);

            g.FillEllipse(brush, _position);
        }
        public Lamp(Color lampColour, int x, int y)
        {
            this._lampColour = lampColour;
            this._state = false;
            this._position = new Rectangle(x, y, 50, 50);
        }

    }

}
