using asp_th.Domain;
using asp_th.Domain.Entites;
using asp_th.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace asp_th.Repository
{
    public class ClientRepository : IClientRepository
    {
        protected readonly MyDbContext Context;
        protected DbSet<Client> Entities;

        public ClientRepository(MyDbContext context)
        {
            Context = context;
            Entities = context.Set<Client>();
        }

        public List<Client> GetAll()
        {
            return Entities
                .ToList();
        }

        public Client GetById(int clientId)
        {
            return Entities
                .FirstOrDefault(f => f.Id == clientId);
        }

        public Client Insert(Client newClient)
        {
            if (newClient == null)
            {
                throw new ArgumentNullException(nameof(newClient));
            }

            Entities.Add(newClient);

            SaveChanges();

            return newClient;
        }

        public Client Update(int clientId, Client client)
        {
            Client dbClient = GetById(clientId);

            if (dbClient == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            dbClient.FullName = client.FullName;
            dbClient.PassportNumber = client.PassportNumber;
            dbClient.AccountNumber = client.AccountNumber;
            dbClient.Address = client.Address;

            client.Id = dbClient.Id;

            SaveChanges();

            return client;
        }

        public bool RemoveById(int clientId)
        {
            Client client = GetById(clientId);

            if (client == null)
            {
                throw new Exception("Client was not found.");
            }

            Entities.Remove(client);

            SaveChanges();

            return true;
        }

        public int SaveChanges()
        {
            return Context
                .SaveChanges();
        }
    }
}
