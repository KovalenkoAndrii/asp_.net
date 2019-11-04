using asp_th.Domain.Entites;
using System.Collections.Generic;

namespace asp_th.Domain.Interfaces
{
    public interface IVisitRepository
    {
        List<Visit> GetAll();
        Visit GetById(int visitId);
        Visit Insert(Visit newVisit);
        Visit Update(int visitId, Visit visit);
        bool RemoveById(int visitId);
        int SaveChanges();
    }
}
