using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCheck.Demo
{
    public static class MqHealthCheckProvider
    {
        public static HealthCheckResult Check(string mqUri)
        {
            // Code to check if MQ is running
            return HealthCheckResult.Healthy();
        }
    }
}
