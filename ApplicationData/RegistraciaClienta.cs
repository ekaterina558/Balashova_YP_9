//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Balashova_YP_9.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistraciaClienta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegistraciaClienta()
        {
            this.ZapisNaPriem = new HashSet<ZapisNaPriem>();
        }
    
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string NomerTelefona { get; set; }
        public System.DateTime DataRozdenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZapisNaPriem> ZapisNaPriem { get; set; }
    }
}
