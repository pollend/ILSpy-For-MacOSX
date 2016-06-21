using System;
using Gtk;
using StructureMap;

namespace ILSpyGui
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            var registry = new Registry();

            ObjectFactory.SetUpContainer (registry);

            Application.Init ();
            MainWindow win = new MainWindow ();
            win.Show ();
            Application.Run ();
        }
    }
}
