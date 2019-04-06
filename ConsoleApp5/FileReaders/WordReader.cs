using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.FileReaders
{
    public class WordReader : FileReader
    {
        public override void ReadFile()
        {
            Console.WriteLine("WordReader Read file");
        }

        public override void CloseFile()
        {
            Console.WriteLine("WordReader Close file");
            IsOpen = false;
        }
    }
}
