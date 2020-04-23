using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace LegoBlazor.Tools
{
    public abstract class Pages<T> : ComponentBase
    {
        public IEnumerable<T> Items { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await Load();
        }

        protected async Task Load()
        {
            Items = GetItems().Result;
        }

        public abstract Task<IEnumerable<T>> GetItems();
    }
}