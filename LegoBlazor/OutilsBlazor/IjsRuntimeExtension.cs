using System.Threading;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace ApplicationActrice.Tools
{
    public static class IjsRuntimeExtension
    {
        public static async Task AfficherNouvelOnglet(this IJSRuntime jsRuntime, string url)
        {
            await jsRuntime.InvokeAsync<string>("open", CancellationToken.None, url, "_blank");
        }
    }
}