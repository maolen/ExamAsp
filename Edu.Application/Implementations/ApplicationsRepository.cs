using Domain.DataAccess;
using Domain.Model;

using Edu.Infrastructure.Services;

namespace Edu.Infrastructure.Implementations
{
    public class ApplicationsRepository : IApplicationsRepository
    {
        private readonly AppDataContext _context;

        public ApplicationsRepository(AppDataContext context)
        {
            _context = context;
        }

        public Application Create(Application application)
        {
            var createdApplication = _context.Applications.Add(application);
            _context.SaveChanges();
            return createdApplication.Entity;
        }

        public Application Delete(int id)
        {
            var deleteApplication = GetById(id);
            if(deleteApplication != null)
            {
                _context.Applications.Remove(deleteApplication);
                _context.SaveChanges();
                return deleteApplication;
            }
            return null;
        }

        public Application GetById(int id)
        {
           return _context.Applications.Find(id);
        }

        public Application Update(Application application)
        {
            var updateApplication = GetById(application.Id);
            _context.Applications.Update(updateApplication);
            _context.SaveChanges();
            return updateApplication;
        }
    }
}
