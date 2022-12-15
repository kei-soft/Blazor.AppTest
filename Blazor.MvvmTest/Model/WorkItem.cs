namespace Blazor.MvvmTest.Model
{
    public class WorkItem
    {
        public int Id { get; set; }
        /// <summary>
        /// 타이틀
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// 내용
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// 시작시간
        /// </summary>
        public DateTime StartTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 완료시간
        /// </summary>
        public DateTime EndTime { get; set; } = DateTime.Now.AddDays(1);
        /// <summary>
        /// 완료여부
        /// </summary>
        public bool IsDone { get; set; }
    }
}
