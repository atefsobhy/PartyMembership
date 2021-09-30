using Microsoft.EntityFrameworkCore;
using PartyMembership.Data;
using PartyMembership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyMembership.Services
{
    public class MemberService
    {
        private readonly ApplicationDbContext _appDbContext;

        public MemberService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Member> GetMemberAsync(int Id)
        {
            var member = await _appDbContext.Members
                .Include(x=>x.Party)
                .FirstOrDefaultAsync(x => x.MemberId.Equals(Id));
            return member;
        }
     
        public async Task<List<Member>> GetAllMembersAsync()
        {
            return await _appDbContext.Members
                .Include(x => x.Party)
                .Include(x => x.Gender)
                .ToListAsync();
        }

        public async Task<bool> AddMemberAsync(Member member)
        {
            await _appDbContext.Members.AddAsync(member);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateMemberAsync(Member member)
        {
            _appDbContext.Members.Update(member);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteMemberAsync(Member member)
        {
            _appDbContext.Remove(member);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        public List<Gender> GetAllGenders()
        {
            var result =  _appDbContext.Genders.ToList();
            
            return result;
        }
    }
}
