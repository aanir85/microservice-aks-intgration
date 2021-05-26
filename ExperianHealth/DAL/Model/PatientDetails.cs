using ExperianHealth.Api.Helper;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExperianHealth.Api.Model
{
    public class PatientDetails
    {       
        public int Id { get; set; }
        public string Name { get; set; }      
        public int Age { get; set; }
        public string ContactNo { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
