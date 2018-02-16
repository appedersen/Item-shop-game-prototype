using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFML.Graphics;
using SFML;

namespace SFML
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///
        /// 
        [STAThread]
        static void Main()
        {
            Window_Driver Game_Loop = new Window_Driver();
            Game_Loop.Render();
            return;
        }
    }

}
