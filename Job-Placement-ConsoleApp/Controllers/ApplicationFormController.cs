using DATA.Model;
using DATA.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Job_Placement_ConsoleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationFormController : ControllerBase
    {
        private readonly IApplicationFormRepository _applicationFormRepository;

        public ApplicationFormController(IApplicationFormRepository applicationFormRepository)
        {
            _applicationFormRepository = applicationFormRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetJob(int id)
        {
            var job = await _applicationFormRepository.GetApplicationFormAsync(id);
            return Ok(job);
        }
        [HttpPost]
        public async Task<IActionResult> AddApplication(ApplicationForm applicationForm)
        {
            var postBook = await _applicationFormRepository.AddApplicationFormAsync(applicationForm);
            return Ok(postBook);
        }
    }

}
