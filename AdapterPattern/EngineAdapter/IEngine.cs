namespace AdapterPattern.EngineAdapter
{
    public interface IEngine
    {
        public string Start();

        public string ShutDown();
    }

    public interface IElectric
    {
        public void ChargeBattery(int flowChargeControl);
        public string ShowBattery();
    }
}