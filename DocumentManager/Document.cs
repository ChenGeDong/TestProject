using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
    public interface IDocument
    {
        string Title { get; set; }
        string Content { get; set; }

    }

    public class Document: IDocument
    {
        public Document()
        {

        }
        public Document(string title,string content)
        {
            Title = title;
            Content = content;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string wordText { get; set; }
    }

    public class Query<TRequest,TResult>
    {

    }

    public class StringQuery<TRequest>:Query<TRequest,string>
    {
        
    }


  
    
}
