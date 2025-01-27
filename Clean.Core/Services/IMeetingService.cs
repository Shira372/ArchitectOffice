using ArchitectsOffice.Entities;
using Clean.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.Core.Services
{
    public interface IMeetingService
    {
        Task<List<Meeting>> GetAllAsync();
        Task<Meeting> GetAsync(int id);
        Task<Meeting> GetByStartAsync(DateTime start);
        Task PostAsync(Meeting meeting);
        Task<int> PutAsync(int id, Meeting meeting);
        Task<int> DeleteAsync(int id);
    }
}
