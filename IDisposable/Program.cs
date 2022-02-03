using System;
using System.IO;

namespace IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "This is line1", "This is line2", "This is line 3" };

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(@"C:\StreamWriter\name.txt");
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
            }
            }
    }
}
