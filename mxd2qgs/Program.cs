using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxd2qgs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"C:\Python27\ArcGIS10.4\python.exe";
                psi.Arguments = string.Format("{0} {1} {2}", args);
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;

                using (Process p = Process.Start(psi))
                {
                    using (StreamReader sr = p.StandardOutput)
                    {
                        string res = sr.ReadToEnd();
                        Console.Write(res);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
