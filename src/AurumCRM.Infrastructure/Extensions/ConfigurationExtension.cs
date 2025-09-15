using Microsoft.Extensions.Configuration;

namespace AurumCRM.Infrastructure.Extensions;

public static class ConfigurationExtension
{
    public static string ConnectionString(this IConfiguration configurarion) => configurarion.GetConnectionString("ConnectionMySql")!;
}
