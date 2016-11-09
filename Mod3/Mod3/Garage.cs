using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod3
{
    public class Garage : IEnumerable<String>
    {
        private System.Collections.Generic.List<String> _cars;

        public Garage(int capacity)
        {
            this.Capacity = capacity;
            _cars = new List<string>();
        }

        public int Capacity { get; }


        public int NumberOfCars => _cars.Count;

        public void Park(string carName)
        {
            _cars.Add(carName);
            Console.WriteLine($"Car {carName} added");
            if (CarParked != null)
            {
                CarParked(carName, DateTime.Now, this.Capacity - this.NumberOfCars);
            }
        }

        public void Fetch(string carName)
        {
            if (_cars.Remove(carName))
            {
                Console.WriteLine($"Car found,{carName} leaving garage");
                if (CarLeft != null)
                {
                    CarLeft(carName, DateTime.Now, this.Capacity - this.NumberOfCars);
                }
            }
            else
            {
                throw new InvalidOperationException();
            }

        }
        public override string ToString()
        {
            StringBuilder output=new StringBuilder();
            foreach (string aCar in _cars)
            {
                output.Append($"{aCar} \n");
            }
            return output.ToString();
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in _cars)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public string this[int index] => _cars[index];
        public event Action<string,DateTime,int> CarParked;
        public event Action<string, DateTime, int> CarLeft;

    }
}