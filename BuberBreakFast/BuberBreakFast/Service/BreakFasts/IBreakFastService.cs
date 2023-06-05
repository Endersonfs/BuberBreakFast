using BuberBreakFast.Constracts.BreakFast;
using BuberBreakFast.Models;

namespace BuberBreakFast.Service.BreakFasts
{
    public interface IBreakFastService
    {
        void CreateBreakFast(Breakfast breakfast);
        Breakfast GetBreakfast(Guid id);

    }
}
