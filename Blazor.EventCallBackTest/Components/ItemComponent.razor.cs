using Microsoft.AspNetCore.Components;

namespace Blazor.EventCallBackTest.Components
{
    public partial class ItemComponent : ComponentBase
    {
        protected bool IsSelected { get; set; }

        [Parameter]
        public EventCallback<bool> OnSelection { get; set; }
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)(e.Value ?? false);
            await OnSelection.InvokeAsync(IsSelected);
        }
    }
}
