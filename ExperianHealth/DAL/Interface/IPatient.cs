using ExperianHealth.Api.Model;

namespace ExperianHealth.DataClient.DAL.Interface
{
    interface IPatient
    {
        PatientDetails GetPatientDetails(int patientId);

        void InsertPatientDetails(PatientDetails request);
    }
}
