using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace FactoryConnections
{
    public class OracleDatabase : StringConnection
    {
        public IConfigurationRoot configuration;
        public OracleDatabase(IConfigurationRoot _configuration)
        {
            configuration = _configuration;
        }
        public string RetornaStringConexao()
        {
            return configuration.GetConnectionString("Storage");
        }
    }
}
