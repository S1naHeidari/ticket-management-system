//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class transfer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transfer()
        {
            this.accepted = "خیر";
        }
    
        public string id { get; set; }
        public int requestCode { get; set; }
        public int currentSemester { get; set; }
        public string destinationName { get; set; }
        public Nullable<int> unitCount { get; set; }
        public Nullable<int> destConfirmNumber { get; set; }
        public Nullable<System.DateTime> destConfirmDate { get; set; }
        public string accepted { get; set; }
        public Nullable<System.DateTime> sendDate { get; set; }
    
        public virtual student student { get; set; }
    }
}
