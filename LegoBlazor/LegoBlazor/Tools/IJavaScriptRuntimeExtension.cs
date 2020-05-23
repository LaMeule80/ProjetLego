using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace LegoBlazor.Tools
{
    public static class IJavaScriptRuntimeExtension
    {
        public static async Task AfficherNouvelOnglet(this IJSRuntime jsRuntime, string url)
        {
            await jsRuntime.InvokeAsync<string>("open", url, "_blank");
        }
    }
}