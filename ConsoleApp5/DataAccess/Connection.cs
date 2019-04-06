using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.DataAccess
{
    public abstract class Connection
    {
        public virtual void OpenConnection()
        {
            Console.WriteLine("Connection open connection");
        }

        public virtual void CloseConnection()
        {
            Console.WriteLine("Connection close connection");
        }

    }
}
