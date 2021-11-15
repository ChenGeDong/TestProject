using System;
using System.Collections.Generic;
using System.Text;

namespace StaticContructorSample
{
    class DocumentEditor
    {
        private static readonly uint s_maxDocument;
        static DocumentEditor()
        {
            //s_maxDocument = DoSomething
        }
    }
}
