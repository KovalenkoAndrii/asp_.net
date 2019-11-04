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
    public class OperationRepository : IOperationRepository
    {
        protected readonly MyDbContext Context;
        protected DbSet<Operation> Entities;

        public OperationRepository(MyDbContext context)
        {
            Context = context;
            Entities = context.Set<Operation>();
        }

        public List<Operation> GetAll()
        {
            return Entities
                .ToList();
        }

        public Operation GetById(int operationId)
        {
            return Entities
                .FirstOrDefault(f => f.Id == operationId);
        }

        public Operation Insert(Operation newOperation)
        {
            if (newOperation == null)
            {
                throw new ArgumentNullException(nameof(newOperation));
            }

            Entities.Add(newOperation);

            SaveChanges();

            return newOperation;
        }

        public bool RemoveById(int operationId)
        {
            Operation operation = GetById(operationId);

            if (operation == null)
            {
                throw new Exception("Operation was not found.");
            }

            Entities.Remove(operation);

            SaveChanges();

            return true;
        }

        public int SaveChanges()
        {
            return Context
                    .SaveChanges();
        }

        public Operation Update(int operationId, Operation operation)
        {
            Operation dbOperation = GetById(operationId);

            if (dbOperation == null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            dbOperation.Contribution = operation.Contribution;
            dbOperation.Payment = operation.Payment;

            operation.Id = dbOperation.Id;

            SaveChanges();

            return operation;
        }
    }
}
