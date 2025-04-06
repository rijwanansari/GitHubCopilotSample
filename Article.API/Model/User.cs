namespace Blog.API.Model;

public class User
{

    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; } = DateTime.Now;
}
