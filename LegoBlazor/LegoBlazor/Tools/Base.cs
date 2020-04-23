using System;
using Microsoft.AspNetCore.Components;

namespace LegoBlazor.Tools
{
    public class Base : ComponentBase, IDisposable
    {
        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        protected bool Disposed { get; set; }

        public void Dispose()
        {
            Disposed = true;
            InternalDispose();
        }

        protected virtual void InternalDispose()
        {
            //NP
        }
    }
}