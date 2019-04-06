using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.DataAccess
{
    //Klasa która nie łączy się z bazą tylko implementuje interface IGetData - wykorzystywana w fazach testów
    public class MockDataAccess : IGetData
    {
        public List<string> GetData()
        {
            Console.WriteLine("MockDataAccess get data");
            return new List<string> { "Test1", "Test2", "Test3" };
        }
    }
}
