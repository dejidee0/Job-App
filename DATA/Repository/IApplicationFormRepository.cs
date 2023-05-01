using DATA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Repository
{
    public interface IApplicationFormRepository
    {
        Task<ApplicationForm> GetApplicationFormAsync(int id);
        Task<ApplicationForm> AddApplicationFormAsync(ApplicationForm applicationForm);
    }
}
