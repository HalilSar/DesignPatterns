using System;

namespace DesignPatterns.Creational.ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection con = DataSource.GetConnection();
            Connection con2 = DataSource.GetConnection();
            Connection con3 = DataSource.GetConnection();
            DataSource.Release(con);
            Connection con4= DataSource.GetConnection();
        }
    }
}
