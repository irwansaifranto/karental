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
    
    public partial class owner
    {
        public owner()
        {
            this.cars = new HashSet<car>();
            this.car_package = new HashSet<car_package>();
            this.customers = new HashSet<customer>();
            this.d_notification = new HashSet<d_notification>();
            this.drivers = new HashSet<driver>();
            this.owner_user = new HashSet<owner_user>();
            this.rents = new HashSet<rent>();
        }
    
        public System.Guid id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string created_by { get; set; }
        public System.DateTimeOffset created_time { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTimeOffset> updated_time { get; set; }
        public string logo { get; set; }
        public string contact { get; set; }
        public string terms { get; set; }
        public int id_city { get; set; }
    
        public virtual ICollection<car> cars { get; set; }
        public virtual ICollection<car_package> car_package { get; set; }
        public virtual city city { get; set; }
        public virtual ICollection<customer> customers { get; set; }
        public virtual ICollection<d_notification> d_notification { get; set; }
        public virtual ICollection<driver> drivers { get; set; }
        public virtual ICollection<owner_user> owner_user { get; set; }
        public virtual ICollection<rent> rents { get; set; }
    }
}
