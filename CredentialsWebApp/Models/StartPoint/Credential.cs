using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CredentialsWebApp.Models
{
    public class Credential
    {
        [Key]
        public int CredentialID { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string CredentialAddress { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string CredentialUN { get; set; }
        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string CredentialPW { get; set; }
    }
}
