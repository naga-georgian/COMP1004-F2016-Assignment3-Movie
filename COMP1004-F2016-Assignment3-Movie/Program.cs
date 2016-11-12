using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Naga Rimmalapudi
// Student #: 200277598
// Description: This form is about the program.cs
// Date: November 7th 2016

namespace COMP1004_F2016_Assignment3_Movie
{
    static class Program
    {
        public static MovieAndGenre info = new MovieAndGenre();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
