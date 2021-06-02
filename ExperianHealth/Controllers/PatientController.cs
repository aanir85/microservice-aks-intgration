using ExperianHealth.Api.Model;
using ExperianHealth.DataClient.DAL;
using ExperianHealth.DataClient.DAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ExperianHealth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PatientController : ControllerBase
    {
        private readonly IPatient _iPatient;
        public PatientController(IMemoryCache cache)
        {
            _iPatient = new PatientDataClient(cache);
        }

        /// <summary>
        /// GetPatientDetails will get patient detail for the provided patient Id
        /// </summary>
        /// <param name="patientId">Provide valid integer value</param>
        /// <returns></returns>

        [HttpGet("[action]")]
        [Produces("application/json")]
        public async Task<ActionResult<PatientDetails>> GetPatientDetailsAsync([Required] int patientId)
        {           
            var result = _iPatient.GetPatientDetails(patientId);
            if (result == null)
                return NotFound($"Sorry No record found for the patient Id {patientId}");

            return Ok(result);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> AddOrModifyPatientDetailsAsync([FromBody] PatientDetails request)
        {
            _iPatient.InsertPatientDetails(request);

            return Ok($"Added successfully details for patient Id {request.Id}");
        }
    }
}