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
    
    public partial class review
    {
        public int id { get; set; }
        public string comment { get; set; }
        public int grade { get; set; }
        public int apartment_id { get; set; }
        public int customer_id { get; set; }
    
        public virtual apartment apartment { get; set; }
        public virtual customer customer { get; set; }
    }
}
