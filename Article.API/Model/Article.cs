namespace Blog.API.Model;

// create a class named Article with 10 properties and add default values
public class Article
{
    public int Id { get; set; } = 0;
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public bool IsPublished { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public string Tags { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
}


