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
        // return FileSingleton
        public static FileSingleton CreateInstance()
        {
            if (uniqueFileSingleton == null)
                uniqueFileSingleton = new FileSingleton();
            return uniqueFileSingleton;
        }
        // Parameter string path
        public void FileCreate(string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
        }
        // Parameter string path
        public void FileDelete(string path)
        {
            File.Delete(path);
        }

    }
}
