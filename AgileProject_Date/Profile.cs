using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject_Data
{
    public class Profile
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string DeptId { get; set; }
        [ForeignKey(nameof(DeptId))]
        public virtual Department Department { get; set; }
        Guid Guid { get; set; }


    }
}
