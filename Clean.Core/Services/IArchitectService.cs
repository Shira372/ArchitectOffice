using Clean.Core.Models;

public interface IArchitectService
{
    Task<List<Architect>> GetAllAsync();  // שינוי לפונקציה אסינכרונית
    Task<Architect> GetItemAsync(int id);  // שינוי לפונקציה אסינכרונית
    Task PostAsync(Architect architect);  // שינוי לפונקציה אסינכרונית
    Task<int> PutByArchitectAsync(int id, Architect architect);  // שינוי לפונקציה אסינכרונית
    Task<int> PutByStatusAsync(int id, int status);  // שינוי לפונקציה אסינכרונית
}
