using System.Threading.Tasks;
using Giphy.Libs.Models;

namespace Giphy.Libs.Giphy
{
    public interface IGetRandomGif
    {
        Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCritera);
    }
}