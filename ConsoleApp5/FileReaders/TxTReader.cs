using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.FileReaders
{
    public class TxTReader : FileReader
    {
        public override void ReadFile()
        {
            Console.WriteLine("TxtReader Read file");
        }

        public override void CloseFile()
        {
            Console.WriteLine("TxtReader Close file");
            IsOpen = false;
        }
    }
}
