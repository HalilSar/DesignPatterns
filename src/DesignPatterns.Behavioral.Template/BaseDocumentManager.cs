using System;

namespace DesignPatterns.Behavioral.Template
{
    public abstract class BaseDocumentManager
    {
        // return    : document
        // parameter : string name
        public Document GetDocument(string name)
        {
            Document document = OpenDocument(name);
            return document;
        }
        // parameter : string name
        public abstract void CheckDocument(string name);
        // return    : document
        // parameter : string name
        public abstract Document OpenDocument(string name);
    }
}
