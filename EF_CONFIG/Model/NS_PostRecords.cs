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
    
    public partial class NS_PostRecords
    {
        public int PostRecordID { get; set; }
        public Nullable<System.DateTime> PostTime { get; set; }
        public string PostTimeStr { get; set; }
        public int DeviceID { get; set; }
        public int BuildingID { get; set; }
    
        public virtual NS_Buildings NS_Buildings { get; set; }
        public virtual NS_Devices NS_Devices { get; set; }
    }
}
