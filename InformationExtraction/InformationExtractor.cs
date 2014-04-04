using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationExtraction
{
    public class InformationExtractor:IInformationExtractor
    {


        public string Extract()
        {
            return ExtractInternal();
        }

        private string ExtractInternal()
        {
            PythonScriptExecutor pythonScriptExecutor = new PythonScriptExecutor();            
            pythonScriptExecutor.Execute(ApplicationSettings.PyScriptSentenceParserName, ApplicationSettings.PyScriptSentenceParserArgs);
            
            string directoryName = ApplicationSettings.PyScriptSentenceParserArgs[1];
            StringBuilder information = new StringBuilder();
            
            foreach (string file in Directory.GetFiles(directoryName))
            {

                using (FileStream fileStream = new FileStream(file, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        information.Append(streamReader.ReadToEnd());
                    }
                }
            }
            
            return information.ToString();
        }
    }
}
