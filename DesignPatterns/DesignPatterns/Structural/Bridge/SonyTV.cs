namespace DesignPatterns.Structural.Bridge
{
    internal class SonyTV : Device
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Sony: Set Channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn On");
        }
    }
}
