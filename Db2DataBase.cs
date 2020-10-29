using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace FactoryConnections
{
    public class Db2DataBase : StringConnection
    {
        public IConfigurationRoot configuration;
        public Db2DataBase(IConfigurationRoot _configuration)
        {
            configuration = _configuration;
        }

        public string RetornaStringConexao()
        {
            return configuration.GetConnectionString("Storage2");
        }
    }
}
