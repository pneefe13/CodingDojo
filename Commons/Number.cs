using System;

namespace PandemicCodingDojo.Commons
{
    public class Number
    {
        private readonly int _number;

        public Number(int number)
        {
            _number = number;
        }

        public Number Subtract(Number subtrahend)
        {
            return new Number(_number - subtrahend._number);
        }

        public Number NextRandom(Number maxValue)
        {
            var random = new Random();
            return new Number(random.Next(_number, maxValue._number));
        }

        public void DoAction(Action action)
        {
            for(var i = 0; i < _number; i++)
                action.Invoke();
        }
    }
}