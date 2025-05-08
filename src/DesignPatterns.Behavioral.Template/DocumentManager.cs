using System;

namespace DesignPatterns.Behavioral.Template
{
    public class DocumentManager : BaseDocumentManager
    {
        // Parameter string name
        public override void CheckDocument(string name)
        {
            Console.WriteLine("Document checked");
        }
        // Parameter string name
        public override Document OpenDocument(string name)
        {
            Console.WriteLine("Document " + name + "opened.");
            Document document = new Pdf();
            return document;
        }
    }
}
