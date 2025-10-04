using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ObjectPool
{
    public  class DataSource
    {
        static DataSource instance = new DataSource();
         List<Connection> pool = new List<Connection>();
        private  DataSource()
        {
            Init();  
        }

        private void Init()
        {
            for (int i = 0; i < 3; i++)
            {
                pool.Add(new Connection());
            }
        }
        // Return Connection
        public  static Connection GetConnection()
        {
            if(instance.pool.Count==0)
            {
                
                Console.WriteLine("Pool nill");
                return null;
            }

            Connection con = instance.pool[0];
            instance.pool.Remove(instance.pool[0]);
            Console.WriteLine(con);
            return con;
        }
        // Parameter Connection con
         public static void Release(Connection con)
        {
            if (con != null)
            {
                instance.pool.Add(con);
            }
            
        }
    }
}
