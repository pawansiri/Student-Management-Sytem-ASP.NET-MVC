//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student_Management_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int RegisterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NIC { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> BatchID { get; set; }
        public Nullable<int> Telephone { get; set; }
    
        public virtual Batch Batch { get; set; }
        public virtual Course Course { get; set; }
    }
}
