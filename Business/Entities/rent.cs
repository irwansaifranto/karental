//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class rent
    {
        public rent()
        {
            this.api_rent = new HashSet<api_rent>();
            this.expenses = new HashSet<expense>();
            this.invoices = new HashSet<invoice>();
            this.rent_package = new HashSet<rent_package>();
            this.rent_position = new HashSet<rent_position>();
        }
    
        public System.Guid id { get; set; }
        public System.Guid id_customer { get; set; }
        public System.Guid id_owner { get; set; }
        public string pickup_location { get; set; }
        public Nullable<System.Guid> id_driver { get; set; }
        public System.Guid id_car_model { get; set; }
        public Nullable<System.Guid> id_car { get; set; }
        public System.DateTimeOffset start_rent { get; set; }
        public System.DateTimeOffset finish_rent { get; set; }
        public int price { get; set; }
        public string notes { get; set; }
        public string code { get; set; }
        public string created_by { get; set; }
        public System.DateTimeOffset created_time { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTimeOffset> updated_time { get; set; }
        public string status { get; set; }
        public string cancel_notes { get; set; }
        public Nullable<System.Guid> id_car_package { get; set; }
        public Nullable<int> discount { get; set; }
        public int package_price { get; set; }
    
        public virtual ICollection<api_rent> api_rent { get; set; }
        public virtual car car { get; set; }
        public virtual car_model car_model { get; set; }
        public virtual customer customer { get; set; }
        public virtual driver driver { get; set; }
        public virtual ICollection<expense> expenses { get; set; }
        public virtual ICollection<invoice> invoices { get; set; }
        public virtual owner owner { get; set; }
        public virtual ICollection<rent_package> rent_package { get; set; }
        public virtual ICollection<rent_position> rent_position { get; set; }
    }
}
