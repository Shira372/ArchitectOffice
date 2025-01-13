using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Data.Repositories
{
    public class MeetingRepository: IMeetingRepository
    {
        private readonly DataContext _context;
        public MeetingRepository(DataContext context)
        {
            _context = context;
        }
        public List<Meeting> GetAll()
        {
            return _context.Meetings.ToList();
        }
        public Meeting Get(int id)
        {
            Meeting meeting= _context.Meetings.ToList().Find(u => u.Id == id);
            return meeting;
        }
        public Meeting GetByStart(DateTime start)
        {
            Meeting meeting = _context.Meetings.ToList().Find(u => u.Start.Equals(start));
            return meeting;
        }
        public void Post(Meeting meeting)
        {
            _context.Meetings.Add(meeting);
            _context.SaveChanges();
        }
        public int Put(int id, Meeting meeting)
        {
            for (int i = 0; i < _context.Meetings.ToList().Count; i++)
            {
                if (_context.Meetings.ToList()[i].Id == id)
                {
                    _context.Meetings.ToList().RemoveAt(i);
                    _context.Meetings.ToList().Insert(i, meeting);
                    _context.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }
        public int Delete(int id)
        {
            for (int i = 0; i < _context.Meetings.ToList().Count; i++)
            {
                if (_context.Meetings.ToList()[i].Id == id)
                {
                    _context.Meetings.ToList().RemoveAt(i);
                    _context.SaveChanges();
                    return 1;
                }
            }
            return 0;
        }
    }
}

