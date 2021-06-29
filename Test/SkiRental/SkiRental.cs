using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    class SkiRental
    {
        public List<Ski> data { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }

        public SkiRental(string name, int capacity)
        {
            data = new List<Ski>();
            Name = name;
            Capacity = capacity;
        }

        public void Add(Ski ski)
        {
            if (Count+1<=Capacity)
            {
                data.Add(ski);
                Count++;
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (data.Remove(GetSki(manufacturer, model)))
            {
                Count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Ski GetNewestSki()
        {
            int maxYear = int.MinValue;
            Ski maxSkiYear = null;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Year>maxYear)
                {
                    maxSkiYear = data[i];
                    maxYear = data[i].Year;
                }
            }
            return maxSkiYear;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Manufacturer == manufacturer && data[i].Model == model)
                {
                    return data[i];
                }
            }
            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            for (int i = 0; i < data.Count; i++)
            {
                sb.AppendLine(data[i].ToString());
            }
            return sb.ToString();
        }
    }
}
