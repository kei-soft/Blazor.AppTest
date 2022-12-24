using Blazor.AppTest.Constants;

using Microsoft.AspNetCore.Components;

namespace Blazor.AppTest.Components
{
    public class ActionComponent : ComponentBase
    {
        public string? ButtonText { get; set; }


        protected override Task OnInitializedAsync()
        {
            ButtonText = "Count Up" + CounterState.Value;

            return base.OnInitializedAsync();
        }

        public void IncrementCount()
        {
            CounterState.Value += 1;

            StateHasChanged();
        }
    }
}
