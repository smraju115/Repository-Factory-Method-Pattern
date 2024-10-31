using RepositoryFactoryAndMethodPattern.Models;
using RepositoryFactoryAndMethodPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.DITests
{
    public class DITest2
    {
        private IGenericRepo<Brand> repo;
        public DITest2(IGenericRepo<Brand> repo)
        {
            this.repo = repo;
        }
        public void RunBrand()
        {
            this.repo.Insert(new Brand { Id= 1, BrandName="Lenovo", HO="Dhaka, Bangladesh", Type=Brand.UsageType.Personal});
            this.repo.InsertRange(new Brand[]
            {
                new Brand { Id= 2, BrandName= "Dell", HO="Bangladesh", Type = Brand.UsageType.Personal},
                new Brand { Id= 3, BrandName= "HP", HO="BD", Type=Brand.UsageType.Personal}
            });
            Console.WriteLine("Insert Data");
            this.repo.Get()
                .ToList()
                .ForEach(b => Console.WriteLine($"ID: {b.Id},\nBrand Name: {b.BrandName},\nHead Office: {b.HO}, Usage Type: {b.Type}"));
            Console.WriteLine();
            Console.WriteLine("Update Data");
            var brand = repo.Get(1);
            brand.BrandName = "Toshiba";
            this.repo.Update(brand);
            this.repo.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"ID: {b.Id},\nBrand Name: {b.BrandName},\nHead Office: {b.HO}, Usage Type: {b.Type}"));
            Console.WriteLine();
            Console.WriteLine("Delete Data");
            this.repo.Delete(1);
            this.repo.Get()
               .ToList()
               .ForEach(b => Console.WriteLine($"ID: {b.Id},\nBrand Name: {b.BrandName},\nHead Office: {b.HO}, Usage Type: {b.Type}"));
            Console.WriteLine();




        }
    }
}
