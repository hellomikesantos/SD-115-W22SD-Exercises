namespace MVC.Models
{
    public class ContentPost
    {
        public int Id { get; set; }
        public string Contents { get; set;}
        public ContentPost(string contents)
        {
            Contents = contents;
        }
    }
}
