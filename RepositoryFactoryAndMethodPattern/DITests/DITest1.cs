using RepositoryFactoryAndMethodPattern.Factories;
using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.DITests
{
    public class DITest1
    {
        private IRepoFactory factory;
        public DITest1(IRepoFactory factory)
        {
            this.factory = factory;
        }
        public void RunLaptop()
        {
            IGenericRepo<Laptop>repo=this.factory.GetRepo<Laptop>();
            repo.Insert(new Laptop() { Id = 1, Model = "Acer Swift Go 14 SFG14-41-R5RB", Processor = "Ryzen 5", Ram = 8, HardDisk = 1000, DisplaySize = 14, Warranty = 2, Price= 74000.00M });
            repo.InsertRange(new Laptop[]
            {
                new Laptop() { Id = 2, Model ="Gigabyte Gaming G5 KE", Processor="Core i5", Ram=8, HardDisk = 1000, DisplaySize= 15.6, Warranty = 2, Price= 85000.00M },
                new Laptop() {Id =3, Model ="Asus VivoBook Pro 15", Processor ="Ryzen 7", Ram = 8, HardDisk=500, DisplaySize=14, Warranty=2, Price = 139500.00M}
            });
            Console.WriteLine("Insert Data");
            repo.Get()
                .ToList()
                .ForEach(l=>Console.WriteLine($"ID: {l.Id},\nModel: {l.Model}, Processor: {l.Processor},\nRam: {l.Ram} GB, HardDisk: {l.HardDisk} GB,\nDisplay: {l.DisplaySize}inch, Warranty: {l.Warranty} Years, \nPrice: {l.Price} BDT"));
            Console.WriteLine();
            Console.WriteLine("Update Data");
            var laptop =repo.Get(1);
            laptop.Price = 65000.00M;
            repo.Update(laptop);
            repo.Get()
                .ToList()
                .ForEach(l => Console.WriteLine($"ID: {l.Id},\nModel: {l.Model}, Processor: {l.Processor},\nRam: {l.Ram} GB, HardDisk: {l.HardDisk} GB,\nDisplay: {l.DisplaySize}inch, Warranty: {l.Warranty} Years, \nPrice: {l.Price} BDT"));
            Console.WriteLine();
            Console.WriteLine("Delete Data");
            repo.Delete(1);
            repo.Get()
                .ToList()
                .ForEach(l => Console.WriteLine($"ID: {l.Id},\nModel: {l.Model}, Processor: {l.Processor},\nRam: {l.Ram} GB, HardDisk: {l.HardDisk} GB,\nDisplay: {l.DisplaySize}inch, Warranty: {l.Warranty} Years, \nPrice: {l.Price} BDT"));
            Console.WriteLine();





        }



    }
}
