using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject_Date
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Title { get; set; }

        public virtual List<Email> Emails { get; set; }
    }
}
