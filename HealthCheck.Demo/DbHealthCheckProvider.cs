using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Data.SqlClient;

namespace HealthCheck.Demo
{
    public static class DbHealthCheckProvider
    {
        public static HealthCheckResult Check(string connectionString)
        {
            // Code to check if DB is running
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                return HealthCheckResult.Healthy();
            }
            catch
            {
                return HealthCheckResult.Unhealthy("Could not connect to database!");
            }
        }
    }
}
