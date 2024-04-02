namespace ToDo_API.ViewModels;

public class ToDos
{

    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string Title { get; set; }

    public DateTime LastUpdatedOn { get; set; }

    public string Description { get; set; }

    public Users User { get; set; }

}
