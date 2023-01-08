using DbUp;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Restaurant.Persistence.Filters
{
    public class DatabaseInitFilter : IStartupFilter
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<DatabaseInitFilter> _logger;

        public DatabaseInitFilter(IConfiguration configuration, ILogger<DatabaseInitFilter> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            var connectionString = _configuration.GetConnectionString("RestaurantConnectionString");
            var schema = "dbo";

            EnsureDatabase.For.SqlDatabase(connectionString);

            var dbUpgradeEngineBuilder = DeployChanges.To
                .SqlDatabase(connectionString, schema)
                .WithVariable("TargetSchema", schema)
                .WithScriptsEmbeddedInAssembly(typeof(RestaurantDbContext).Assembly)
                .WithTransaction()
                .LogToConsole()
                .LogScriptOutput();

            var dbUpgradeEngine = dbUpgradeEngineBuilder.Build();
            if (dbUpgradeEngine.IsUpgradeRequired())
            {
                _logger.LogInformation("Upgrade has been detected. Upgrading Database now...");
                var operation = dbUpgradeEngine.PerformUpgrade();
                if (operation.Successful)
                {
                    _logger.LogInformation("Upgrade completed successfully");
                }
                else
                {
                    _logger.LogError("Error happened in the upgrade. Please check the logs");
                }
            }
            else
            {
                _logger.LogInformation("No Database upgrade detected");
            }

            return next;
        }
    }
}
