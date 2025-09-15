namespace AurumCRM.Domain.Entities;

public class LeadStage : BaseEntity
{
    public long LeadId { get; set; }
    public long UserId { get; set; }
    public long StageId { get; set; }
    public DateTime EnteredAt { get; set; }
    public DateTime? ExitedAt { get; set; }
    public string Notes { get; set; } = string.Empty;

    public Lead Lead { get; set; } = default!;
    public User User { get; set; } = default!;
    public Stage Stage { get; set; } = default!;
}
