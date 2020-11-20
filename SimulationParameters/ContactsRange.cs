using PandemicCodingDojo.Commons;

namespace PandemicCodingDojo.SimulationParameters
{
    public class ContactsRange
    {
        private readonly Number _lowerThreshold;
        private readonly Number _upperThreshold;

        public ContactsRange(Number lowerThreshold, Number upperThreshold)
        {
            _lowerThreshold = lowerThreshold;
            _upperThreshold = upperThreshold;
        }

        public Number SimulateCount()
        {
            return _lowerThreshold.NextRandom(_upperThreshold);
        }
    }
}