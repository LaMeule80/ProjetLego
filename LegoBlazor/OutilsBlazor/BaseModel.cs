using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace ApplicationActrice.Tools
{
    public class Base : ComponentBase, IDisposable
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

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
