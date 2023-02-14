using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace People.Models.DataModels
{
    public class Company
    {
        public int Id { get; set; }

        [Display(Name = "#")]
        public string CenterNumber { get; set; }

        [Display(Name = "Namn")]
        public string CompanyName { get; set; }

        [Display(Name = "Beskrivning")]
        public string Description { get; set; }
        
    }
}
