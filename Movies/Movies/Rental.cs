//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movies
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int CustomerID { get; set; }
        public int DiskID { get; set; }
        public System.DateTime CheckOutDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
