using Blazor.MvvmTest.Base;
using Blazor.MvvmTest.Model;

namespace Blazor.MvvmTest.ViewModels
{
    public class WorkViewModel : BaseViewModel
    {
        private WorkItem currentWorkItem = new WorkItem();
        public WorkItem CurrentWorkItem
        {
            get => this.currentWorkItem;
            private set
            {
                this.currentWorkItem = value;
                OnPropertyChanged();
            }
        }

        private List<WorkItem> workItemList = new List<WorkItem>();
        public List<WorkItem> WorkItemList
        {
            get => this.workItemList;
            private set
            {
                this.workItemList = value;
                OnPropertyChanged();
            }
        }

        public WorkViewModel()
        {

        }

        public void AddCommand()
        {
            //this.WorkItemList.Add(new WorkItem() { Title = this.WorkTitle, Content = this.WorkContent, StartTime = this.StartTime, EndTime = this.EndTime, IsDone = IsDone });

            if (this.WorkItemList.Contains(this.CurrentWorkItem))
            {
                this.WorkItemList.Remove(this.CurrentWorkItem);
                this.WorkItemList.Add(this.CurrentWorkItem);
            }
            else
            {
                this.WorkItemList.Add(this.CurrentWorkItem);
            }

            // 초기화
            this.CurrentWorkItem = new WorkItem();
        }

        public void SetCurrentItem(WorkItem item)
        {
            this.CurrentWorkItem = item;
        }
    }
}
