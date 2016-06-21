using System;

namespace ILSpyGui
{
    public class PresenterFactory : IPresenterFactory
    {
        public T InstantiatePresenter<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }
        public T InstantiatePresenter<T>(IPresenter parent)
        {
            return ObjectFactory.Container.With(parent).GetInstance<T> ();
        }
    }
}

