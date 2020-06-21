using Soil.Models.Interfaces;

namespace Soil.Models
{
    public class PoorSoil : ISoil
    {
        private readonly int _fertility;

        public PoorSoil(int fertility)
        {
            _fertility = fertility;
        }

        public string GetSoilInfo()
        {
            return $"The fertility of this soil is {_fertility}, which makes this soil rich";
        }
    }
}