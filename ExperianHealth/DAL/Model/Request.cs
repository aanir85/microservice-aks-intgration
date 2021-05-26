using ExperianHealth.Api.Helper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExperianHealth.Api.Model
{
    public class PatientDetails
    {
        [ValidationPatient]       
        public int Id { get; set; }

        [Required (ErrorMessage ="Provide patient Name")]        
        public string Name { get; set; }

        [ValidationPatient]
        public int Age { get; set; }

        [DisplayName("ContactNumber")]
        public string ContactNo { get; set; } 
    }
}
