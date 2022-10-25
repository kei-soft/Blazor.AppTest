using Prism.Commands;
using Prism.Events;

namespace Blazor.PrismTest.ViewModels
{
    public class MvvmVewModel
    {
        public int Count { get; set; }
        public DelegateCommand MyCommand { get; set; }

        public MvvmVewModel(IEventAggregator ea)
        {

        }

        public void IncrementCount()
        {
            Count += 1;
        }
    }
}
