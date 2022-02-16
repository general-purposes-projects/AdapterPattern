namespace AdapterPattern.EngineAdapter
{
    public class EngineAdapter: ElectricEngine
    {
        private readonly HydrogenEngine _hydrogenEngine;
        public EngineAdapter(HydrogenEngine engine, ushort initialBattery) : base(initialBattery)
        {
            _hydrogenEngine = engine;
        }

        public override void ChargeBattery (int flowChargeControl)
        {
            base.ChargeBattery(_hydrogenEngine.GetFuel() * 2);
        }
    }
}