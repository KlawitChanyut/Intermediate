using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Interfaces
{
    public class Interfaces_and_Extensibility
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}") + DateTime.Now);
            
            _logger.LogInfo("Migrationg finished at {0}") + DateTime.Now);
        }
    }
}
