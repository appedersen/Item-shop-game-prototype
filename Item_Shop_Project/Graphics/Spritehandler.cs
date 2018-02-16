using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML;
using SFML.Graphics;

namespace SFML
{
    struct sprite_object
    {
        public Texture Sprite_Image;
        public string Filename;
        public Boolean Loaded_Successfully;

        public sprite_object(Texture Sprite_In, string File_in, Boolean Loaded_In)
        {
            Sprite_Image = Sprite_In;
            Filename = File_in;
            Loaded_Successfully = Loaded_In;
        }
    }

    class Spritehandler
    {
        Dictionary<string, sprite_object> Sprite_Library;

        public Spritehandler()
        {
            Sprite_Library = new Dictionary<string, sprite_object>();
        }

        public void Draw_Sprite(string Filename,int x, int y, RenderWindow window  )
        {
            
            Sprite Sprite_creation = new Sprite();
            Sprite_creation.Texture = Get_Sprite(Filename);

            Sprite_creation.Position = new System.Vector2f(x,y);

            window.Draw(Sprite_creation);


        }

        public Texture Get_Sprite(string Filename)
        {
            Texture Texture_Loaded_In;
            Boolean Loaded_Successfully;
            if (Sprite_Library.ContainsKey(Filename))
            {
                return Sprite_Library[Filename].Sprite_Image;

            }
            else
            {
                try
                {
                    Texture_Loaded_In = new Texture(Filename);
                }
                catch
                {
                    return null;
                }
                Loaded_Successfully = true;

                Sprite_Library["Filename"] = new sprite_object(Texture_Loaded_In, Filename, Loaded_Successfully);
                //Dictionary < Filename,{Texture_Loaded_In,Filename,Loaded_Successfully}>
                return Texture_Loaded_In;

            }

        }
    }
}

