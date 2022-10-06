namespace WebApplicationAPI.Models
{
    public class Home
    {
        public string Index { get; set; }
        public string Project { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public Home ()
        {
            Index = "Welcome home babe !!!";
            Project = "NS-API";
            Author = "ComDuong";
            Date = DateTime.Now;
        }
    }
}