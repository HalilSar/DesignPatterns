using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
   public class FileSingleton
    {
        private static FileSingleton uniqueFileSingleton;
        private FileSingleton() { }
        
        public static FileSingleton CreateInstance()
        {
            if (uniqueFileSingleton == null)
                uniqueFileSingleton = new FileSingleton();
            return uniqueFileSingleton;
        }

        public void FileCreate(string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
        }
        public void FileDelete(string path)
        {
            File.Delete(path);
        }

    }
}
