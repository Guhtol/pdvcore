using System;
using System.Collections.Generic;
using System.Text;

namespace PDV.Dto.Registration
{
    public class CustomerDto 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public string Version { get; set; }

        public DateTime Create { get; set; }

        public int TypeIdentificationId { get; set; }
        public TypeIdentificationDto TypeIdentification { get; set; }

    }
}
