using System;

namespace BlazorApp16.Stores
{
    public interface IActionDispatcher
    {
        void Dispatch(IAction action);
        void Subscript(Action<IAction> actionHandler);
        void Unsubscript(Action<IAction> actionHandler);
    }
}