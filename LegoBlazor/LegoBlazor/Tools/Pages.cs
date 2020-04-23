using System.Collections.Generic;
using System.Threading.Tasks;

namespace LegoBlazor.Tools
{
    public abstract class Pages<T> : Base where T : class
    {
        public IEnumerable<T> Items { get; set; }

        public T CurrentItem { get; set; }

        protected override Task OnInitializedAsync()
        {
            Items = GetItems();
            return Task.CompletedTask;
        }

        public abstract IEnumerable<T> GetItems();
    }
}