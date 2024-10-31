using RepositoryFactoryAndMethodPattern.DITests;
using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>Test 1<<<<<<<");
            IRepoFactory factory = new RepoFactoryImpl();
            DITest1 t1 = new DITest1(new RepoFactoryImpl());
            t1.RunLaptop();
            Console.WriteLine(">>>>>Test 2<<<<<<");
            DITest2 t2 = new DITest2(factory.GetRepo<Brand>());
            t2.RunBrand();
            Console.WriteLine(">>>>>Test 3<<<<<<");
            IRepoFactory factory1 = new RepoFactoryImpl();
            DITest3 test3 = new DITest3(new RepoFactoryImpl());
            test3.RunCustomer();
            Console.ReadLine();
        }
    }
}
