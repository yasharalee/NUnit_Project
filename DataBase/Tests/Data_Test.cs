using NUnit.Framework;
using static DataBaseUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NUnit_Project.DataBase.Tests
{
    [TestFixture]
    class Data_Test
    {
        string connectionString =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=54.237.233.250)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=hr;Password=hr;";

        [Test]
        public void DbTest()
        {
            ConnectToOracle(connectionString);
            DataTable dataTable = RunQuery("SELECT * FROM Employees");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row[2]);
            }
        }
    }
}
