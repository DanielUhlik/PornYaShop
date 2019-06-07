using System;
using System.Collections.Generic;
using System.Text;

namespace PornYaShop.Shared
{
    public static class Config
    {
        public static string DbConnectionString
        {
            get
            {
                return InDocker ?
                    @"Server=pornyashop.db;Database=master;User=sa;Password=Your_password123;" :
                    @"Server=127.0.0.1,1433;Database=master;User=sa;Password=Your_password123;";
            }
        }

        public static bool InDocker { get { return Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true"; } }

    }
}
