using Soil.Models;
using Soil.Models.Interfaces;

namespace Soil.Factory
{
    public class SoilFactory
    {

        public SoilFactory()
        {

        }

        public ISoil CreateSoil(int fertility)
        {
            if (fertility < 50)
            {
                return new PoorSoil(fertility);
            }

            return new RichSoil(fertility);
        }
    }
}
