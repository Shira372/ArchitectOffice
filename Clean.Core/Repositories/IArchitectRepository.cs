using Clean.Core.Models;

public interface IArchitectRepository
{
    Task<List<Architect>> GetAllAsync();  // שינוי ל-GetAllAsync
    Task<Architect> GetItemAsync(int id);
    Task<int> PutByArchitectAsync(Architect architect);
    Task<int> PutByArchitectAsync(int id, Architect architect);
    Task<int> PutByStatusAsync(int id, int status);
    Task PostAsync(Architect architect);  // הפונקציה הזו יכולה להיות אסינכרונית
}
