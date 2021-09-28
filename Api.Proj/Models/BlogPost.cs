using System;

namespace Api.Proj
{
    public class BlogPost
    {
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public string Summary { get;set; }
        public string Content { get; set; }
    }
}
