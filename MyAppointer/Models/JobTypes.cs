//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyAppointer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobTypes
    {
        public JobTypes()
        {
            this.Jobs = new HashSet<Jobs>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}