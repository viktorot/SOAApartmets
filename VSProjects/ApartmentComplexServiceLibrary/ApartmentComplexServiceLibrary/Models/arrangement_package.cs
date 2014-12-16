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
    
    public partial class arrangement_package
    {
        public arrangement_package()
        {
            this.bookings = new HashSet<booking>();
            this.apartments = new HashSet<apartment>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string max_resevations { get; set; }
        public Nullable<int> valid_from { get; set; }
        public Nullable<int> valid_to { get; set; }
        public Nullable<float> price { get; set; }
    
        public virtual ICollection<booking> bookings { get; set; }
        public virtual ICollection<apartment> apartments { get; set; }
    }
}