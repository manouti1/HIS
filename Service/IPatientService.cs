using Domain;
using System;
using System.Collections.Generic;

namespace Service
{
    public interface IPatientService
    {
        IEnumerable<Patient> GetPatients();
        Patient GetPatient(int id);
        void InsertPatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(int id);
    }
}
