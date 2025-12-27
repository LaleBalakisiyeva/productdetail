using front_to_back.Models.Base;

namespace front_to_back.Models
{
    public class Blog:BaseEntity
    {
      
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
    }
}
