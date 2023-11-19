namespace DesignPatterns.Structural.Bridge
{
    internal class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(Device device) : base(device)
        {
        }
        public void SetChannel(int number)
        {
            _device.SetChannel(number);
        }
    }
}
