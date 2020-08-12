using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp16.Stores.CounterStore
{
    public class DecrementAction : IAction
    {
        public const string DECREMENT = "DECREMENT";

        public string Name => DECREMENT;
    }
}
