using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medicaid.Core.Master;
using MediCaid.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediCaid.UI.Controllers.Master
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IGenericRepository<PatientMaster, int> _IPatientRepo;
        public PatientController(IGenericRepository<PatientMaster, int> patientRepo)
        {
            _IPatientRepo = patientRepo;
        }

        /// <summary>
        /// Code to Create Patient
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreatePatient(PatientMaster model)
        {
            var response = await _IPatientRepo.CreateEntity(model);
            if (response == Common.ResponseStatus.AddedSuccessfully)
                return Ok("Patient Created Successfully");

            return Ok("Unable to Create Patient");

        }
    }
}