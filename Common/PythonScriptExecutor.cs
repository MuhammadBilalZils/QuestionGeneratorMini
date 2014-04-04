using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public class PythonScriptExecutor : IScriptExecutor
    {

        public bool Execute(string scriptName, string[] arguments)
        {
            try
            {
                //Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput= true;
                startInfo.UseShellExecute = false;
                startInfo.FileName = "python";
                startInfo.Arguments = string.Concat("\"" + scriptName + "\" ", "\"" + string.Join("\" \"", arguments) + "\"");
                //process.StartInfo = startInfo;
                //process.Start();
                startInfo.WorkingDirectory = GlobalAcessData.ApplicationStartupPath;


                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit(2000);
                    //using (StreamReader reader = process.StandardOutput)
                    //{
                    //    string result = reader.ReadToEnd();
                    //    MessageBox.Show(result);
                    //}
                    Debug.WriteLine(process.StandardOutput.ReadToEnd());
                    Debug.WriteLine(process.StandardError.ReadToEnd());
                }
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}
