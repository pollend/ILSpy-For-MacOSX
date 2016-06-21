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

            //register presenter Factory
            registry.For<IPresenterFactory> ().Use <PresenterFactory>().Singleton ();

            ObjectFactory.SetUpContainer (registry);

            Application.Init ();
            MainWindow win = new MainWindow ();
            win.Show ();
            Application.Run ();
        }
    }
}
