using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Project.ProjectBusinessLayer.DataAccess
{
    class Sparta_Database
    {
        private const String SPARTAN_DATABASE_PORT = "1521";
        private const String SPARTAN_DATABASE_USER = "SP";
        private const String SPARTAN_DATABASE_PASSWORD = "SP";
        private const String SPARTAN_DATABASE_NAME = "Oracle";
        private const String SPARTAN_DATABASE_SEED = "xe";

        public static string Spartan_database_portNum => SPARTAN_DATABASE_PORT;

        public static string Spartan_database_userName => SPARTAN_DATABASE_USER;

        public static string Spartan_database_password => SPARTAN_DATABASE_PASSWORD;

        public static string Spartan_database_name => SPARTAN_DATABASE_NAME;

        public static string Spartan_database_seed => SPARTAN_DATABASE_SEED;
    }
}
