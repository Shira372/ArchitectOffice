using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
using Clean.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Service
{
    public class MeetingService : IMeetingService
    {
        private readonly IMeetingRepository _meetingRepository;
        public MeetingService(IMeetingRepository meetingRepository)
        {
            _meetingRepository = meetingRepository;
        }
        public List<Meeting> GetAll()
        {
            return _meetingRepository.GetAll();
        }

        public Meeting Get(int id)
        {
            return _meetingRepository.Get(id);
        }

        public Meeting GetByStart(DateTime dateTime)
        {
            return _meetingRepository.GetByStart(dateTime);
        }
        public void Post(Meeting meeting)
        {
            _meetingRepository.Post(meeting);
        }

        public int Put(int id, Meeting meeting)
        {
            return _meetingRepository.Put(id, meeting);
        }

        public int Delete(int id)
        {
            return _meetingRepository.Delete(id);
        }
    }
}
