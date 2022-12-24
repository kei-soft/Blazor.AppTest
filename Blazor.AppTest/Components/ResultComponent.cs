using Blazor.AppTest.Constants;

using Microsoft.AspNetCore.Components;

namespace Blazor.AppTest.Components
{
    public class ResultComponent : ComponentBase
    {
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        public void IncrementCount()
        {
            CounterState.Value += 1;

            StateHasChanged();
        }
    }
}
