using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AdapterPattern.EngineAdapter
{
    public abstract class ElectricEngine: IEngine, IElectric
    {
        private int _fuel;
        private const int MaxFuel = 10;

        public ElectricEngine(int fuel)
        {
            _fuel = fuel;
        }

        public virtual string Start()
        {
            return "I Start";
        }

        public virtual string ShutDown()
        {
            return "I'm off";
        }

        public virtual void ChargeBattery(int flowChargeControl)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
                while (_fuel + flowChargeControl <= MaxFuel)
                {
                    _fuel += flowChargeControl;
                    Console.WriteLine($"Loading... {_fuel}");
                    Thread.Sleep(1000);
                }
            stopwatch.Stop();
            Console.WriteLine($"Load time {TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).Seconds } seconds, have a nice eco-journey!!!");
        }

        public virtual string ShowBattery()
        {
            return $"actual battery: {_fuel}";
        }

    }
}