using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5
{
    [Table("Business")] 
    public class Business 
    {[Key] 
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int BusinessId { get; protected set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; } 
    }

    [Table("eCommerce")] 
    public class eCommerce : Business 
    { public string URL { get; set; } 
    
    }

    [Table("Retail")]
    public class Retail : Business
    { public string Address { get; set; } 
      public string City { get; set; } 
      public string State { get; set; } 
      public string ZIPCode { get; set; } 
    }
}
