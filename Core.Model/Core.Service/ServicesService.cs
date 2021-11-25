using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data;
using Core.Model.Models;

namespace Core.Service
{
    class ServicesService : IService<Model.Models.Service>,IServicesService
    {
        private readonly IRepositoryWrapper _repowrapper;

        public ServicesService(IRepositoryWrapper repowrapper)
        {
            _repowrapper = repowrapper;
        }
        public void Add(Model.Models.Service entity)
        {
            _repowrapper.ServiceRepository.Add(entity);
        }

        public void Delete(Model.Models.Service entity)
        {
            _repowrapper.ServiceRepository.Delete(entity);
        }

        public IQueryable<Model.Models.Service> GetAll()
        {
           return _repowrapper.ServiceRepository.GetAll();
        }

        public Model.Models.Service GetById(int id)
        {
            return _repowrapper.ServiceRepository.GetById(id);
        }

        public void SaveChanges()
        {
            _repowrapper.ServiceRepository.Commit();
        }

        public void Update(Model.Models.Service entity)
        {
            _repowrapper.ServiceRepository.Update(entity);
        }
    }
    public interface IServicesService:IService<Model.Models.Service>
    {

    }
}
