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
    
    public partial class ZapisNaPriem
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public System.DateTime DateOfAdmission { get; set; }
        public Nullable<int> VrachiID { get; set; }
        public Nullable<int> RegistraciaClientaID { get; set; }
    
        public virtual RegistraciaClienta RegistraciaClienta { get; set; }
        public virtual Vrachi Vrachi { get; set; }
    }
}
