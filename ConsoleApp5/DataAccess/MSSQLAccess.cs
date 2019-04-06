using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.DataAccess
{
    public class MSSQLAccess: Connection, IGetData
    {
        public override void OpenConnection()
        {
            Console.WriteLine("MSSQLAccess open connection");
        }

        public List<string> GetData()
        {
            Console.WriteLine("MSSQLAccess get data");
            return new List<string> { "Kot", "Pies", "Myszoszczor" };
        }
    }
}
