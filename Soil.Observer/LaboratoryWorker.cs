using System;
using Soil.Observer.Interfaces;

namespace Soil.Observer
{

    public class LaboratoryWorker : IObserver
    {
        private IObservable _analyzer;

        public LaboratoryWorker(IObservable analyzer)
        {
            _analyzer = analyzer;
            _analyzer.RegisterObserver(this);
        }

        public void Update(object rep)
        {
            var report = (string)rep;

            Console.WriteLine($"The analyzer analyzed the new soil, here is the report : \n \'{report}\'");
        }
    }
}