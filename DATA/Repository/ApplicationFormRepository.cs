using DATA.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repository
{
    public class ApplicationFormRepository : IApplicationFormRepository
    {
        private readonly AppDBContext _appDBContext;

        public ApplicationFormRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        
        public async Task<ApplicationForm> GetApplicationFormAsync(int id)
        {
            
            var getform = await _appDBContext.ApplicationForms.FirstOrDefaultAsync(job=>job.ApplicationFormId == id);
            return getform;
        }

        

       public async Task<ApplicationForm> AddApplicationFormAsync(ApplicationForm applicationForm)
        {
            var addAppForm = await _appDBContext.ApplicationForms.AddAsync(applicationForm);
            var result = await _appDBContext.SaveChangesAsync();
            return addAppForm.Entity;
        }
    }
}
