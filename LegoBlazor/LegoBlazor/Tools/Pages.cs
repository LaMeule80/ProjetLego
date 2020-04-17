using System.Collections.Generic;
using System.Threading.Tasks;

namespace LegoBlazor.Tools
{
    public abstract class Pages<T> : ModelControl<T>
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