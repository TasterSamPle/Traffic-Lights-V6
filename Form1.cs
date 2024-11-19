namespace Traffic_Lights_V6
{
    public partial class Form1 : Form
    {
        private Lamp _lamp;

        private TrafficLight _trafficLight;
        private TrafficLight2 _trafficLight2;

        public Form1()
        {
            _lamp = new Lamp(Color.Red, 10, 10);

            _trafficLight = new TrafficLight(210, 10);
            _trafficLight2 = new TrafficLight2(420, 10);

            InitializeComponent();
        }


        private void tmr_state_Tick(object sender, EventArgs e)
        {

            _lamp.ChangeState();

            _trafficLight.ChangeState();
            _trafficLight2.ChangeState();

            pb_area.Invalidate();
        }

        // Occurs every time pb_area is painted
        private void pb_area_Paint(object sender, PaintEventArgs e)
        {
            // Get the relevant graphics to draw to
            Graphics g = e.Graphics;

            // Display all 3 objects


            _trafficLight.Display(g);
            _trafficLight2.Display(g);
        }
    }
}