//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class academic_year
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public academic_year()
        {
            this.registereds = new HashSet<registered>();
        }
    
        public int ID { get; set; }
        public string years_name { get; set; }
        public System.DateTime years_start { get; set; }
        public System.DateTime years_finish { get; set; }
        public sbyte enabled { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<registered> registereds { get; set; }
    }
}
