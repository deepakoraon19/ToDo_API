namespace ToDo_API.ViewModels;

public class Users
{
    public Guid UserId { get; set; }

    public string Name { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string ProfilePic { get; set; }

    public DateTime LastUpdatedOn { get; set; }
    public IEnumerable<ToDos> ? ToDos { get; set; }

    public string Password {  get; set; }   
}

