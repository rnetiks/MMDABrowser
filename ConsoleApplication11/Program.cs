﻿using System;
using System.Net;
using System.Windows.Forms;
using Fizzler.Systems.HtmlAgilityPack;

namespace MMDABrowser
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var x = new UserPage();
            x.Load(new UserStruct {
            });
            Application.Run(x);
        }
    }

}
