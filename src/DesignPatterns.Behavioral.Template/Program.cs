using System;

namespace DesignPatterns.Behavioral.Template
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDocumentManager documentManager = new DocumentManager();
            Document document = documentManager.GetDocument("wolfhunting.pdf ");
        }
    }
}
