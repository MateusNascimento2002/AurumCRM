namespace AurumCRM.Domain.Entities;

public class Lead : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Source { get; set; } = string.Empty; 
    public decimal? Budget { get; set; }
    public string Notes { get; set; } = string.Empty;
    public DateTime? LastContactAt { get; set; }

    public ICollection<LeadStage> LeadStages { get; set; } = [];
}
