using System;
using System.Collections.Generic;
using PandemicCodingDojo.Commons;
using PandemicCodingDojo.SimulationParameters;

namespace PandemicCodingDojo
{
    public class Population
    {
        private readonly Humans _humans;

        public Population()
        {
            _humans = new Humans();
        }

        public void Populate(PopulationSize populationSize)
        {
            _humans.Clear();
            _humans.AddRange(populationSize.CreateHumans());
        }

        public Humans CreateContacts(Human self, Number number)
        {
            var contacts = new Humans();
            var possibleContacts = _humans.Except(self);
            void Action() => RanomContact(possibleContacts, contacts);
            number.DoAction(Action);
            return contacts;
        }

        private static void RanomContact(Humans possibleContacts, Humans contacts)
        {
            var contact = possibleContacts.ExtractRandom();
            contacts.Add(contact);
        }
    }
}