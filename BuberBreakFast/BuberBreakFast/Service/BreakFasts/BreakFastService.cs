using BuberBreakFast.Models;

namespace BuberBreakFast.Service.BreakFasts
{
    public class BreakFastService : IBreakFastService
    {
        private static readonly Dictionary<Guid, Breakfast> _breakFast = new();
        public void CreateBreakFast(Breakfast breakfast)
        {
            _breakFast.Add(breakfast.Id, breakfast);
        }

        public Breakfast GetBreakfast(Guid id)
        {
            return _breakFast[id];
        }
    }
}
