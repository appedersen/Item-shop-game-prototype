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


            Spritehandler Sprite_Library = new Spritehandler();

            while (window.IsOpen)
            {
                window.Clear();

                Sprite_Library.Draw_Sprite("Testsprite.png", 1, 1, window);


                window.DispatchEvents();

                window.Display();
            }



        }

        void OnClosed(object sender, EventArgs e)
        {
            window.Close();
        }
    }
}
