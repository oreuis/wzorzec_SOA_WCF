using System;

namespace WebApp
{
    class Program
    {
        static void Main()
        {
            ServiceReference1.Service1Client dc
                 = new ServiceReference1.Service1Client();
            int nVal = dc.GetSquare(10);
            Console.WriteLine("Rezultat:" + nVal);
        }
    }
}
