using System;
using StructureMap;

namespace ILSpyGui
{
    public class ObjectFactory
    {
        public static IContainer Container { get; private set; }

 
        public static T GetInstance<T>()
        {
            return Container.GetInstance<T>();
        }

        public static object GetInstance(Type type)
        {
            return Container.GetInstance(type);
        }

        public static T GetInstance<T>(Type type)
        {
            var instance = GetInstance(type);
            return instance is T ? (T) instance : default(T);
        }

        public static ExplicitArgsExpression With<TArg>(TArg arg)
        {
            return Container.With(arg);
        }

        public static void SetUpContainer(Registry registry)
        {
            Container = new Container(registry);
        }
    }
}

