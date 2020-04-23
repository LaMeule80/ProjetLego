using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace LegoBlazor.Tools
{
    public abstract class Pages<T> : Base where T : class
    {
        public IEnumerable<T> Items { get; set; }

        protected override Task OnInitializedAsync()
        {
            Items = GetItems();
            return Task.CompletedTask;
        }

        public abstract IEnumerable<T> GetItems();
    }

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