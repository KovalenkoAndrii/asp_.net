using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace asp_th.Domain.Entites
{
    public class Visit
    {
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Operation")]
        public int OperationId { get; set; }
        public Operation Operation { get; set; }

        public string VisitDate { get; set; }
    }
}
