using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    interface IScriptExecutor
    {
        bool Execute(string scriptName, string[] arguments);

    }
}
