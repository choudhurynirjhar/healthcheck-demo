using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthCheck.Demo
{
    public static class MqHealthCheckProvider
    {
        public static HealthCheckResult Check(string mqUri)
        {
            // Code to check if MQ is running
            return HealthCheckResult.Degraded("MQ is running slow!");
        }
    }
}
