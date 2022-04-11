using Microsoft.Extensions.Configuration;

namespace Meo.Pesquisa
{
    public static class IConfigurationExtensions
    {
        public static string EnviromentName(this IConfiguration configuration)
        {
            return configuration["EnviromentName"];
        }

        public static bool IsDevelopmentEnviroment(this IConfiguration configuration)
        {
            return "DESENVOLVIMENTO".Equals(configuration.EnviromentName());
        }

        public static bool IsIntegrationEnviroment(this IConfiguration configuration)
        {
            return "INTEGRACAO".Equals(configuration.EnviromentName());
        }

        public static bool IsStatingEnviroment(this IConfiguration configuration)
        {
            return "HOMOLOGACAO".Equals(configuration.EnviromentName());
        }

        public static bool IsProductionEnviroment(this IConfiguration configuration)
        {
            return "PRODUCAO".Equals(configuration.EnviromentName());
        }

    }
}
