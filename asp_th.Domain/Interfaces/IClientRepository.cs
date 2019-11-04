using asp_th.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace asp_th.Domain.Interfaces
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetById(int clientId);
        Client Insert(Client newClient);
        Client Update(int clientId, Client client);
        bool RemoveById(int clientId);
        int SaveChanges();
    }
}
