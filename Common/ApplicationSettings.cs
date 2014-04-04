using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ApplicationSettings
    {

        #region Constants

        private const string _PYSCRIPT_SENTENCEPARSER_NAME = "pyScriptSentenceParser";
        private const string _PYSCRIPT_TOKENIZER_NAME = "pyScriptTokenizer";
        private const string _PYSCRIPT_POSTAGGER_NAME = "pyScriptPOSTagger";

        private const string _PYSCRIPT_ARGS_SOURCELOCATION = "pyScriptArgSourceLocation";
        private const string _PYSCRIPT_ARGS_TEMPSENTENCE = "pyScriptArgTempSentence";
        private const string _PYSCRIPT_ARGS_TEMPTOKENS = "pyScriptArgTempToken";
        private const string _PYSCRIPT_ARGS_TEMPPOSTAG = "pyScriptArgTempPOSTag";


        #endregion
        public string this[string keyName]
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings[keyName];
            }
        }
        public static string PyScriptSentenceParserName
        {
            get
            {
                return GlobalAcessData.ApplicationStartupPath+System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_SENTENCEPARSER_NAME];
            }
        }
        public static string[] PyScriptSentenceParserArgs
        {
            get
            {
                return new string[] { 
                GlobalAcessData.ApplicationStartupPath+System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_ARGS_SOURCELOCATION],
                GlobalAcessData.ApplicationStartupPath+System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_ARGS_TEMPSENTENCE]                
                };
            }
        }
        public static string PyScriptTokenizerName
        {
            get
            {
                return GlobalAcessData.ApplicationStartupPath + System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_TOKENIZER_NAME];
            }
        }
        public static string[] PyScriptTokenizerArgs
        {
            get
            {
                return new string[] { 
                GlobalAcessData.ApplicationStartupPath+System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_ARGS_TEMPSENTENCE],
                GlobalAcessData.ApplicationStartupPath+System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_ARGS_TEMPTOKENS]                
                };
            }
        }
        public static string PyScriptPOSTaggerName
        {
            get
            {
                return GlobalAcessData.ApplicationStartupPath + System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_POSTAGGER_NAME];
            }
        }
        public static string[] PyScriptPOSTaggerArgs
        {
            get
            {
                return new string[] {                 
                GlobalAcessData.ApplicationStartupPath+System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_ARGS_TEMPTOKENS],                
                GlobalAcessData.ApplicationStartupPath+System.Configuration.ConfigurationSettings.AppSettings[_PYSCRIPT_ARGS_TEMPPOSTAG]
                };
            }
        }
    }
}
