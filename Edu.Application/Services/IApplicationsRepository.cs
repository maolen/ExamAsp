using System;
using System.Collections.Generic;
using System.Text;

using Domain.Model;

namespace Edu.Infrastructure.Services
{
    public interface IApplicationsRepository
    {
        Application GetById(int id);
        Application Create(Application application);
        Application Update(Application application);
        Application Delete(int id);
        
    }
}
