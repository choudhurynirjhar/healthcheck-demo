using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCheck.Demo
{
    public static class DbHealthCheckProvider
    {
        public static HealthCheckResult Check(string connectionString)
        {
            // Code to check if DB is running
            return HealthCheckResult.Degraded();
        }
    }
}
