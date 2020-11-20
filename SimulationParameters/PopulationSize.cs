using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace PandemicCodingDojo.SimulationParameters
{
    public class PopulationSize
    {
        private int _size;

        public PopulationSize(int size)
        {
            _size = size;
        }

        public Humans CreateHumans()
        {
            var humans = new Humans();
            for (int i = 0; i < _size; i++)
            {
                humans.Add(new Human());
            }

            return humans;
        }
    }
}