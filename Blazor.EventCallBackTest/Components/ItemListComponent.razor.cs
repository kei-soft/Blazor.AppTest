using Microsoft.AspNetCore.Components;

namespace Blazor.EventCallBackTest.Components
{
    public partial class ItemListComponent : ComponentBase
    {
        public List<string> DataList { get; set; } = new List<string> { "AA", "BB", "CC" };

        protected int SelectedCount { get; set; } = 0;

        protected void SelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedCount++;
            }
            else
            {
                SelectedCount--;
            }
        }
    }
}
