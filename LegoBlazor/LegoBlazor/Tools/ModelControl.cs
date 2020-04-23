using System;
using Microsoft.AspNetCore.Components;

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
}