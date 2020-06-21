using System.Collections.Generic;
using Soil.Models.Interfaces;
using Soil.Observer.Interfaces;

namespace Soil.Observer
{
    public class SoilAnalyzer : IObservable
    {
        readonly List<IObserver> _observers;
        private string _report;

        public SoilAnalyzer()
        {
            _observers = new List<IObserver>();
            _report = "";
        }

        public void Analyze(ISoil soil)
        {
            _report = soil.GetSoilInfo();
            NotifyObservers();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                o.Update(_report);
            }
        }
    }
}