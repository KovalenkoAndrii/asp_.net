using asp_th.Domain.Entites;
using Labs_asp_three.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_th.Models
{
    public class VisitModel
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public ClientModel Client { get; set; }

        public int OperationId { get; set; }
        public OperationModel Operation { get; set; }

        public string VisitDate { get; set; }

        public VisitModel(Visit visitEntity)
        {
            Id = visitEntity.Id;

            ClientId = visitEntity.Id;

            if (visitEntity.Client != null)
            {
                Client = new ClientModel(visitEntity.Client);
            }

            OperationId = visitEntity.OperationId;

            if (visitEntity.Operation != null)
            {
                Operation = new OperationModel(visitEntity.Operation);
            }
        }
    }
}
