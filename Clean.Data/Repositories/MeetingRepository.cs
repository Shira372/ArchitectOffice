using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly DataContext _context;

        public MeetingRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Meeting>> GetAllAsync()
        {
            return await _context.Meetings.ToListAsync();
        }

        public async Task<Meeting> GetAsync(int id)
        {
            return await _context.Meetings.FindAsync(id);
        }

        public async Task<Meeting> GetByStartAsync(DateTime start)
        {
            return await _context.Meetings
                .FirstOrDefaultAsync(u => u.Start.Equals(start));
        }

        public async Task PostAsync(Meeting meeting)
        {
            await _context.Meetings.AddAsync(meeting);
           //await _context.SaveChangesAsync();
        }

        public async Task<int> PutAsync(int id, Meeting meeting)
        {
            var existingMeeting = await _context.Meetings.FindAsync(id);
            if (existingMeeting == null)
            {
                return 0; // Meeting not found
            }

            _context.Entry(existingMeeting).CurrentValues.SetValues(meeting);
            //await _context.SaveChangesAsync();
            return 1; // Successful update
        }

        public async Task<int> DeleteAsync(int id)
        {
            var meeting = await _context.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return 0; // Meeting not found
            }

            _context.Meetings.Remove(meeting);
           //await _context.SaveChangesAsync();
            return 1; // Successful deletion
        }
    }
}
