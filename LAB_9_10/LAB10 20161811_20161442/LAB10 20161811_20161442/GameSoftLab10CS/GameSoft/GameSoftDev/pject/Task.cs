using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev.pject
{
    public class Task : WorkUnit
    {
        private BindingList<Participant> _participants;
        private Money _money;
        private Time _time;
        private BindingList<Product> _products;

        public Task()
        {
            _participants = new BindingList<Participant>();
            _money = new Money();
            _time = new Time();
            _products = new BindingList<Product>();
        }

        public BindingList<Participant> Participants { get => _participants; set => _participants = value; }
        public Money Money { get => _money; set => _money = value; }
        public Time Time { get => _time; set => _time = value; }
        public BindingList<Product> Products { get => _products; set => _products = value; }
        public String MoneyCurrency { get => _money.Currency; set => _money.Currency = value; }
        public float MoneyQuantity { get => _money.Quantity; set => _money.Quantity = value; }
        public String TimeUnitMeasure { get => _time.MeasureUnit; set => _time.MeasureUnit = value; }
        public float TimeQuantity { get => _time.Quantity; set => _time.Quantity = value; }

        public String ParticipantsReport {
            get {
                String report = "";
                for (int i = 0; i < _participants.Count(); i++)
                {
                    report = report + _participants[i].FullName;
                    if (!(i+1 == _participants.Count())) report = report + "\n";
                }
                return report;
            }
        }
    }
}
