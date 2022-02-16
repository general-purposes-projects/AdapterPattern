using System;

namespace AdapterPattern.EngineAdapter
{
    public sealed class HydrogenEngine:IEngine
    {
        private int _hydrogenFuel;
        private const int MaxFuel = 40;

        public HydrogenEngine()
        {
        }

        public HydrogenEngine(int fuel)
        {
            _hydrogenFuel = fuel;
        }

        public string Start()
        {
            return "I'm on";
        }

        public string ShutDown()
        {
            return "Bye";
        }

        public void LoadFuel(int hydrogen)
        {
            if (_hydrogenFuel + hydrogen <= MaxFuel)
            {
                _hydrogenFuel += _hydrogenFuel;
            }
            else
            {
                throw new Exception("Too much fuel");
            }
        }

        public int GetFuel()
        {
            return _hydrogenFuel;
        }

        public string ShowFuel()
        {
            return $"Hydrogen level: " +
                   $"\n {(_hydrogenFuel < 10? "low fuel, please charge ASAP.": _hydrogenFuel <= 25? "Medium level": _hydrogenFuel <= 40? "I'm good with fuel.": _hydrogenFuel)}";
        }
    }
}