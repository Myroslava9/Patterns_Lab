using Dirt.Models.Interfaces;
using Soil.Models.Interfaces;

namespace Dirt.Adapter
{
    public class SoilToDirtAdapter : IDirt
    {
        private readonly ISoil _soil;

        public SoilToDirtAdapter(ISoil soil)
        {
            _soil = soil;
        }

        public string GetDirtInfo()
        {
            return $"Soil wrapped with dirt, soil info \"{_soil.GetSoilInfo()}\"";
        }
    }
}
