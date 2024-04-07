namespace DesignPatterns.Behavioral.Template
{
    /// <summary>
    /// Concrete Class 
    /// </summary>
    internal class TransferMoneyTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("The MneyTansfer has done Correctly");
        }
    }
}
