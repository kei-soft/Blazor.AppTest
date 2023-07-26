using Microsoft.JSInterop;

namespace Blazor.ClipBoardTest.Services
{
    public class ClipboardService
    {
        private readonly IJSRuntime jsRuntime;

        public ClipboardService(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public ValueTask<string> ReadTextAsync()
        {
            return jsRuntime.InvokeAsync<string>("navigator.clipboard.readText");
        }

        public ValueTask WriteTextAsync(string text)
        {
            return jsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }
    }
}
