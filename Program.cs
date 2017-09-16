using System;
using CrvNetSync.Repository;

namespace CrvNetSync
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             EntradaStrockRepository customerRepository = new EntradaStrockRepository();
            var prime = customerRepository.FindAll();
		    
        }
    }
}
