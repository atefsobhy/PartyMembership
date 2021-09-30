using Microsoft.EntityFrameworkCore;
using PartyMembership.Data;
using PartyMembership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMembership.Services
{
    public class PartyService
    {
        private readonly ApplicationDbContext _appDbContext;

        public PartyService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Party GetParty(int Id)
        {
            var party =  _appDbContext.Parties.FirstOrDefault(x => x.PartyId.Equals(Id));
            return party;
        }

        public async Task<List<Party>> GetAllPartiesAsync()
        {
            return  await _appDbContext.Parties.ToListAsync();
        }

        public async Task<bool> AddPartyAsync(Party party)
        {
            await _appDbContext.Parties.AddAsync(party);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdatePartyAsync(Party party)
        {
            _appDbContext.Parties.Update(party);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePartyAsync(Party party)
        {
            _appDbContext.Remove(party);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
    }
}
