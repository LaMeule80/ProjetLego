using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace LegoBlazor.Tools
{
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