using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    public class POSAnnotator : IAnnotator
    {
        public bool Annotate(string[] tokens, string outputFileName)
        {
            string posScriptName = Properties.Settings.Default.POSAnnotatorScriptName;
            PythonScriptExecutor pythonScriptExecutor = new PythonScriptExecutor();
            pythonScriptExecutor.Execute(posScriptName, tokens);
            return true;
        }
    }
}
