using asp_th.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_th.Models
{
    public class OperationModel
    {
        public int Id { get; set; }

        public int Contribution { get; set; }

        public int Payment { get; set; }

        public OperationModel(Operation operationEntity)
        {
            Id = operationEntity.Id;

            Contribution = operationEntity.Contribution;
            Payment = operationEntity.Payment;
        }
    }
}
