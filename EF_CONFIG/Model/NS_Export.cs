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
    
    public partial class NS_Export
    {
        public int ExportID { get; set; }
        public int DeviceID { get; set; }
        public int NeedleID { get; set; }
        public System.DateTime ExportTime { get; set; }
        public string ExprtTimeString { get; set; }
        public int Quantity { get; set; }
        public int StaffID { get; set; }
        public int BuildingID { get; set; }
    
        public virtual NS_Buildings NS_Buildings { get; set; }
        public virtual NS_Devices NS_Devices { get; set; }
        public virtual NS_Needles NS_Needles { get; set; }
        public virtual NS_Staffs NS_Staffs { get; set; }
    }
}
