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
    }
}
