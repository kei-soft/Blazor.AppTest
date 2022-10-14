namespace Blazor.RadzenTest.Data
{
    public partial class MenuItem
    {
        public int MenuID { get; set; }
        public ICollection<MenuItem>? MenuItems { get; set; }
        public string? MenuName { get; set; }
        public string? MenuDescription { get; set; }
        public string? MenuImage { get; set; }
    }
}
