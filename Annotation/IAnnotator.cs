using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    public interface IAnnotator
    {
        bool Annotate(string[] tokens, string outputFileName);

    }
}
