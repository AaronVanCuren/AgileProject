using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject_Date
{
    public class Email
    {
        [Key]
        [Required]
        public int Email_Id { get; set; }
        [Required]
        public Guid Author {get; set;}
        [Required]
        public string Title { get; set; }
        [Required]
        public string Subject { get; set; }
        public virtual List<string> Department { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
