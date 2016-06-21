using System;

namespace ILSpyGui
{
    public interface IPresenterFactory
    {
        T InstantiatePresenter<T>();
        T InstantiatePresenter<T>(IPresenter parent);
    }
}

