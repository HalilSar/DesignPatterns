using System;

namespace DesignPatterns.Behavioral.Template
{
    public abstract class BaseDocumentManager
    {
        public Document GetDocument(string name)
        {
            Document document = OpenDocument(name);
            return document;
        }

        public abstract void CheckDocument(string name);
        public abstract Document OpenDocument(string name);
    }
}
