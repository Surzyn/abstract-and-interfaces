using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.DataAccess
{
    public class OracleAccess: Connection, IGetData
    {
        public List<string> GetData()
        {
            Console.WriteLine("OracleAccess get data");
            return new List<string> { "Ptak", "Ryba", "Koniopies" };
        }

        public override void OpenConnection()
        {
            Console.WriteLine("OracleAccess open connection");
        }

    }
}
