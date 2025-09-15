namespace AurumCRM.Domain.Entities;

public class Profile : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<User> Users { get; set; } = [];
}
