using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    public  class Laptop : IEntityBase
    {
        public int Id { get ; set; }
        public string Model {  get; set; }
        public string Processor { get; set; }
        public int Ram {  get; set; }
        public int HardDisk {  get; set; }
        public double DisplaySize {  get; set; }
        public int Warranty {  get; set; }
        public decimal Price {  get; set; }
    }
}
