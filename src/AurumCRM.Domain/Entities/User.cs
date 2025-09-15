namespace AurumCRM.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime? LastLoginAt { get; set; }
    public long ProfileId { get; set; }

    public Profile Profile { get; set; } = default!;
    public ICollection<LeadStage> LeadStages { get; set; } = [];
}