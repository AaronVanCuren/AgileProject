using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject_Data
{
    public class Department
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        //-- Future Update: Turn this into an enum (standardize the naming convention of departments)
        public string DeptName { get; set; }
        public virtual List<Profile> Profiles { get; set; }

    }
}
