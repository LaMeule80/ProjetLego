using Microsoft.JSInterop;

namespace LegoBlazor.Tools
{
    public static class IJavaScriptRuntimeExtension
    {
        public static async void AfficherNouvelOnglet(this IJSRuntime jsRuntime, string url)
        {
            await jsRuntime.InvokeAsync<string>("open", url, "_blank");
        }
    }
}