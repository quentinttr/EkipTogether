﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkipTogether
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Saver.loadOptions();
            Saver.addParam("user", "Neyox");
            DiscordRichPresence.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConnectForm());

        }
    }
}