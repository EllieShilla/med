//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace med
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recover
    {
        public int id { get; set; }
        public int PatientId { get; set; }
        public int IllnessID { get; set; }
        public System.DateTime DateFrom { get; set; }
        public System.DateTime DateTo { get; set; }
    
        public virtual Illness Illness { get; set; }
    }
}
