using System;

namespace DesignPatterns.Behavioral.Template
{
    public abstract class BaseDocumentManager
    {
        public Document GetDocument(string name)
        {
            Document document = OpenDocument(name);
        }

        public abstract void CheckDocument();
        public abstract void OpenDocument(string name);
    }
}
