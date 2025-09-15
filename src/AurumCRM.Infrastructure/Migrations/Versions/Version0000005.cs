using FluentMigrator;

namespace AurumCRM.Infrastructure.Migrations.Versions;

[Migration(DatabaseVersions.LEAD_STAGE_CREATION, "Creates LeadStage table")]
public class Version0000005 : BaseVersion
{
    public override void Up()
    {
        CreateTable("LeadStage")
            .WithColumn("LeadId").AsInt64().NotNullable()
            .WithColumn("UserId").AsInt64().NotNullable()
            .WithColumn("StageId").AsInt64().NotNullable()
            .WithColumn("EnteredAt").AsDateTime().NotNullable()
            .WithColumn("ExitedAt").AsDateTime().Nullable()
            .WithColumn("Notes").AsCustom("TEXT").Nullable();

        Create.ForeignKey("FK_LeadStage_Lead")
            .FromTable("LeadStage").ForeignColumn("LeadId")
            .ToTable("Lead").PrimaryColumn("Id");

        Create.ForeignKey("FK_LeadStage_User")
            .FromTable("LeadStage").ForeignColumn("UserId")
            .ToTable("User").PrimaryColumn("Id");

        Create.ForeignKey("FK_LeadStage_Stage")
            .FromTable("LeadStage").ForeignColumn("StageId")
            .ToTable("Stage").PrimaryColumn("Id");

        Create.Index("IX_LeadStage_Lead_Active").OnTable("LeadStage")
            .OnColumn("LeadId").Ascending()
            .OnColumn("IsActive").Ascending();

        Create.Index("IX_LeadStage_User_Active").OnTable("LeadStage")
            .OnColumn("UserId").Ascending()
            .OnColumn("IsActive").Ascending();

        Create.Index("IX_LeadStage_Stage").OnTable("LeadStage").OnColumn("StageId");
        Create.Index("IX_LeadStage_EnteredAt").OnTable("LeadStage").OnColumn("EnteredAt");
    }
}


