using System;
using AdapterPattern.EngineAdapter;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricEngine engine;
            
            HydrogenEngine hydrogenEngine = new HydrogenEngine(1);
            
            engine = new EngineAdapter.EngineAdapter(hydrogenEngine, 2);
            
            Console.WriteLine(engine.ShutDown());

            engine.ChargeBattery(1);
            
            Console.WriteLine(engine.ShowBattery());

            Console.WriteLine(engine.Start()); 
        }
    }
}
