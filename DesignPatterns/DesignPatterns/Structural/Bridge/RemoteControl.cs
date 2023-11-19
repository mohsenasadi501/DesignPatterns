namespace DesignPatterns.Structural.Bridge
{
    internal class RemoteControl
    {
        protected readonly Device _device;

        public RemoteControl(Device device)
        {
            _device = device;
        }
        public void TurnOn()
        {
            _device.TurnOn();
        }
        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
