using FluentMigrator;

namespace AurumCRM.Infrastructure.Migrations.Versions;

[Migration(DatabaseVersions.LEAD_CREATION, "Creates Lead table")]
public class Version0000004 : BaseVersion
{
    public override void Up()
    {
        CreateTable("Lead")
            .WithColumn("UpdatedAt").AsDateTime().Nullable()
            .WithColumn("FirstName").AsString(100).NotNullable()
            .WithColumn("LastName").AsString(100).NotNullable()
            .WithColumn("Email").AsString(255).Nullable()
            .WithColumn("PhoneNumber").AsString(20).Nullable()
            .WithColumn("Source").AsString(50).Nullable()
            .WithColumn("Budget").AsDecimal(15, 2).Nullable()
            .WithColumn("Notes").AsCustom("TEXT").Nullable()
            .WithColumn("Score").AsInt32().NotNullable().WithDefaultValue(0)
            .WithColumn("Status").AsString(20).NotNullable().WithDefaultValue("Active")
            .WithColumn("LastContactAt").AsDateTime().Nullable();

        Create.Index("IX_Lead_Email").OnTable("Lead").OnColumn("Email");
        Create.Index("IX_Lead_Source").OnTable("Lead").OnColumn("Source");
        Create.Index("IX_Lead_Status").OnTable("Lead").OnColumn("Status");
        Create.Index("IX_Lead_CreatedAt").OnTable("Lead").OnColumn("CreatedAt");
    }
}


