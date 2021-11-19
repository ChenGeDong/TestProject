using System;
using System.Collections.Generic;
using System.Text;

namespace StaticContructorSample
{
    public class Document
    {
        private readonly DateTime _creationTime;
        public Document()
        {
            _creationTime = DateTime.Now;
        }

            

    }
}
