using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML;
using SFML.Graphics;
using SFML.Window;

namespace SFML
{
    class Window_Driver
    {
        RenderWindow window;
        public void Render()
        {
            window = new RenderWindow(new Window.VideoMode(200, 200), "test");
            window.SetVisible(true);
            window.Closed += new EventHandler(OnClosed);

            CircleShape cs = new CircleShape(100.0f);

            Color funcolor = new Color();
            funcolor.A = 255;
            Random Rand = new Random();

            while (window.IsOpen)
            {
                funcolor.R = (byte)(Rand.Next()%255);
                funcolor.G = (byte)(Rand.Next() % 255);
                funcolor.B = (byte)(Rand.Next() % 255);
                cs.FillColor = funcolor;
                window.Clear();
                window.DispatchEvents();
                window.Draw(cs);
                window.Display();
            }



        }

        void OnClosed(object sender, EventArgs e)
        {
            window.Close();
        }
    }
}
