using Microsoft.AspNetCore.Components;

namespace Blazor.AppTest.Components
{
    public class TestComponent : ComponentBase
    {
        public string? ButtonText;
        public int Value = 0;
        protected override Task OnInitializedAsync()
        {
            ButtonText = "Increment";

            return base.OnInitializedAsync();
        }

        public void IncrementCount()
        {
            this.Value += 1;

            StateHasChanged();
        }
    }
}
