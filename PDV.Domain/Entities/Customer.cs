using System;
using System.Collections.Generic;
using System.Text;

namespace PDV.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string Version { get; set; }
        
        public DateTime Create { get; set; }

        public int TypeIdentificationId { get; set; }
        public  virtual  TypdeIdentification TypeIdentification { get; set; }

    }
}
