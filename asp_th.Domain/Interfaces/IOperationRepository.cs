using asp_th.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace asp_th.Domain.Interfaces
{
    public interface IOperationRepository
    {
        List<Operation> GetAll();
        Operation GetById(int operationId);
        Operation Insert(Operation newOperation);
        Operation Update(int operationId, Operation operation);
        bool RemoveById(int operationId);
        int SaveChanges();
    }
}
