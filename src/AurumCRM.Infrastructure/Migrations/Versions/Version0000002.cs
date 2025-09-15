using FluentMigrator;

namespace AurumCRM.Infrastructure.Migrations.Versions;

[Migration(DatabaseVersions.USER_CREATION, "Creates User table")]
public class Version0000002 : BaseVersion
{
    public override void Up()
    {
        CreateTable("User")
            .WithColumn("UpdatedAt").AsDateTime().Nullable()
            .WithColumn("FirstName").AsString(100).NotNullable()
            .WithColumn("LastName").AsString(100).NotNullable()
            .WithColumn("Email").AsString(255).NotNullable()
            .WithColumn("PasswordHash").AsString(255).NotNullable()
            .WithColumn("PhoneNumber").AsString(20).Nullable()
            .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(true)
            .WithColumn("LastLoginAt").AsDateTime().Nullable()
            .WithColumn("ProfileId").AsInt64().NotNullable();

        Create.ForeignKey("FK_User_Profile")
            .FromTable("User").ForeignColumn("ProfileId")
            .ToTable("Profile").PrimaryColumn("Id");

        Create.Index("IX_User_Email").OnTable("User").OnColumn("Email").Unique();
        Create.Index("IX_User_ProfileId").OnTable("User").OnColumn("ProfileId");
    }
}


