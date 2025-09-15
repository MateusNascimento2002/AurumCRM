namespace AurumCRM.Domain.Entities;

public class Stage : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int OrderIndex { get; set; }

    public ICollection<LeadStage> LeadStages { get; set; } = [];
}
