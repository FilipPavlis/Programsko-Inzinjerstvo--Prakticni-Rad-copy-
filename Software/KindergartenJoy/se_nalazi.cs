//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KindergartenJoy
{
    using System;
    using System.Collections.Generic;
    
    public partial class se_nalazi
    {
        public int evidencija_id { get; set; }
        public int dijete_id { get; set; }
    
        public virtual dijete dijete { get; set; }
        public virtual evidencija evidencija { get; set; }
        public virtual se_nalazi se_nalazi1 { get; set; }
        public virtual se_nalazi se_nalazi2 { get; set; }
    }
}