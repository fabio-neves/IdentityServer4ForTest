using IdentityServer4.Models;
using IdentityServer4.Stores;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    public class UpdatableClientStore : IClientStore
    {
        private readonly List<Client> _clients;

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryClientStore"/> class.
        /// </summary>
        /// <param name="clients">The clients.</param>
        public UpdatableClientStore(IOptionsSnapshot<List<Client>> cs)
        {
            _clients = cs.Value;
        }

        /// <summary>
        /// Finds a client by id
        /// </summary>
        /// <param name="clientId">The client id</param>
        /// <returns>
        /// The client
        /// </returns>
        public Task<Client> FindClientByIdAsync(string clientId)
        {
            var query =
                from client in _clients
                where client.ClientId == clientId
                select client;

            return Task.FromResult(query.SingleOrDefault());
        }
    }
}
