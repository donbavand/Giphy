using System.Threading.Tasks;
using Giphy.Libs.Models;

namespace Giphy.Libs.Services
{
    public interface IGiphyServices
    {
        Task<GiphyModel> GetRandomGifBasedOnSearchCritera(string searchCritera);
    }
}