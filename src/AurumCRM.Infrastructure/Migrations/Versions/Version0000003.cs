using FluentMigrator;

namespace AurumCRM.Infrastructure.Migrations.Versions;

[Migration(DatabaseVersions.STAGE_CREATION, "Creates Stage table")]
public class Version0000003 : BaseVersion
{
    public override void Up()
    {
        CreateTable("Stage")
            .WithColumn("UpdatedAt").AsDateTime().Nullable()
            .WithColumn("Name").AsString(100).NotNullable()
            .WithColumn("Description").AsString(500).Nullable()
            .WithColumn("OrderIndex").AsInt32().NotNullable()
            .WithColumn("Color").AsString(7).Nullable() // Hex color
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(true);

        Create.Index("IX_Stage_OrderIndex").OnTable("Stage").OnColumn("OrderIndex");
        Create.Index("IX_Stage_IsActive").OnTable("Stage").OnColumn("IsActive");
    }
}


