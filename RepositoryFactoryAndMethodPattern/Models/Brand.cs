using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    public class Brand : IEntityBase
    {
        public enum UsageType { Personal, Business, Official}
        public int Id {  get; set; }
        public string BrandName { get; set; }
        public string HO { get; set; }
        public UsageType Type { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}, Brand Name: {BrandName}, Head Office: {HO}, Usage Type: {Type}";
        }

    }
}
