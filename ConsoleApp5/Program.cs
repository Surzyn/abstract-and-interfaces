using ConsoleApp5.DataAccess;
using ConsoleApp5.FileReaders;
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun fun abstract");
            TxTReader txtReader = new TxTReader();
            txtReader.OpenFile("mis");
            CleanUpReader(txtReader);

            WordReader wordReader = new WordReader();
            wordReader.OpenFile("pies");
            CleanUpReader(wordReader);

            ZipReader zipReader = new ZipReader();
            zipReader.OpenFile("kot");
            zipReader.CheckStats();
            CleanUpReader(zipReader);

         
            //Fun fun interface
            Console.WriteLine("Fun fun interface");
            MSSQLAccess msSqlAccess = new MSSQLAccess();
            msSqlAccess.OpenConnection();
            GetDataFromDb(msSqlAccess);

            OracleAccess oracleAccess = new OracleAccess();
            oracleAccess.OpenConnection();
            GetDataFromDb(oracleAccess);

            MockDataAccess mockDataAccess = new MockDataAccess();
            GetDataFromDb(mockDataAccess);

            Console.ReadLine();
        }

        public static void CleanUpReader(FileReader reader)
        {
            //CleanUp...
            //Log into DB
            reader.CloseFile();
        }

        public static void GetDataFromDb(IGetData access)
        {
            //Log some staff
            Console.WriteLine("GetDataFromDb");
            access.GetData();
        }
    }
}
