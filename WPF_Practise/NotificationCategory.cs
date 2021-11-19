namespace WPF_Practise
{
    public class NotificationCategory
    {
        public int Count { get; set; }

        public string Category { get; set; }

        public NotificationCategory(int count,string category)
        {
            this.Count = count;
            this.Category = category;
        }
    }
}