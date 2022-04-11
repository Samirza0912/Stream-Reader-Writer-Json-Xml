using System;
using System.IO;

namespace Stream_Reader_Writer_Json_Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"Air\Samir\desktop\samiramiraslanov$\Files"))
            {
                File.Create(@"Air\Samir\desktop\samiramiraslanov$\Files\Database.json");

            }
        }
    }
}
