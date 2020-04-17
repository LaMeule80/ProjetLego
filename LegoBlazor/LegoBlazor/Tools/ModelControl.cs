using System;
using Microsoft.AspNetCore.Components;

namespace LegoBlazor.Tools
{
    public class ModelControl<T> : ComponentBase, IDisposable
    {
        [Parameter]
        public T Value { get; set; }

        public void Dispose()
        {
        }
    }
}