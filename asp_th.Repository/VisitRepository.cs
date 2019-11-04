using asp_th.Domain;
using asp_th.Domain.Entites;
using asp_th.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asp_th.Repository
{
    public class VisitRepository : IVisitRepository
    {
        protected readonly MyDbContext Context;
        protected DbSet<Visit> Entities;

        public VisitRepository(MyDbContext context)
        {
            Context = context;
            Entities = context.Set<Visit>();
        }

        public List<Visit> GetAll()
        {
            return Entities
                    .ToList();
        }

        public Visit GetById(int visitId)
        {
            return Entities
                 .FirstOrDefault(f => f.Id == visitId);
        }

        public Visit Insert(Visit newVisit)
        {
            if (newVisit == null)
            {
                throw new ArgumentNullException(nameof(newVisit));
            }

            Entities.Add(newVisit);

            SaveChanges();

            return newVisit;
        }

        public bool RemoveById(int visitId)
        {
            Visit visit = GetById(visitId);

            if (visit == null)
            {
                throw new Exception("Visit was not found.");
            }

            Entities.Remove(visit);

            SaveChanges();

            return true;
        }

        public int SaveChanges()
        {
            return Context
                    .SaveChanges();
        }

        public Visit Update(int visitId, Visit visit)
        {
            Visit dbVisit = GetById(visitId);

            if (dbVisit == null)
            {
                throw new ArgumentNullException(nameof(visit));
            }

            dbVisit.VisitDate = visit.VisitDate;

            dbVisit.ClientId = visit.ClientId;
            dbVisit.OperationId = visit.OperationId;

            visit.Id = dbVisit.Id;

            SaveChanges();

            return visit;
        }
    }
}
