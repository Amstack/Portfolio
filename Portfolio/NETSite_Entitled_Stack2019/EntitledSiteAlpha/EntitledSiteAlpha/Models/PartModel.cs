using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntitledSiteAlpha.Models
{
    public class PartModel
    {
        [Display(Name = "DKP")]
        public int dkp { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }
    }
}
