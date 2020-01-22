using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        using (var stdout = Console.OpenStandardOutput())
        {
            new List<byte> { 0xF0, 0x9F, 0x92, 0xA9, 0xD, 0xA }.ForEach(stdout.WriteByte);
        }
    }
}

