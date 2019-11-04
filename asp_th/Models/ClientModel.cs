using asp_th.Domain.Entites;
using System.ComponentModel.DataAnnotations;

namespace Labs_asp_three.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string AccountNumber { get; set; }
        public string PassportNumber { get; set; }

        public string Address { get; set; }

        public ClientModel(Client clientEntity)
        {
            Id = clientEntity.Id;

            FullName = clientEntity.FullName;
            PassportNumber = clientEntity.PassportNumber;
            AccountNumber = clientEntity.AccountNumber;

            Address = clientEntity.Address;
        }
    }
}
