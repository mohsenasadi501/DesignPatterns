namespace DesignPatterns.Structural.Bridge
{
    internal class SamsungTV : Device
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Samsung:Set Channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung:Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung:Turn On");
        }
    }
}
