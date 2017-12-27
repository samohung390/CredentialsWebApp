using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CredentialsWebApp.Models
{
    public class CredAdmin
    {
        [Key]
        public int CredAdminID { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string CredAdminName { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string CredAdminUN { get; set; }
        [StringLength(20, MinimumLength = 5)]
        [Required]
        public string CredAdminPW { get; set; }
    }
}
