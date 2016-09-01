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
    
    public partial class car
    {
        public car()
        {
            this.car_expense = new HashSet<car_expense>();
            this.rents = new HashSet<rent>();
        }
    
        public System.Guid id { get; set; }
        public System.Guid id_car_model { get; set; }
        public string license_plate { get; set; }
        public Nullable<int> capacity { get; set; }
        public string status { get; set; }
        public bool is_active { get; set; }
        public System.Guid id_owner { get; set; }
        public Nullable<int> model_year { get; set; }
        public string transmission { get; set; }
        public string fuel { get; set; }
        public string color { get; set; }
        public string photo { get; set; }
        public string vehicle_registration_file { get; set; }
        public string tax_file { get; set; }
    
        public virtual car_model car_model { get; set; }
        public virtual ICollection<car_expense> car_expense { get; set; }
        public virtual owner owner { get; set; }
        public virtual ICollection<rent> rents { get; set; }
    }
}
