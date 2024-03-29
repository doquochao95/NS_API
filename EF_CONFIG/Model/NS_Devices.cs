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
    
    public partial class NS_Devices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NS_Devices()
        {
            this.NS_Export = new HashSet<NS_Export>();
            this.NS_PostRecords = new HashSet<NS_PostRecords>();
            this.NS_RecycledBox = new HashSet<NS_RecycledBox>();
            this.NS_Requests = new HashSet<NS_Requests>();
            this.NS_Staffs = new HashSet<NS_Staffs>();
            this.NS_Stocks = new HashSet<NS_Stocks>();
            this.NS_Imports = new HashSet<NS_Imports>();
        }
    
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string DeviceCode { get; set; }
        public string OnlineStatus { get; set; }
        public int BuildingID { get; set; }
    
        public virtual NS_Buildings NS_Buildings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_Export> NS_Export { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_PostRecords> NS_PostRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_RecycledBox> NS_RecycledBox { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_Requests> NS_Requests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_Staffs> NS_Staffs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_Stocks> NS_Stocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NS_Imports> NS_Imports { get; set; }
    }
}
