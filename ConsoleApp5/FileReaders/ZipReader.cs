using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.FileReaders
{
    public class ZipReader : FileReader
    {
        public override void ReadFile()
        {
            Console.WriteLine("ZipReader Read file");
        }

        public override void CloseFile()
        {
            Console.WriteLine("ZipReader Close file");
            IsOpen = false;
        }
    }
}
