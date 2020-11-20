using System;
using System.Collections.Generic;
using System.Linq;
using PandemicCodingDojo.Commons;

namespace PandemicCodingDojo
{
    public class Humans
    {
        private List<Human> _persons;

        public Humans(IEnumerable<Human> persons)
        {
            _persons = persons.ToList();
        }

        public Humans()
        {
            _persons = new List<Human>();
        }

        public void Clear()
        {
            _persons.Clear();
        }

        public void AddRange(Humans humans)
        {
            _persons.AddRange(humans._persons);
        }

        public void Add(Human human)
        {
            _persons.Add(human);
        }

        public Humans Except(Human self)
        {
            var persons = _persons.ToList();
            persons.Remove(self);
            return new Humans(persons);
        }

        public Number Count()
        {
            return new Number(_persons.Count);
        }

        public Human ExtractRandom()
        {
            var random = new Random();
            var index = random.Next(_persons.Count);
            var human = _persons[index];
            _persons.Remove(human);
            return human;
        }
    }
}