using System;
using CSVReader;

namespace тask1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\lab3\тask1\тask1\test.csv";
            CSVReadering cSVReadering = new CSVReadering();
            cSVReadering.Reader(path);
        }
    }
}
