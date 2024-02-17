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

        static   Connection GetConnection()
        {
            if(instance.pool.Count==0)
            {
                Console.WriteLine("Pool nill");
            }

            Connection con = instance.pool[0];
            Console.WriteLine(con);
            return con;
        }

        static void Release(Connection con)
        {
            if (con != null)
            {
                instance.pool.Add(con);
            }
        }
    }
}
