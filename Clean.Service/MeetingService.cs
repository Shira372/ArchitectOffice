using ArchitectsOffice.Entities;
using Clean.Core.Models;
using Clean.Core.Repositories;
using Clean.Core.Services;
using System;
using System.Collections.Generic;
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

        public async Task<List<Meeting>> GetAllAsync()
        {
            return await _meetingRepository.GetAllAsync();
        }

        public async Task<Meeting> GetAsync(int id)
        {
            return await _meetingRepository.GetAsync(id);
        }

        public async Task<Meeting> GetByStartAsync(DateTime start)
        {
            return await _meetingRepository.GetByStartAsync(start);
        }

        public async Task PostAsync(Meeting meeting)
        {
            await _meetingRepository.PostAsync(meeting);
        }

        public async Task<int> PutAsync(int id, Meeting meeting)
        {
            return await _meetingRepository.PutAsync(id, meeting);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _meetingRepository.DeleteAsync(id);
        }
    }
}
