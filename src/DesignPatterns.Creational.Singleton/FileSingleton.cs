using System;
using System.Collections.Generic;
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
    }
}
