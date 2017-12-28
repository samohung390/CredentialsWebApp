using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CredentialsWebApp.Models.StartPoint
{
    public enum Access
    {
        NA = 1, RO = 2, RW = 3
    }
    public class CredAdminLink
    {

        [Key]
        public int CredAdminLinkID { get; set; }

        [Required]
        public int CredAdminID { get; set; }
        [ForeignKey("CredAdminID")]
        public virtual CredAdmin CredAdmin { get; set; }

        [Required]
        public int CredentialID { get; set; }
        [ForeignKey("CredentialID")]
        public virtual Credential Credential { get; set; }

        [Required]
        public Access Access { get; set; }
    }
}
