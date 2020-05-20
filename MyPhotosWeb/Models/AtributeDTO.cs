using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWeb.Models
{
    public class AtributeDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AtributeDTO()
        {
            this.Fisiere = new HashSet<FisiereDTO>();
        }       
        public int IdAtribut { get; set; }       
        public string Name { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]       
        public virtual ICollection<FisiereDTO> Fisiere { get; set; }
    }
}
