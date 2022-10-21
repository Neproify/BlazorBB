using BlazorBB.Data.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BlazorBB.Data
{
    public class ForumService
    {
        protected ApplicationDbContext _context { get; set; }

        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Forum[]> GetForumsAsync()
        {
            return await _context.Forums.ToArrayAsync();
        }

        public async Task<Forum> GetByID(int ID)
        {
            return await _context.Forums.FirstAsync(x => x.ID == ID);
        }
    }
}
