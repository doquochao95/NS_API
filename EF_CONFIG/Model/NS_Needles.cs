//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_CONFIG.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NS_Needles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NS_Needles()
        {
            this.NS_Export = new HashSet<NS_Export>();
            this.NS_Imports = new HashSet<NS_Imports>();
            this.NS_Stocks = new HashSet<NS_Stocks>();
        }
    
        public int NeedleID { get; set; }
        public string NeedleName { get; set; }
        public string NeedleCode { get; set; }
        public string NeedleSize { get; set; }
        public string NeedlePoint { get; set; }
        public decimal NeedlePrice { get; set; }
        public Nullable<decimal> NeedleLength { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_Export> NS_Export { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_Imports> NS_Imports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_Stocks> NS_Stocks { get; set; }
    }
}
