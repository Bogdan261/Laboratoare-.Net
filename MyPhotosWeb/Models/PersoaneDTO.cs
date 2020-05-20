using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWeb.Models
{
    public class PersoaneDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersoaneDTO()
        {
            this.Fisiere = new HashSet<FisiereDTO>();
        }
      
        public int IdPersoana { get; set; }
      
        public string Nume { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FisiereDTO> Fisiere { get; set; }
    }
}
