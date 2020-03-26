using Medicaid.Core.Master;
using MediCaid.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
            if(model.Id>0)
            {
                var response = await _IPatientRepo.Update(model);
                if (response == Common.ResponseStatus.UpdatedSuccessFully)
                    return Ok("Patient updated Successfully");

                return BadRequest("Error patient updation. Please contact Admin Department");
            }
            else
            {
                var response = await _IPatientRepo.CreateEntity(model);
                if (response == Common.ResponseStatus.AddedSuccessfully)
                    return Ok("Patient Created Successfully");

                return BadRequest("Error patient creation. Please contact Admin Department");
            }
           
        }

        public async Task<IActionResult> GetPatients()
        {
            return Ok(await _IPatientRepo.GetList(x => x.IsActive == 1));
        }

        public async Task<IActionResult> GetPatientById(int id)
        {
            return Ok(await _IPatientRepo.GetSingle(x => x.Id == id));
        }
    }
}