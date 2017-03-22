using System;
using System.IO;

namespace WebApplication5
{
    public static class WriterData
    {
       public static string path = AppDomain.CurrentDomain.BaseDirectory + @"data.txt";
        public static void Writing(string dataTime)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(dataTime);
            }
        }
    }
}