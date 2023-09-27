using InterraWebBackend.Models;

namespace InterraWebBackend.Repository
{
    public interface IQuickLinkRepository
    {
        Task<List<QuickLinkModel>> GetAllQuickLinksAsync();
    }
}
