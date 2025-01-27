using Clean.Core.Models;
using Clean.Core.Repositories;
//using Clean.Data.Services;

public class ArchitectService : IArchitectService
{
    private readonly IArchitectRepository _architectRepository;

    public ArchitectService(IArchitectRepository architectRepository)
    {
        _architectRepository = architectRepository;
    }

    public async Task<List<Architect>> GetAllAsync()
    {
        return await _architectRepository.GetAllAsync();  // שינוי לפונקציה אסינכרונית
    }

    public async Task<Architect> GetItemAsync(int id)
    {
        return await _architectRepository.GetItemAsync(id);
    }

    public async Task<int> PutByArchitectAsync(Architect architect)
    {
        return await _architectRepository.PutByArchitectAsync(architect);
    }

    public async Task<int> PutByArchitectAsync(int id, Architect architect)
    {
        return await _architectRepository.PutByArchitectAsync(id, architect);  // שינוי לפונקציה אסינכרונית
    }

    public async Task<int> PutByStatusAsync(int id, int status)
    {
        return await _architectRepository.PutByStatusAsync(id, status);  // שינוי לפונקציה אסינכרונית
    }

    public async Task PostAsync(Architect architect)
    {
        await _architectRepository.PostAsync(architect);  // הפונקציה הזו יכולה להיות אסינכרונית
    }
}
