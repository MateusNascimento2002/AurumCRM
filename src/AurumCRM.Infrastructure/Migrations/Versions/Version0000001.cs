using FluentMigrator;

namespace AurumCRM.Infrastructure.Migrations.Versions;


[Migration(DatabaseVersions.PROFILE_CREATION, "Creates Profile table")]
public class Version0000001 : BaseVersion
{
    public override void Up()
    {
        CreateTable("Profile")
            .WithColumn("UpdatedAt").AsDateTime().Nullable()
            .WithColumn("Name").AsString(100).NotNullable()
            .WithColumn("Description").AsString(500).Nullable();

        Create.Index("IX_Profile_Name").OnTable("Profile").OnColumn("Name");
    }
}


