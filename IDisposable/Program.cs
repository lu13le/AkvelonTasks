using System;
using System.IO;

namespace IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            StreamReader reader = new StreamReader(@"C:\StreamWriter\name.txt");

            try
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occurred.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Dispose();
            }
        }
    }
}
