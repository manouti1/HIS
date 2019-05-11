using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }


        [HttpGet]
        [Route("ListPatients")]
        public IEnumerable<Patient> GetPatients()
        {
            try
            {
                return _patientService.GetPatients();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}