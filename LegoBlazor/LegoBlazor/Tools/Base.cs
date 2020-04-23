using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

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

    public static class IJavaScriptRuntimeExtension
    {
        public static async void AfficherNouvelOnglet(this IJSRuntime jsRuntime, string url)
        {
            await jsRuntime.InvokeAsync<string>("open", url, "_blank");
        }
    }
}