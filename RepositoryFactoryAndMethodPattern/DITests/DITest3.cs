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
    public class DITest3
    {
        private IRepoFactory factory;
        public DITest3(IRepoFactory factory)
        {
            this.factory = factory;
        }
        public void RunCustomer()
        {
            IGenericRepo<CustomerInformation>repo=this.factory.GetRepo<CustomerInformation>();
            repo.Insert(new CustomerInformation() {Id=101, CName="Raju", CNumber=01605105418, Email="smraju115@gmail.com", Address="Dhaka, Bangladesh", CStatus="VIP" });
            repo.InsertRange(new CustomerInformation[]
            {
                new CustomerInformation() {Id=102, CName="Choyon", CNumber=01755684586, Email="choyon@gmail.com", Address="Dhaka, Mirpur-2", CStatus="VIP"},
                new CustomerInformation() {Id=103, CName="Akib", CNumber=01685976759, Email="akib@yahoo.com", Address="Dhaka, Mirpur-1", CStatus="Normal"}
            });
            Console.WriteLine("Insert Customer Data");
            repo.Get()
                .ToList()
                .ForEach(c =>Console.WriteLine($"ID:{c.Id},\nCustomer Name: {c.CName}, \nCustomer Number: {c.CNumber}, \nEmail: {c.Email}, \nAddress: {c.Address}, \nCustomer Status: {c.CStatus}"));
            Console.WriteLine();
            Console.WriteLine("Update Customer Information");
            var customer = repo.Get(103);
            customer.CNumber = 01555255552;
            repo.Update(customer);
            repo.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"ID:{c.Id},\nCustomer Name: {c.CName}, \nCustomer Number: {c.CNumber}, \nEmail: {c.Email}, \nAddress: {c.Address}, \nCustomer Status: {c.CStatus}"));
            Console.WriteLine();
            Console.WriteLine("Delete Data");
            repo.Delete(103);
            repo.Get()
                .ToList()
                .ForEach(c => Console.WriteLine($"ID:{c.Id},\nCustomer Name: {c.CName}, \nCustomer Number: {c.CNumber}, \nEmail: {c.Email}, \nAddress: {c.Address}, \nCustomer Status: {c.CStatus}"));
            Console.WriteLine();


        }
    }
}
