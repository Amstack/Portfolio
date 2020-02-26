using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntitledSiteAlpha.Models
{
    public class RosterModel
    {
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "DKP")]
        public int dkp { get; set; }

        [Display(Name = "# of Donations")]
        public int numDonations { get; set; }
    }
}
