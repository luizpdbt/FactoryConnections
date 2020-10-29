using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;

namespace FactoryConnections
{
    
    public class Factory
    {
        public static IConfigurationRoot configuration { get; set; }
        public Factory()
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();
        }

        public static StringConnection RetornaConexao(int id)
        {
            switch (id)
            {
                case 1:
                    return new OracleDatabase(configuration);

                case 2:
                    return new Db2DataBase(configuration);

                default:
                    return null;

            } 
        }

    }
}
