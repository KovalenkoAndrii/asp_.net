using System;
using System.Collections.Generic;
using System.Text;

namespace asp_th.Domain.Entites
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string AccountNumber { get; set; }
        public string PassportNumber { get; set; }

        public string Address { get; set; }
    }
}
