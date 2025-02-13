﻿using System;

namespace Diode_Dominion
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (DiodeDominionGame game = new DiodeDominionGame())
                game.Run();
        }
    }
#endif
}
