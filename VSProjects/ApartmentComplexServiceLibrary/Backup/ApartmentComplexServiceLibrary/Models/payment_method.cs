//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApartmentComplexServiceLibrary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class payment_method
    {
        public payment_method()
        {
            this.bookings = new HashSet<booking>();
        }
    
        public int id { get; set; }
        public string card_number { get; set; }
        public Nullable<bool> bank_payment { get; set; }
    
        public virtual ICollection<booking> bookings { get; set; }
    }
}
