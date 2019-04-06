using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.FileReaders
{
    public abstract class FileReader
    {
        public bool IsOpen { get; set; }
        public abstract void ReadFile();
        public abstract void CloseFile();

        public void OpenFile(string path)
        {
            IsOpen = true;
            Console.WriteLine("File reader Open file: " + path);
        }

        public void CheckStats()
        {
            Console.WriteLine("FileReader stat isOpen: " + IsOpen);
        }
    }
}
