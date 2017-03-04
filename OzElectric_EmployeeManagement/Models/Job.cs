﻿namespace OzElectric_EmployeeManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    //[Table("Jobs")]
    public partial class Job
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Job()
        //{
        //    Enrollments = new HashSet<Enrollment>();
        //}

        [Key]
        public int JobID { get; set; }

        //[Required]
        //[StringLength(100)]
        public string LocationName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public Foreman Foreman { get; set; }

        public SiteSuper SiteSuper { get; set; }

        public PM PM { get; set; }

        public Purchaser Purchaser { get; set; }

        public GenContractor GenContractor { get; set; }

        public string GenContractorContact { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}