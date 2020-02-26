using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntitledSiteAlpha.Models
{
    public class BankModel
    {
        [Display(Name = "Id")]
        public int ItemID { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Count is required.")]
        public int Count { get; set; }

        [Required(ErrorMessage = "Image link is required.")]
        public string Link { get; set; }

        [Required(ErrorMessage = "Gold cost is required.")]
        public int GoldCost { get; set; }

        [Required(ErrorMessage = "DKP cost is required.")]
        public int DKPCost { get; set; }
    }
}
