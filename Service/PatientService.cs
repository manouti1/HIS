using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Linq;
using System.Threading.Tasks;
using Repository;

namespace Service
{
    public class PatientService : IPatientService
    {
        private IGenericRepository<Patient> patientRepository;
        private IGenericRepository<Guardian> guardianRepository;

        public PatientService(IGenericRepository<Patient> patientRepository, IGenericRepository<Guardian> guardianRepository)
        {
            this.patientRepository = patientRepository;
            this.guardianRepository = guardianRepository;
        }

        public IEnumerable<Patient> GetPatients()
        {
            return patientRepository.GetAll();
        }

        public Patient GetPatient(int id)
        {
            return patientRepository.Get(id);
        }

        public void InsertPatient(Patient patient)
        {
            patientRepository.Insert(patient);
        }
        public void UpdatePatient(Patient patient)
        {
            patientRepository.Update(patient);
        }

        public void DeletePatient(int id)
        {
            Guardian guardianProfile = guardianRepository.Get(id);
            guardianRepository.Remove(guardianProfile);
            Patient patient = GetPatient(id);
            patientRepository.Remove(patient);
            patientRepository.SaveChanges();
        }

    }
}
