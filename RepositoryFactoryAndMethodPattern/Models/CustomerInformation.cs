using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Models
{
    partial class CustomerInformation : IEntityBase
    {
        public int Id {  get; set; }
        public string CName { get; set; }
        public int CNumber {  get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CStatus { get; set; }

    }
}
