using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Contracts
{
    public interface IRepositoryAssociativeEntity<T> where T : IAssociativeEntity 
    {
        List<T> GetAllByLeftEntityId(int leftEntityId);
        List<T> GetAllByRightEntityId(int rightEntityId);
        T GetById(int leftEntityId, int rightEntityId);
        System.Dynamic.ExpandoObject Add(T associativeEntity);
        void Delete(T associativeEntity);
        void Delete(int leftEntityId, int rightEntityId);
    }
}
