using System.Net.Http;
using System.Threading.Tasks;
using WilliamCooney.Diablo3.Domain.Entities;

namespace WilliamCooney.Diablo3.Domain.Repositories
{
    public interface IBaseRepository
    {
        Task<CareerProfile> GetCareerProfile(string battletag);
        Task<HeroProfile> GetHeroProfile(string battletag, string id);
        Task<ItemData> GetItemData(string id);
    }
}