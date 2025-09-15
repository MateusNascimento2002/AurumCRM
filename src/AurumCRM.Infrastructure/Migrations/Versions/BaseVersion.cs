using FluentMigrator;
using FluentMigrator.Builders.Create.Table;

namespace AurumCRM.Infrastructure.Migrations.Versions;

public abstract class BaseVersion : ForwardOnlyMigration
{
    protected ICreateTableColumnOptionOrWithColumnSyntax CreateTable(string table)
    {
        return Create.Table(table)
            .WithColumn("Id").AsInt64().PrimaryKey().Identity()
            .WithColumn("CreatedAt").AsDateTime().NotNullable();
    }
}
