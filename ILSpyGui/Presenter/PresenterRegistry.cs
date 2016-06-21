using System;
using StructureMap;
using System.Reflection;

namespace ILSpyGui
{
    public class PresenterRegistry : Registry
    {
        public PresenterRegistry()
        {
            Scan(x =>
                {
                    x.Assembly(Assembly.GetEntryAssembly());
                    x.AddAllTypesOf<IPresenter>();
                    x.WithDefaultConventions();
                });
            For<IPresenterFactory>().Use<PresenterFactory>();
        }
    }
}

