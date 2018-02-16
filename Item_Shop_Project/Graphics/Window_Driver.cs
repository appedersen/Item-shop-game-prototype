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
            window = new RenderWindow(new Window.VideoMode(500, 300), "test");
            window.SetVisible(true);
            window.Closed += new EventHandler(OnClosed);


            Spritehandler Sprite_Library = new Spritehandler();
            Font testfont = new Font("font.ttf");

            Text testText = new Text();

            Tag_Listings Tagtest = new Tag_Listings();

            Tag testtag = Tagtest.GetTag("Metal");
            testText.DisplayedString = testtag.Identifier;

            testText.Font = testfont;

            testText.CharacterSize = 24;

            testText.Color = Color.Red;

            testText.Position = new System.Vector2f(0, 0);


            float small = 0;
            while (window.IsOpen)
            {
                small += 0.001f;
                testText.Position = new System.Vector2f(small,small);
                window.Clear();

                //Sprite_Library.Draw_Sprite("Testsprite.png", 1, 1, window);

                window.Draw(testText);
                
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
