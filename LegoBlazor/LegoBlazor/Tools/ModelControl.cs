using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace LegoBlazor.Tools
{
    public class ModelControl<T> : ComponentBase, IDisposable where T : IBase   
    {
        [Parameter]
        public T Value { get; set; }

        public void Dispose()
        {
        }
    }

    public interface IBase
    {
        int Id { get; }
    }




    public abstract class Page<T> : ComponentBase where T : class
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Parameter]
        public Guid Id { get; set; }

        public T Item { get; set; }

        protected override Task OnInitializedAsync()
        {
            Item = GetItem();
            return Task.CompletedTask;
        }

        public abstract T GetItem();
    }
}