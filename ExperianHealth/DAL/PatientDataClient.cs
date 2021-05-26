using ExperianHealth.Api.Model;
using ExperianHealth.DataClient.DAL.Interface;
using Microsoft.Extensions.Caching.Memory;

namespace ExperianHealth.DataClient.DAL
{
    public class PatientDataClient : IPatient
    {       
        private IMemoryCache _cache;
        public PatientDataClient(IMemoryCache cache)
        {           
            _cache = cache;
        }
        public PatientDetails GetPatientDetails(int patientId)
        {           
            return _cache.Get<PatientDetails>(patientId);
        }

        public void InsertPatientDetails(PatientDetails request)
        { 
            _cache.Set(request.Id, request);
        }
    }
}