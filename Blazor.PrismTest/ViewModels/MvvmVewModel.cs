using Blazor.PrismTest.Events;

using Prism.Commands;
using Prism.Events;

namespace Blazor.PrismTest.ViewModels
{
    public class MvvmVewModel
    {
        public int Count { get; set; }
        public string? Message { get; set; }
        public DelegateCommand? MyCommand { get; set; }

        public MvvmVewModel(IEventAggregator ea)
        {
            ea.GetEvent<TestEvent>().Subscribe(TestMethod);
        }

        public void IncrementCount()
        {
            Count += 1;
        }

        private void TestMethod(string arg)
        {
            // Publish 호출시 처리
            Message = "Call Method";
        }
    }
}
