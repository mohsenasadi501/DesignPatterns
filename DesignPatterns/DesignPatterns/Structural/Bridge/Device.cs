namespace DesignPatterns.Structural.Bridge
{
    internal interface Device
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}
