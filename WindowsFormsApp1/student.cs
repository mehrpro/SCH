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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Registereds = new HashSet<Registered>();
            this.StudentTAGs = new HashSet<StudentTAG>();
        }
    
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName { get; set; }
        public string StudentCode { get; set; }
        public string StudentNatinalCode { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HomePhone { get; set; }
        public string FatherPhone { get; set; }
        public string MotherPhone { get; set; }
        public string SMS { get; set; }
        public System.DateTime BrithDate { get; set; }
        public System.DateTime RegDate { get; set; }
        public bool Enabled { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registered> Registereds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentTAG> StudentTAGs { get; set; }
    }
}
