using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager
{
   
    public class DocumentManager<TDocumen> where TDocumen:IDocument
    {
        private readonly Queue<TDocumen> documentQueue = new Queue<TDocumen>();

        public void AddDocument(TDocumen doc)
        {
            lock(this)
            {
                documentQueue.Enqueue(doc);
            }
        }
        public bool IsDocumentAvailable => documentQueue.Count > 0;

        public TDocumen GetDocument()
        {
            TDocumen doc = default(TDocumen);
            lock(this)
            {
                doc = documentQueue.Dequeue();
            }
            return doc;
        }

        public void DisplayAllDocuments()
        {
            foreach (TDocumen doc in documentQueue)
            {
                Console.WriteLine(doc.Title);
            }
        }
    }
}
