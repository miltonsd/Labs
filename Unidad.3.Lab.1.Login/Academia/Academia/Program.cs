﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Academia
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formLogin());
            Application.Run(new formMain());
        }
    }
}