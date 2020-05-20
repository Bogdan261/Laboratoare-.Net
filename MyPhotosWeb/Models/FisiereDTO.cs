using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWeb.Models
{
    public class FisiereDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FisiereDTO()
        {
            this.Persoane = new HashSet<PersoaneDTO>();
            this.Locatii = new HashSet<LocatiiDTO>();
            this.Evenimente = new HashSet<EvenimenteDTO>();
            this.Atribute = new HashSet<AtributeDTO>();
        }
        
        public int IdFisier { get; set; }
       
        public string Nume { get; set; }
       
        public string Path { get; set; }
       
        public System.DateTime DataCreare { get; set; }
        
        public string Tip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      
        public virtual ICollection<PersoaneDTO> Persoane { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
       
        public virtual ICollection<LocatiiDTO> Locatii { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
  
        public virtual ICollection<EvenimenteDTO> Evenimente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    
        public virtual ICollection<AtributeDTO> Atribute { get; set; }
    }
}
