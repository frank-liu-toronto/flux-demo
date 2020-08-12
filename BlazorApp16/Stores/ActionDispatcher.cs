using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp16.Stores
{
    public class ActionDispatcher : IActionDispatcher
    {
        private Action<IAction> _registeredActionHandlers;

        public void Subscript(Action<IAction> actionHandler) => _registeredActionHandlers += actionHandler;

        public void Unsubscript(Action<IAction> actionHandler) => _registeredActionHandlers -= actionHandler;

        public void Dispatch(IAction action) => _registeredActionHandlers?.Invoke(action);

    }
}
